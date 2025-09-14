using System.Windows.Forms;

namespace TestTask
{
    partial class FormConnectionSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.chkIntegratedSecurity = new System.Windows.Forms.CheckBox();
			this.btnTest = new System.Windows.Forms.Button();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtServer = new System.Windows.Forms.TextBox();
			this.txtDatabase = new System.Windows.Forms.TextBox();
			this.txtUsername = new System.Windows.Forms.TextBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(255, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(208, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Настройка подключение к базе данных";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(57, 74);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Сервер:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(57, 118);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "База данных:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(57, 201);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(106, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Имя пользователя:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(57, 244);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Пароль:";
			// 
			// chkIntegratedSecurity
			// 
			this.chkIntegratedSecurity.AutoSize = true;
			this.chkIntegratedSecurity.Location = new System.Drawing.Point(60, 157);
			this.chkIntegratedSecurity.Name = "chkIntegratedSecurity";
			this.chkIntegratedSecurity.Size = new System.Drawing.Size(297, 17);
			this.chkIntegratedSecurity.TabIndex = 5;
			this.chkIntegratedSecurity.Text = "Использовать встроенную аутентификацию Windows";
			this.chkIntegratedSecurity.UseVisualStyleBackColor = true;
			// 
			// btnTest
			// 
			this.btnTest.Location = new System.Drawing.Point(60, 332);
			this.btnTest.Name = "btnTest";
			this.btnTest.Size = new System.Drawing.Size(91, 41);
			this.btnTest.TabIndex = 6;
			this.btnTest.Text = "Тестовое подключение";
			this.btnTest.UseVisualStyleBackColor = true;
			this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(292, 332);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(91, 41);
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "Сохранить";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(529, 332);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(91, 41);
			this.btnCancel.TabIndex = 8;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
			// 
			// txtServer
			// 
			this.txtServer.Location = new System.Drawing.Point(138, 67);
			this.txtServer.Name = "txtServer";
			this.txtServer.Size = new System.Drawing.Size(222, 20);
			this.txtServer.TabIndex = 9;
			// 
			// txtDatabase
			// 
			this.txtDatabase.Location = new System.Drawing.Point(138, 111);
			this.txtDatabase.Name = "txtDatabase";
			this.txtDatabase.Size = new System.Drawing.Size(222, 20);
			this.txtDatabase.TabIndex = 10;
			// 
			// txtUsername
			// 
			this.txtUsername.Location = new System.Drawing.Point(169, 194);
			this.txtUsername.Name = "txtUsername";
			this.txtUsername.Size = new System.Drawing.Size(222, 20);
			this.txtUsername.TabIndex = 11;
			// 
			// txtPassword
			// 
			this.txtPassword.Location = new System.Drawing.Point(111, 237);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(222, 20);
			this.txtPassword.TabIndex = 12;
			// 
			// FormConnectionSettings
			// 
			this.BackColor = System.Drawing.Color.AliceBlue;
			this.ClientSize = new System.Drawing.Size(754, 424);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.txtDatabase);
			this.Controls.Add(this.txtServer);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnTest);
			this.Controls.Add(this.chkIntegratedSecurity);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "FormConnectionSettings";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private CheckBox chkIntegratedSecurity;
		private Button btnTest;
		private Button btnSave;
		private TextBox txtServer;
		private TextBox txtDatabase;
		private TextBox txtUsername;
		private TextBox txtPassword;
		private Button btnCancel;
	}
}