
namespace PhoneStation
{
    partial class LKStaff
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
            this.LK_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.staffName = new System.Windows.Forms.TextBox();
            this.staffPassport = new System.Windows.Forms.TextBox();
            this.staffDateOfStartWorking = new System.Windows.Forms.TextBox();
            this.staffBirthday = new System.Windows.Forms.TextBox();
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
            this.label5.Location = new System.Drawing.Point(266, 33);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Личный кабинет сотрудника";
            // 
            // LK_exit
            // 
            this.LK_exit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LK_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LK_exit.ForeColor = System.Drawing.Color.Maroon;
            this.LK_exit.Location = new System.Drawing.Point(317, 359);
            this.LK_exit.Margin = new System.Windows.Forms.Padding(2);
            this.LK_exit.Name = "LK_exit";
            this.LK_exit.Size = new System.Drawing.Size(164, 58);
            this.LK_exit.TabIndex = 16;
            this.LK_exit.Text = "Выход";
            this.LK_exit.UseVisualStyleBackColor = false;
            this.LK_exit.Click += new System.EventHandler(this.LK_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(136, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "ФИО";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(84, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Дата рождения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(59, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Паспортные данные";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(59, 269);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Дата начала работы";
            // 
            // staffName
            // 
            this.staffName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffName.Location = new System.Drawing.Point(190, 117);
            this.staffName.Name = "staffName";
            this.staffName.ReadOnly = true;
            this.staffName.Size = new System.Drawing.Size(225, 13);
            this.staffName.TabIndex = 21;
            // 
            // staffPassport
            // 
            this.staffPassport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffPassport.Location = new System.Drawing.Point(190, 215);
            this.staffPassport.Name = "staffPassport";
            this.staffPassport.ReadOnly = true;
            this.staffPassport.Size = new System.Drawing.Size(165, 13);
            this.staffPassport.TabIndex = 23;
            // 
            // staffDateOfStartWorking
            // 
            this.staffDateOfStartWorking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffDateOfStartWorking.Location = new System.Drawing.Point(190, 266);
            this.staffDateOfStartWorking.Name = "staffDateOfStartWorking";
            this.staffDateOfStartWorking.ReadOnly = true;
            this.staffDateOfStartWorking.Size = new System.Drawing.Size(165, 13);
            this.staffDateOfStartWorking.TabIndex = 24;
            // 
            // staffBirthday
            // 
            this.staffBirthday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.staffBirthday.Location = new System.Drawing.Point(190, 165);
            this.staffBirthday.Name = "staffBirthday";
            this.staffBirthday.ReadOnly = true;
            this.staffBirthday.Size = new System.Drawing.Size(165, 13);
            this.staffBirthday.TabIndex = 22;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 27;
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
            this.toolStripMenuItem1.Size = new System.Drawing.Size(53, 20);
            this.toolStripMenuItem1.Text = "Меню";
            // 
            // LKStaff_main
            // 
            this.LKStaff_main.Name = "LKStaff_main";
            this.LKStaff_main.Size = new System.Drawing.Size(180, 22);
            this.LKStaff_main.Text = "Главная";
            this.LKStaff_main.Click += new System.EventHandler(this.LKStaff_main_Click);
            // 
            // menuStaff_Abonents
            // 
            this.menuStaff_Abonents.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStaff_connectAbonent,
            this.menuStaff_showInfoAbonent});
            this.menuStaff_Abonents.Name = "menuStaff_Abonents";
            this.menuStaff_Abonents.Size = new System.Drawing.Size(180, 22);
            this.menuStaff_Abonents.Text = "Абоненты";
            // 
            // menuStaff_connectAbonent
            // 
            this.menuStaff_connectAbonent.Name = "menuStaff_connectAbonent";
            this.menuStaff_connectAbonent.Size = new System.Drawing.Size(219, 22);
            this.menuStaff_connectAbonent.Text = "Подключить абонента";
            this.menuStaff_connectAbonent.Click += new System.EventHandler(this.menuStaff_connectAbonent_Click);
            // 
            // menuStaff_showInfoAbonent
            // 
            this.menuStaff_showInfoAbonent.Name = "menuStaff_showInfoAbonent";
            this.menuStaff_showInfoAbonent.Size = new System.Drawing.Size(219, 22);
            this.menuStaff_showInfoAbonent.Text = "Информация об абоненте";
            this.menuStaff_showInfoAbonent.Click += new System.EventHandler(this.menuStaff_showInfoAbonent_Click);
            // 
            // menuStaff_appeals
            // 
            this.menuStaff_appeals.Name = "menuStaff_appeals";
            this.menuStaff_appeals.Size = new System.Drawing.Size(180, 22);
            this.menuStaff_appeals.Text = "Обращения";
            this.menuStaff_appeals.Click += new System.EventHandler(this.menuStaff_appeals_Click);
            // 
            // StaffTask
            // 
            this.StaffTask.Name = "StaffTask";
            this.StaffTask.Size = new System.Drawing.Size(180, 22);
            this.StaffTask.Text = "Задачи";
            this.StaffTask.Click += new System.EventHandler(this.StaffTask_Click);
            // 
            // LKStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.staffDateOfStartWorking);
            this.Controls.Add(this.staffPassport);
            this.Controls.Add(this.staffBirthday);
            this.Controls.Add(this.staffName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LK_exit);
            this.Controls.Add(this.label5);
            this.Name = "LKStaff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LKStaff";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button LK_exit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox staffName;
        private System.Windows.Forms.TextBox staffPassport;
        private System.Windows.Forms.TextBox staffDateOfStartWorking;
        private System.Windows.Forms.TextBox staffBirthday;
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