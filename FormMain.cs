using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TestTask.Service;
using TestTask.Entity;
using TestTask.Properties;
using System.Windows.Forms.DataVisualization.Charting;

namespace TestTask
{
    public partial class FormMain : Form
    {
        private string connectionString;
        private DatabaseService databaseService;

        public FormMain()
        {
            InitializeComponent();
            LoadConnectionSettings();
        }

        private void LoadConnectionSettings()
        {
            connectionString = Settings.Default.ConnectionString;

            if (string.IsNullOrEmpty(connectionString))
            {
                var result = MessageBox.Show("Не настроено подключение к БД. Настроить сейчас?",
                    "Настройка подключения", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    ToolStripMenuItem_Click(null, EventArgs.Empty);
                }
            }
            else
            {
                InitializeDatabaseConnection(connectionString);
            }
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frmConnectionSetting = new FormConnectionSettings();

                if (frmConnectionSetting.ShowDialog() == DialogResult.OK)
                {
                    string newConnectionString = frmConnectionSetting.ConnectionString;

                    if (!string.IsNullOrEmpty(newConnectionString))
                    {
                        SaveConnectionStringToConfig(newConnectionString);
                        InitializeDatabaseConnection(newConnectionString);
                        RefreshAllData();

                        MessageBox.Show("Подключение успешно настроено!", "Успех",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Настройки подключения не были изменены.", "Информация",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при настройке подключения: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveConnectionStringToConfig(string connString)
        {
            Settings.Default.ConnectionString = connString;
            Settings.Default.Save();
        }

        private void InitializeDatabaseConnection(string connString)
        {
            try
            {
                connectionString = connString;

                databaseService = new DatabaseService(connectionString);
                TestConnection();
                UpdateConnectionStatus("Подключено к БД");

                LoadInitialData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdateConnectionStatus("Ошибка подключения");
            }
        }

        private void TestConnection()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
            }
        }

        private void LoadInitialData()
        {
            try
            {
                LoadFilterData();
                LoadEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadFilterData()
        {
            try
            {
                var dictionaries = databaseService.GetDictionaries();

                FillComboBox(comboBoxStatusFilter, dictionaries.statuses, "Все статусы");
                FillComboBox(comboBoxDepartmentFilter, dictionaries.departments, "Все отделы");
                FillComboBox(comboBoxPositionFilter, dictionaries.positions, "Все должности");
                FillComboBox(comboBoxStatusStats, dictionaries.statuses, "Все статусы");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки справочников: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillComboBox(ComboBox comboBox, List<DictionaryItem> items, string defaultText)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add(defaultText);

            foreach (var item in items.Select(x => x.Name).Distinct())
            {
                comboBox.Items.Add(item);
            }

            comboBox.SelectedIndex = 0;
        }

        private void LoadEmployees()
        {
            try
            {
                string statusFilter = comboBoxStatusFilter.SelectedIndex > 0 ? comboBoxStatusFilter.SelectedItem.ToString() : null;
                string departmentFilter = comboBoxDepartmentFilter.SelectedIndex > 0 ? comboBoxDepartmentFilter.SelectedItem.ToString() : null;
                string positionFilter = comboBoxPositionFilter.SelectedIndex > 0 ? comboBoxPositionFilter.SelectedItem.ToString() : null;
                string lastNameFilter = !string.IsNullOrWhiteSpace(textBoxLastNameFilter.Text) ? textBoxLastNameFilter.Text : null;

                var employees = databaseService.GetEmployees(statusFilter, departmentFilter, positionFilter, lastNameFilter);

                dataGridView1.DataBindingComplete -= DataGridView1_DataBindingComplete;
                dataGridView1.DataBindingComplete += DataGridView1_DataBindingComplete;

                dataGridView1.DataSource = employees;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки сотрудников: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateRowColors()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.DataBoundItem is Employee employee && employee.IsFired)
                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                    row.DefaultCellStyle.ForeColor = Color.DarkRed;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void RefreshAllData()
        {
            LoadFilterData();
            LoadEmployees();
        }

        private void UpdateConnectionStatus(string status)
        {
            if (statusStrip1.InvokeRequired)
            {
                statusStrip1.Invoke(new Action<string>(UpdateConnectionStatus), status);
            }
            else
            {
                toolStripStatusLabel1.Text = status;
                toolStripStatusLabel1.ForeColor = status.Contains("Ошибка") ? Color.Red : Color.Green;
            }
        }

        private void buttonGenerateStats_Click(object sender, EventArgs e)
        {
            GenerateStatistics();
        }

        private void GenerateStatistics()
        {
            try
            {
                if (databaseService == null)
                {
                    MessageBox.Show("Нет подключения к базе данных", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (dateTimePickerFrom.Value > dateTimePickerTo.Value)
                {
                    MessageBox.Show("Начальная дата не может быть больше конечной", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string statusName = comboBoxStatusStats.SelectedIndex > 0 ?
                    comboBoxStatusStats.SelectedItem.ToString() : null;

                List<StatisticsItem> statistics;

                if (radioButtonHired.Checked)
                {
                    statistics = databaseService.GetHiredStatistics(statusName,
                        dateTimePickerFrom.Value, dateTimePickerTo.Value);
                }
                else
                {
                    statistics = databaseService.GetFiredStatistics(statusName,
                        dateTimePickerFrom.Value, dateTimePickerTo.Value);
                }

                DisplayStatistics(statistics);

                UpdateConnectionStatus($"Статистика сгенерирована: {statistics.Count} записей");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка генерации статистики: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdateConnectionStatus("Ошибка генерации статистики");
            }
        }

        private void DisplayStatistics(List<StatisticsItem> statistics)
        {
            dataGridView2.DataSource = null;
            chartStats.Series.Clear();

            if (statistics.Count == 0)
            {
                MessageBox.Show("Нет данных для отображения за выбранный период", "Информация",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dataGridView2.DataSource = statistics;
            FormatStatsDataGridView();

            DisplayChart(statistics);

            ShowStatisticsSummary(statistics);
        }

        private void FormatStatsDataGridView()
        {
            if (dataGridView2.Columns.Count > 0)
            {
                if (dataGridView2.Columns["Date"] != null)
                {
                    dataGridView2.Columns["Date"].HeaderText = "Дата";
                    dataGridView2.Columns["Date"].DefaultCellStyle.Format = "dd.MM.yyyy";
                    dataGridView2.Columns["Date"].Width = 100;
                }

                if (dataGridView2.Columns["Count"] != null)
                {
                    dataGridView2.Columns["Count"].HeaderText = "Количество";
                    dataGridView2.Columns["Count"].Width = 80;
                    dataGridView2.Columns["Count"].DefaultCellStyle.Alignment =
                        DataGridViewContentAlignment.MiddleRight;
                }
            }
        }

        private void DisplayChart(List<StatisticsItem> statistics)
        {
            chartStats.Series.Clear();

            Series series = new Series();
            series.Name = radioButtonHired.Checked ? "Принятые" : "Уволенные";
            series.ChartType = SeriesChartType.Column;
            series.Color = radioButtonHired.Checked ? Color.SteelBlue : Color.IndianRed;
            series.IsValueShownAsLabel = true;
            series.LabelFormat = "N0";

            foreach (var item in statistics)
            {
                DataPoint point = new DataPoint();
                point.SetValueXY(item.Date.ToString("dd.MM"), item.Count);
                point.ToolTip = $"{item.Date:dd.MM.yyyy}: {item.Count} чел.";
                series.Points.Add(point);
            }

            chartStats.Series.Add(series);

            chartStats.ChartAreas[0].AxisX.Title = "Дата";
            chartStats.ChartAreas[0].AxisY.Title = "Количество сотрудников";
            chartStats.ChartAreas[0].AxisX.Interval = 1;
        }

        private void ShowStatisticsSummary(List<StatisticsItem> statistics)
        {
            int totalCount = statistics.Sum(x => x.Count);
            string statsType = radioButtonHired.Checked ? "принятых" : "уволенных";

            labelTotalCount.Text = $"Всего {statsType} за период: {totalCount} сотрудников";
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void buttonResetFilters_Click(object sender, EventArgs e)
        {
            comboBoxStatusFilter.SelectedIndex = 0;
            comboBoxDepartmentFilter.SelectedIndex = 0;
            comboBoxPositionFilter.SelectedIndex = 0;
            textBoxLastNameFilter.Text = "";
            LoadEmployees();
        }

        private void buttonApplyFilters_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                UpdateRowColors();
            }
        }
    }
}