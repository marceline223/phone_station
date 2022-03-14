
namespace PhoneStation
{
    partial class ConnectAbonent
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
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fio = new System.Windows.Forms.TextBox();
            this.passport = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.birthday = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LKStaff_main = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStaff_Abonents = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStaff_connectAbonent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStaff_showInfoAbonent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStaff_appeals = new System.Windows.Forms.ToolStripMenuItem();
            this.StaffTasks = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cn
            // 
            this.cn.ConnectionString = "Provider=SQLNCLI11;Data Source=localhost;Integrated Security=SSPI;Initial Catalog" +
    "=PhoneStation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(396, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(292, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Подключить абонента";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(153, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(84, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Дата рождения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(51, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Паспортные данные";
            // 
            // fio
            // 
            this.fio.Location = new System.Drawing.Point(220, 138);
            this.fio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fio.Name = "fio";
            this.fio.Size = new System.Drawing.Size(365, 22);
            this.fio.TabIndex = 21;
            // 
            // passport
            // 
            this.passport.Location = new System.Drawing.Point(220, 242);
            this.passport.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passport.Name = "passport";
            this.passport.Size = new System.Drawing.Size(239, 22);
            this.passport.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(216, 347);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(633, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Пожалуйста, проверьте корректность данных перед подключением.";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(416, 412);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 71);
            this.button1.TabIndex = 25;
            this.button1.Text = "Подключить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // birthday
            // 
            this.birthday.Location = new System.Drawing.Point(220, 191);
            this.birthday.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.birthday.Name = "birthday";
            this.birthday.Size = new System.Drawing.Size(168, 22);
            this.birthday.TabIndex = 26;
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
            this.menuStrip1.TabIndex = 27;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LKStaff_main,
            this.menuStaff_Abonents,
            this.menuStaff_appeals,
            this.StaffTasks});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(65, 24);
            this.toolStripMenuItem1.Text = "Меню";
            // 
            // LKStaff_main
            // 
            this.LKStaff_main.Name = "LKStaff_main";
            this.LKStaff_main.Size = new System.Drawing.Size(224, 26);
            this.LKStaff_main.Text = "Главная";
            this.LKStaff_main.Click += new System.EventHandler(this.LKStaff_main_Click);
            // 
            // menuStaff_Abonents
            // 
            this.menuStaff_Abonents.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStaff_connectAbonent,
            this.menuStaff_showInfoAbonent});
            this.menuStaff_Abonents.Name = "menuStaff_Abonents";
            this.menuStaff_Abonents.Size = new System.Drawing.Size(224, 26);
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
            this.menuStaff_appeals.Size = new System.Drawing.Size(224, 26);
            this.menuStaff_appeals.Text = "Обращения";
            this.menuStaff_appeals.Click += new System.EventHandler(this.menuStaff_appeals_Click_1);
            // 
            // StaffTasks
            // 
            this.StaffTasks.Name = "StaffTasks";
            this.StaffTasks.Size = new System.Drawing.Size(224, 26);
            this.StaffTasks.Text = "Задачи";
            this.StaffTasks.Click += new System.EventHandler(this.StaffTasks_Click);
            // 
            // ConnectAbonent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.birthday);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passport);
            this.Controls.Add(this.fio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ConnectAbonent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подключить абонента";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fio;
        private System.Windows.Forms.TextBox passport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker birthday;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem LKStaff_main;
        private System.Windows.Forms.ToolStripMenuItem menuStaff_Abonents;
        private System.Windows.Forms.ToolStripMenuItem menuStaff_connectAbonent;
        private System.Windows.Forms.ToolStripMenuItem menuStaff_showInfoAbonent;
        private System.Windows.Forms.ToolStripMenuItem menuStaff_appeals;
        private System.Windows.Forms.ToolStripMenuItem StaffTasks;
    }
}