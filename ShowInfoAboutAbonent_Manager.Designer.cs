
namespace PhoneStation
{
    partial class ShowInfoAboutAbonent_Manager
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
            this.abonentDateOfConnection = new System.Windows.Forms.DateTimePicker();
            this.abonentBirthday = new System.Windows.Forms.DateTimePicker();
            this.isConnectedAbonent = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.abonentBalance = new System.Windows.Forms.TextBox();
            this.abonentPassport = new System.Windows.Forms.TextBox();
            this.abonentName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.abonentPhonenumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.infoStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allStaffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.абонентыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoAbonentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allAbonentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tariffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // abonentDateOfConnection
            // 
            this.abonentDateOfConnection.Location = new System.Drawing.Point(245, 294);
            this.abonentDateOfConnection.Margin = new System.Windows.Forms.Padding(4);
            this.abonentDateOfConnection.Name = "abonentDateOfConnection";
            this.abonentDateOfConnection.Size = new System.Drawing.Size(192, 22);
            this.abonentDateOfConnection.TabIndex = 61;
            // 
            // abonentBirthday
            // 
            this.abonentBirthday.Location = new System.Drawing.Point(245, 232);
            this.abonentBirthday.Margin = new System.Windows.Forms.Padding(4);
            this.abonentBirthday.Name = "abonentBirthday";
            this.abonentBirthday.Size = new System.Drawing.Size(192, 22);
            this.abonentBirthday.TabIndex = 60;
            // 
            // isConnectedAbonent
            // 
            this.isConnectedAbonent.AutoSize = true;
            this.isConnectedAbonent.Location = new System.Drawing.Point(245, 403);
            this.isConnectedAbonent.Margin = new System.Windows.Forms.Padding(4);
            this.isConnectedAbonent.Name = "isConnectedAbonent";
            this.isConnectedAbonent.Size = new System.Drawing.Size(18, 17);
            this.isConnectedAbonent.TabIndex = 59;
            this.isConnectedAbonent.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(117, 400);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 58;
            this.label9.Text = "Подключен?";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(245, 447);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 37);
            this.button2.TabIndex = 57;
            this.button2.Text = "Сохранить изменения";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // abonentBalance
            // 
            this.abonentBalance.Location = new System.Drawing.Point(245, 328);
            this.abonentBalance.Margin = new System.Windows.Forms.Padding(4);
            this.abonentBalance.Name = "abonentBalance";
            this.abonentBalance.Size = new System.Drawing.Size(192, 22);
            this.abonentBalance.TabIndex = 56;
            // 
            // abonentPassport
            // 
            this.abonentPassport.Location = new System.Drawing.Point(245, 264);
            this.abonentPassport.Margin = new System.Windows.Forms.Padding(4);
            this.abonentPassport.Name = "abonentPassport";
            this.abonentPassport.Size = new System.Drawing.Size(192, 22);
            this.abonentPassport.TabIndex = 55;
            // 
            // abonentName
            // 
            this.abonentName.Location = new System.Drawing.Point(245, 202);
            this.abonentName.Margin = new System.Windows.Forms.Padding(4);
            this.abonentName.Name = "abonentName";
            this.abonentName.Size = new System.Drawing.Size(285, 22);
            this.abonentName.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(158, 329);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 53;
            this.label7.Text = "Баланс:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(58, 298);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 20);
            this.label6.TabIndex = 52;
            this.label6.Text = "Дата подключения:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(45, 266);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 20);
            this.label5.TabIndex = 51;
            this.label5.Text = "Паспортные данные:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(90, 234);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 50;
            this.label4.Text = "Дата рождения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(181, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 49;
            this.label3.Text = "ФИО:";
            // 
            // abonentPhonenumber
            // 
            this.abonentPhonenumber.Location = new System.Drawing.Point(245, 134);
            this.abonentPhonenumber.Margin = new System.Windows.Forms.Padding(4);
            this.abonentPhonenumber.Name = "abonentPhonenumber";
            this.abonentPhonenumber.Size = new System.Drawing.Size(311, 22);
            this.abonentPhonenumber.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(73, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Номер телефона:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(585, 127);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 37);
            this.button1.TabIndex = 46;
            this.button1.Text = "Показать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(239, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 29);
            this.label1.TabIndex = 45;
            this.label1.Text = "Получить и изменить информацию об абоненте";
            // 
            // cn
            // 
            this.cn.ConnectionString = "Provider=SQLNCLI11;Data Source=localhost;Integrated Security=SSPI;Initial Catalog" +
    "=PhoneStation";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.абонентыToolStripMenuItem,
            this.tariffToolStripMenuItem,
            this.ServicesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1047, 28);
            this.menuStrip1.TabIndex = 62;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoStaffToolStripMenuItem,
            this.addStaffToolStripMenuItem,
            this.deleteStaffToolStripMenuItem,
            this.tasksToolStripMenuItem,
            this.allStaffToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(105, 24);
            this.toolStripMenuItem1.Text = "Сотрудники";
            // 
            // infoStaffToolStripMenuItem
            // 
            this.infoStaffToolStripMenuItem.Name = "infoStaffToolStripMenuItem";
            this.infoStaffToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.infoStaffToolStripMenuItem.Text = "Информация о сотруднике";
            this.infoStaffToolStripMenuItem.Click += new System.EventHandler(this.infoStaffToolStripMenuItem_Click);
            // 
            // addStaffToolStripMenuItem
            // 
            this.addStaffToolStripMenuItem.Name = "addStaffToolStripMenuItem";
            this.addStaffToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.addStaffToolStripMenuItem.Text = "Принять на работу";
            this.addStaffToolStripMenuItem.Click += new System.EventHandler(this.addStaffToolStripMenuItem_Click);
            // 
            // deleteStaffToolStripMenuItem
            // 
            this.deleteStaffToolStripMenuItem.Name = "deleteStaffToolStripMenuItem";
            this.deleteStaffToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.deleteStaffToolStripMenuItem.Text = "Уволить сотрудника";
            this.deleteStaffToolStripMenuItem.Click += new System.EventHandler(this.deleteStaffToolStripMenuItem_Click);
            // 
            // tasksToolStripMenuItem
            // 
            this.tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            this.tasksToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.tasksToolStripMenuItem.Text = "Задачи";
            this.tasksToolStripMenuItem.Click += new System.EventHandler(this.tasksToolStripMenuItem_Click);
            // 
            // allStaffToolStripMenuItem
            // 
            this.allStaffToolStripMenuItem.Name = "allStaffToolStripMenuItem";
            this.allStaffToolStripMenuItem.Size = new System.Drawing.Size(281, 26);
            this.allStaffToolStripMenuItem.Text = "Список всех сотрудников";
            this.allStaffToolStripMenuItem.Click += new System.EventHandler(this.allStaffToolStripMenuItem_Click);
            // 
            // абонентыToolStripMenuItem
            // 
            this.абонентыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.infoAbonentToolStripMenuItem,
            this.allAbonentsToolStripMenuItem});
            this.абонентыToolStripMenuItem.Name = "абонентыToolStripMenuItem";
            this.абонентыToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            this.абонентыToolStripMenuItem.Text = "Абоненты";
            // 
            // infoAbonentToolStripMenuItem
            // 
            this.infoAbonentToolStripMenuItem.Name = "infoAbonentToolStripMenuItem";
            this.infoAbonentToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.infoAbonentToolStripMenuItem.Text = "Информация об абоненте";
            this.infoAbonentToolStripMenuItem.Click += new System.EventHandler(this.infoAbonentToolStripMenuItem_Click);
            // 
            // allAbonentsToolStripMenuItem
            // 
            this.allAbonentsToolStripMenuItem.Name = "allAbonentsToolStripMenuItem";
            this.allAbonentsToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.allAbonentsToolStripMenuItem.Text = "Список абонентов";
            this.allAbonentsToolStripMenuItem.Click += new System.EventHandler(this.allAbonentsToolStripMenuItem_Click);
            // 
            // tariffToolStripMenuItem
            // 
            this.tariffToolStripMenuItem.Name = "tariffToolStripMenuItem";
            this.tariffToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.tariffToolStripMenuItem.Text = "Тарифы";
            this.tariffToolStripMenuItem.Click += new System.EventHandler(this.tariffToolStripMenuItem_Click);
            // 
            // ServicesToolStripMenuItem
            // 
            this.ServicesToolStripMenuItem.Name = "ServicesToolStripMenuItem";
            this.ServicesToolStripMenuItem.Size = new System.Drawing.Size(69, 24);
            this.ServicesToolStripMenuItem.Text = "Услуги";
            this.ServicesToolStripMenuItem.Click += new System.EventHandler(this.ServicesToolStripMenuItem_Click);
            // 
            // ShowInfoAboutAbonent_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 554);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.abonentDateOfConnection);
            this.Controls.Add(this.abonentBirthday);
            this.Controls.Add(this.isConnectedAbonent);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.abonentBalance);
            this.Controls.Add(this.abonentPassport);
            this.Controls.Add(this.abonentName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.abonentPhonenumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "ShowInfoAboutAbonent_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация об абоненте";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker abonentDateOfConnection;
        private System.Windows.Forms.DateTimePicker abonentBirthday;
        private System.Windows.Forms.CheckBox isConnectedAbonent;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox abonentBalance;
        private System.Windows.Forms.TextBox abonentPassport;
        private System.Windows.Forms.TextBox abonentName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox abonentPhonenumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem infoStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem абонентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoAbonentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allAbonentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tariffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ServicesToolStripMenuItem;
    }
}