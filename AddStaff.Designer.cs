
namespace PhoneStation
{
    partial class AddStaff
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
            this.label5 = new System.Windows.Forms.Label();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.label2 = new System.Windows.Forms.Label();
            this.fio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.dateOfStartWorking = new System.Windows.Forms.DateTimePicker();
            this.passport = new System.Windows.Forms.TextBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(377, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(363, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Принять нового сотрудника";
            // 
            // cn
            // 
            this.cn.ConnectionString = "Provider=SQLNCLI11;Data Source=localhost;Integrated Security=SSPI;Initial Catalog" +
    "=PhoneStation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(168, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 16;
            this.label2.Text = "ФИО:";
            // 
            // fio
            // 
            this.fio.Location = new System.Drawing.Point(228, 152);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(324, 22);
            this.fio.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(76, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Дата рождения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(32, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Дата начала работы:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(35, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Паспортные данные:";
            // 
            // birthday
            // 
            this.birthday.Location = new System.Drawing.Point(228, 198);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(200, 22);
            this.birthday.TabIndex = 27;
            // 
            // dateOfStartWorking
            // 
            this.dateOfStartWorking.Location = new System.Drawing.Point(228, 249);
            this.dateOfStartWorking.Name = "dateOfStartWorking";
            this.dateOfStartWorking.Size = new System.Drawing.Size(200, 22);
            this.dateOfStartWorking.TabIndex = 28;
            // 
            // passport
            // 
            this.passport.Location = new System.Drawing.Point(228, 294);
            this.passport.Name = "passport";
            this.passport.Size = new System.Drawing.Size(289, 22);
            this.passport.TabIndex = 29;
            // 
            // button_Save
            // 
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Save.Location = new System.Drawing.Point(464, 448);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(196, 42);
            this.button_Save.TabIndex = 30;
            this.button_Save.Text = "Принять";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(187, 376);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(724, 24);
            this.label7.TabIndex = 31;
            this.label7.Text = "Пожалуйста, проверьте корректность данных перед сохранением изменений.";
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
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 32;
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
            // AddStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.passport);
            this.Controls.Add(this.dateOfStartWorking);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Name = "AddStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Принять на работу";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker birthday;
        private System.Windows.Forms.DateTimePicker dateOfStartWorking;
        private System.Windows.Forms.TextBox passport;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Label label7;
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