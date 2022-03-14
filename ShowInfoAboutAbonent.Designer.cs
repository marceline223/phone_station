
namespace PhoneStation
{
    partial class ShowInfoAboutAbonent
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
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.abonentPhonenumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.abonentName = new System.Windows.Forms.TextBox();
            this.abonentPassport = new System.Windows.Forms.TextBox();
            this.abonentBalance = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.isConnectedAbonent = new System.Windows.Forms.CheckBox();
            this.abonentBirthday = new System.Windows.Forms.DateTimePicker();
            this.abonentDateOfConnection = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LKStaff_main = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStaff_Abonents = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStaff_connectAbonent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStaff_showInfoAbonent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStaff_appeals = new System.Windows.Forms.ToolStripMenuItem();
            this.StaffTask = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(229, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(620, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Получить и изменить информацию об абоненте";
            // 
            // cn
            // 
            this.cn.ConnectionString = "Provider=SQLNCLI11;Data Source=localhost;Integrated Security=SSPI;Initial Catalog" +
    "=PhoneStation";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(575, 126);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 37);
            this.button1.TabIndex = 24;
            this.button1.Text = "Показать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(63, 135);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Номер телефона:";
            // 
            // abonentPhonenumber
            // 
            this.abonentPhonenumber.Location = new System.Drawing.Point(235, 133);
            this.abonentPhonenumber.Margin = new System.Windows.Forms.Padding(4);
            this.abonentPhonenumber.Name = "abonentPhonenumber";
            this.abonentPhonenumber.Size = new System.Drawing.Size(311, 22);
            this.abonentPhonenumber.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(171, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "ФИО:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(80, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Дата рождения:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(35, 265);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Паспортные данные:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(48, 297);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Дата подключения:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(148, 328);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Баланс:";
            // 
            // abonentName
            // 
            this.abonentName.Location = new System.Drawing.Point(235, 201);
            this.abonentName.Margin = new System.Windows.Forms.Padding(4);
            this.abonentName.Name = "abonentName";
            this.abonentName.Size = new System.Drawing.Size(285, 22);
            this.abonentName.TabIndex = 34;
            // 
            // abonentPassport
            // 
            this.abonentPassport.Location = new System.Drawing.Point(235, 263);
            this.abonentPassport.Margin = new System.Windows.Forms.Padding(4);
            this.abonentPassport.Name = "abonentPassport";
            this.abonentPassport.Size = new System.Drawing.Size(192, 22);
            this.abonentPassport.TabIndex = 36;
            // 
            // abonentBalance
            // 
            this.abonentBalance.Location = new System.Drawing.Point(235, 327);
            this.abonentBalance.Margin = new System.Windows.Forms.Padding(4);
            this.abonentBalance.Name = "abonentBalance";
            this.abonentBalance.Size = new System.Drawing.Size(192, 22);
            this.abonentBalance.TabIndex = 38;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(235, 446);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(223, 37);
            this.button2.TabIndex = 40;
            this.button2.Text = "Сохранить изменения";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(107, 399);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = "Подключен?";
            // 
            // isConnectedAbonent
            // 
            this.isConnectedAbonent.AutoSize = true;
            this.isConnectedAbonent.Location = new System.Drawing.Point(235, 402);
            this.isConnectedAbonent.Margin = new System.Windows.Forms.Padding(4);
            this.isConnectedAbonent.Name = "isConnectedAbonent";
            this.isConnectedAbonent.Size = new System.Drawing.Size(18, 17);
            this.isConnectedAbonent.TabIndex = 42;
            this.isConnectedAbonent.UseVisualStyleBackColor = true;
            // 
            // abonentBirthday
            // 
            this.abonentBirthday.Location = new System.Drawing.Point(235, 231);
            this.abonentBirthday.Margin = new System.Windows.Forms.Padding(4);
            this.abonentBirthday.Name = "abonentBirthday";
            this.abonentBirthday.Size = new System.Drawing.Size(192, 22);
            this.abonentBirthday.TabIndex = 43;
            // 
            // abonentDateOfConnection
            // 
            this.abonentDateOfConnection.Location = new System.Drawing.Point(235, 293);
            this.abonentDateOfConnection.Margin = new System.Windows.Forms.Padding(4);
            this.abonentDateOfConnection.Name = "abonentDateOfConnection";
            this.abonentDateOfConnection.Size = new System.Drawing.Size(192, 22);
            this.abonentDateOfConnection.TabIndex = 44;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LKStaff_main,
            this.menuStaff_Abonents,
            this.menuStaff_appeals,
            this.StaffTask});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(65, 24);
            this.toolStripMenuItem1.Text = "Меню";
            // 
            // LKStaff_main
            // 
            this.LKStaff_main.Name = "LKStaff_main";
            this.LKStaff_main.Size = new System.Drawing.Size(175, 26);
            this.LKStaff_main.Text = "Главная";
            this.LKStaff_main.Click += new System.EventHandler(this.LKStaff_main_Click);
            // 
            // menuStaff_Abonents
            // 
            this.menuStaff_Abonents.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStaff_connectAbonent,
            this.menuStaff_showInfoAbonent});
            this.menuStaff_Abonents.Name = "menuStaff_Abonents";
            this.menuStaff_Abonents.Size = new System.Drawing.Size(175, 26);
            this.menuStaff_Abonents.Text = "Абоненты";
            // 
            // menuStaff_connectAbonent
            // 
            this.menuStaff_connectAbonent.Name = "menuStaff_connectAbonent";
            this.menuStaff_connectAbonent.Size = new System.Drawing.Size(277, 26);
            this.menuStaff_connectAbonent.Text = "Подключить абонента";
            this.menuStaff_connectAbonent.Click += new System.EventHandler(this.menuStaff_connectAbonent_Click);
            // 
            // menuStaff_showInfoAbonent
            // 
            this.menuStaff_showInfoAbonent.Name = "menuStaff_showInfoAbonent";
            this.menuStaff_showInfoAbonent.Size = new System.Drawing.Size(277, 26);
            this.menuStaff_showInfoAbonent.Text = "Информация об абоненте";
            this.menuStaff_showInfoAbonent.Click += new System.EventHandler(this.menuStaff_showInfoAbonent_Click);
            // 
            // menuStaff_appeals
            // 
            this.menuStaff_appeals.Name = "menuStaff_appeals";
            this.menuStaff_appeals.Size = new System.Drawing.Size(175, 26);
            this.menuStaff_appeals.Text = "Обращения";
            this.menuStaff_appeals.Click += new System.EventHandler(this.menuStaff_appeals_Click);
            // 
            // StaffTask
            // 
            this.StaffTask.Name = "StaffTask";
            this.StaffTask.Size = new System.Drawing.Size(175, 26);
            this.StaffTask.Text = "Задачи";
            this.StaffTask.Click += new System.EventHandler(this.StaffTask_Click);
            // 
            // ShowInfoAboutAbonent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ShowInfoAboutAbonent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация об абоненте";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox abonentPhonenumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox abonentName;
        private System.Windows.Forms.TextBox abonentPassport;
        private System.Windows.Forms.TextBox abonentBalance;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox isConnectedAbonent;
        private System.Windows.Forms.DateTimePicker abonentBirthday;
        private System.Windows.Forms.DateTimePicker abonentDateOfConnection;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem LKStaff_main;
        private System.Windows.Forms.ToolStripMenuItem menuStaff_Abonents;
        private System.Windows.Forms.ToolStripMenuItem menuStaff_connectAbonent;
        private System.Windows.Forms.ToolStripMenuItem menuStaff_showInfoAbonent;
        private System.Windows.Forms.ToolStripMenuItem menuStaff_appeals;
        private System.Windows.Forms.ToolStripMenuItem StaffTask;
    }
}