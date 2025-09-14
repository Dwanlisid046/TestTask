namespace TestTask
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolStripStatusLabel1 = new System.Windows.Forms.StatusStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelLegendFired = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxFilters = new System.Windows.Forms.GroupBox();
            this.buttonApplyFilters = new System.Windows.Forms.Button();
            this.textBoxLastNameFilter = new System.Windows.Forms.TextBox();
            this.comboBoxDepartmentFilter = new System.Windows.Forms.ComboBox();
            this.comboBoxPositionFilter = new System.Windows.Forms.ComboBox();
            this.comboBoxStatusFilter = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelTotalCount = new System.Windows.Forms.Label();
            this.chartStats = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.buttonGenerateStats = new System.Windows.Forms.Button();
            this.radioButtonFired = new System.Windows.Forms.RadioButton();
            this.radioButtonHired = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxStatusStats = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxFilters.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1239, 519);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1239, 519);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage1.Controls.Add(this.toolStripStatusLabel1);
            this.tabPage1.Controls.Add(this.statusStrip1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.groupBoxFilters);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1231, 493);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сотрудники";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Location = new System.Drawing.Point(3, 446);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(1225, 22);
            this.toolStripStatusLabel1.TabIndex = 4;
            this.toolStripStatusLabel1.Text = "statusStrip2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(3, 468);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1225, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelLegendFired);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(8, 377);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 47);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Легенда";
            // 
            // labelLegendFired
            // 
            this.labelLegendFired.AutoSize = true;
            this.labelLegendFired.ForeColor = System.Drawing.Color.DarkRed;
            this.labelLegendFired.Location = new System.Drawing.Point(76, 20);
            this.labelLegendFired.Name = "labelLegendFired";
            this.labelLegendFired.Size = new System.Drawing.Size(77, 13);
            this.labelLegendFired.TabIndex = 2;
            this.labelLegendFired.Text = "■ Уволенные";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Легенда:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(44, 176);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1143, 188);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridView1_DataBindingComplete);
            // 
            // groupBoxFilters
            // 
            this.groupBoxFilters.Controls.Add(this.buttonApplyFilters);
            this.groupBoxFilters.Controls.Add(this.textBoxLastNameFilter);
            this.groupBoxFilters.Controls.Add(this.comboBoxDepartmentFilter);
            this.groupBoxFilters.Controls.Add(this.comboBoxPositionFilter);
            this.groupBoxFilters.Controls.Add(this.comboBoxStatusFilter);
            this.groupBoxFilters.Controls.Add(this.button1);
            this.groupBoxFilters.Controls.Add(this.label4);
            this.groupBoxFilters.Controls.Add(this.label3);
            this.groupBoxFilters.Controls.Add(this.label2);
            this.groupBoxFilters.Controls.Add(this.label1);
            this.groupBoxFilters.Location = new System.Drawing.Point(375, 6);
            this.groupBoxFilters.Name = "groupBoxFilters";
            this.groupBoxFilters.Size = new System.Drawing.Size(471, 164);
            this.groupBoxFilters.TabIndex = 0;
            this.groupBoxFilters.TabStop = false;
            this.groupBoxFilters.Text = "Фильтры";
            // 
            // buttonApplyFilters
            // 
            this.buttonApplyFilters.Location = new System.Drawing.Point(70, 107);
            this.buttonApplyFilters.Name = "buttonApplyFilters";
            this.buttonApplyFilters.Size = new System.Drawing.Size(140, 38);
            this.buttonApplyFilters.TabIndex = 9;
            this.buttonApplyFilters.Text = "Применить фильтры";
            this.buttonApplyFilters.UseVisualStyleBackColor = true;
            this.buttonApplyFilters.Click += new System.EventHandler(this.buttonApplyFilters_Click);
            // 
            // textBoxLastNameFilter
            // 
            this.textBoxLastNameFilter.Location = new System.Drawing.Point(295, 66);
            this.textBoxLastNameFilter.Name = "textBoxLastNameFilter";
            this.textBoxLastNameFilter.Size = new System.Drawing.Size(121, 20);
            this.textBoxLastNameFilter.TabIndex = 8;
            // 
            // comboBoxDepartmentFilter
            // 
            this.comboBoxDepartmentFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDepartmentFilter.FormattingEnabled = true;
            this.comboBoxDepartmentFilter.Location = new System.Drawing.Point(295, 23);
            this.comboBoxDepartmentFilter.Name = "comboBoxDepartmentFilter";
            this.comboBoxDepartmentFilter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDepartmentFilter.TabIndex = 7;
            // 
            // comboBoxPositionFilter
            // 
            this.comboBoxPositionFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPositionFilter.FormattingEnabled = true;
            this.comboBoxPositionFilter.Location = new System.Drawing.Point(70, 63);
            this.comboBoxPositionFilter.Name = "comboBoxPositionFilter";
            this.comboBoxPositionFilter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPositionFilter.TabIndex = 6;
            // 
            // comboBoxStatusFilter
            // 
            this.comboBoxStatusFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatusFilter.FormattingEnabled = true;
            this.comboBoxStatusFilter.Location = new System.Drawing.Point(70, 28);
            this.comboBoxStatusFilter.Name = "comboBoxStatusFilter";
            this.comboBoxStatusFilter.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatusFilter.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 38);
            this.button1.TabIndex = 4;
            this.button1.Text = "Сбросить фильтры";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonResetFilters_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Фамилия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Отдел:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Должность:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Статус:";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.AliceBlue;
            this.tabPage2.Controls.Add(this.labelTotalCount);
            this.tabPage2.Controls.Add(this.chartStats);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1231, 493);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Статистика";
            // 
            // labelTotalCount
            // 
            this.labelTotalCount.AutoSize = true;
            this.labelTotalCount.Location = new System.Drawing.Point(25, 456);
            this.labelTotalCount.Name = "labelTotalCount";
            this.labelTotalCount.Size = new System.Drawing.Size(94, 13);
            this.labelTotalCount.TabIndex = 3;
            this.labelTotalCount.Text = "Итого за период:";
            // 
            // chartStats
            // 
            chartArea2.AxisX.Title = "Дата";
            chartArea2.AxisY.Title = "Количество сотрудников";
            chartArea2.Name = "ChartArea1";
            this.chartStats.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartStats.Legends.Add(legend2);
            this.chartStats.Location = new System.Drawing.Point(198, 197);
            this.chartStats.Name = "chartStats";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Принятые";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Уволенные";
            this.chartStats.Series.Add(series3);
            this.chartStats.Series.Add(series4);
            this.chartStats.Size = new System.Drawing.Size(447, 235);
            this.chartStats.TabIndex = 2;
            this.chartStats.Text = "chart1";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(674, 197);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(227, 90);
            this.dataGridView2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimePickerTo);
            this.groupBox1.Controls.Add(this.dateTimePickerFrom);
            this.groupBox1.Controls.Add(this.buttonGenerateStats);
            this.groupBox1.Controls.Add(this.radioButtonFired);
            this.groupBox1.Controls.Add(this.radioButtonHired);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.comboBoxStatusStats);
            this.groupBox1.Location = new System.Drawing.Point(443, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(436, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры статистики";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(192, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "-";
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(208, 65);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(129, 20);
            this.dateTimePickerTo.TabIndex = 7;
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(57, 65);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(129, 20);
            this.dateTimePickerFrom.TabIndex = 6;
            // 
            // buttonGenerateStats
            // 
            this.buttonGenerateStats.Location = new System.Drawing.Point(141, 131);
            this.buttonGenerateStats.Name = "buttonGenerateStats";
            this.buttonGenerateStats.Size = new System.Drawing.Size(122, 40);
            this.buttonGenerateStats.TabIndex = 5;
            this.buttonGenerateStats.Text = "Сформировать отчет";
            this.buttonGenerateStats.UseVisualStyleBackColor = true;
            this.buttonGenerateStats.Click += new System.EventHandler(this.buttonGenerateStats_Click);
            // 
            // radioButtonFired
            // 
            this.radioButtonFired.AutoSize = true;
            this.radioButtonFired.Location = new System.Drawing.Point(178, 103);
            this.radioButtonFired.Name = "radioButtonFired";
            this.radioButtonFired.Size = new System.Drawing.Size(144, 17);
            this.radioButtonFired.TabIndex = 4;
            this.radioButtonFired.TabStop = true;
            this.radioButtonFired.Text = "Уволенные сотрудники";
            this.radioButtonFired.UseVisualStyleBackColor = true;
            // 
            // radioButtonHired
            // 
            this.radioButtonHired.AutoSize = true;
            this.radioButtonHired.Location = new System.Drawing.Point(10, 103);
            this.radioButtonHired.Name = "radioButtonHired";
            this.radioButtonHired.Size = new System.Drawing.Size(128, 17);
            this.radioButtonHired.TabIndex = 3;
            this.radioButtonHired.TabStop = true;
            this.radioButtonHired.Text = "Принятые на работу";
            this.radioButtonHired.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Период:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Статус:";
            // 
            // comboBoxStatusStats
            // 
            this.comboBoxStatusStats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatusStats.FormattingEnabled = true;
            this.comboBoxStatusStats.Location = new System.Drawing.Point(57, 28);
            this.comboBoxStatusStats.Name = "comboBoxStatusStats";
            this.comboBoxStatusStats.Size = new System.Drawing.Size(121, 21);
            this.comboBoxStatusStats.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1239, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(78, 20);
            this.toolStripMenuItem1.Text = "Настройка";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
            this.ToolStripMenuItem.Text = "Настройка подключения к БД";
            this.ToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 543);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxFilters.ResumeLayout(false);
            this.groupBoxFilters.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartStats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxFilters;
        private System.Windows.Forms.TextBox textBoxLastNameFilter;
        private System.Windows.Forms.ComboBox comboBoxDepartmentFilter;
        private System.Windows.Forms.ComboBox comboBoxPositionFilter;
        private System.Windows.Forms.ComboBox comboBoxStatusFilter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.Button buttonGenerateStats;
        private System.Windows.Forms.RadioButton radioButtonFired;
        private System.Windows.Forms.RadioButton radioButtonHired;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxStatusStats;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartStats;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelLegendFired;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelTotalCount;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.StatusStrip toolStripStatusLabel1;
        private System.Windows.Forms.Button buttonApplyFilters;
    }
}

