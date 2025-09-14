using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using TestTask.Properties;

namespace TestTask
{
    public partial class FormConnectionSettings: Form
    {
        public string ConnectionString { get; private set; }
        public FormConnectionSettings()
        {
            InitializeComponent();
            LoadSavedSettings();
        }

        private void ChkIntegratedSecurity_CheckedChanged(object sender, EventArgs e)
        {
            txtUsername.Enabled = !chkIntegratedSecurity.Checked;
            txtPassword.Enabled = !chkIntegratedSecurity.Checked;

            if (chkIntegratedSecurity.Checked)
            {
                txtUsername.BackColor = SystemColors.Control;
                txtPassword.BackColor = SystemColors.Control;
            }
            else
            {
                txtUsername.BackColor = SystemColors.Window;
                txtPassword.BackColor = SystemColors.Window;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                SaveConnectionSettings();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                TestConnection();
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtServer.Text))
            {
                MessageBox.Show("Введите имя сервера", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDatabase.Text))
            {
                MessageBox.Show("Введите имя базы данных", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!chkIntegratedSecurity.Checked && string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Введите имя пользователя", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void TestConnection()
        {
            try
            {
                string connString = BuildConnectionString();

                using (var connection = new SqlConnection(connString))
                {
                    connection.Open();
                    MessageBox.Show("Подключение успешно!", "Тест подключения",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка подключения: {ex.Message}", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string BuildConnectionString()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
            {
                DataSource = txtServer.Text,
                InitialCatalog = txtDatabase.Text,
                IntegratedSecurity = chkIntegratedSecurity.Checked
            };

            if (!chkIntegratedSecurity.Checked)
            {
                builder.UserID = txtUsername.Text;
                builder.Password = txtPassword.Text;
            }

            return builder.ConnectionString;
        }

        private void SaveConnectionSettings()
        {
            ConnectionString = BuildConnectionString();

            Settings.Default.Server = txtServer.Text;
            Settings.Default.Database = txtDatabase.Text;
            Settings.Default.Username = txtUsername.Text;
            Settings.Default.UseIntegratedSecurity = chkIntegratedSecurity.Checked;
            Settings.Default.Save();
        }

        private void LoadSavedSettings()
        {
            txtServer.Text = Settings.Default.Server;
            txtDatabase.Text = Settings.Default.Database;
            txtUsername.Text = Settings.Default.Username;
            chkIntegratedSecurity.Checked = Settings.Default.UseIntegratedSecurity;

            ChkIntegratedSecurity_CheckedChanged(null, EventArgs.Empty);
        }
    }
}
