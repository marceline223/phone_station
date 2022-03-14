
namespace PhoneStation
{
    partial class LKManager
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
            this.LK_exit = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(352, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(369, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Личный кабинет менеджера";
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
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 11;
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
            // LK_exit
            // 
            this.LK_exit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LK_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LK_exit.ForeColor = System.Drawing.Color.Maroon;
            this.LK_exit.Location = new System.Drawing.Point(424, 428);
            this.LK_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LK_exit.Name = "LK_exit";
            this.LK_exit.Size = new System.Drawing.Size(219, 71);
            this.LK_exit.TabIndex = 16;
            this.LK_exit.Text = "Выход";
            this.LK_exit.UseVisualStyleBackColor = false;
            this.LK_exit.Click += new System.EventHandler(this.LK_exit_Click);
            // 
            // LKManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.LK_exit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LKManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ЛК менеджера";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem infoStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem абонентыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoAbonentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tariffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allStaffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allAbonentsToolStripMenuItem;
        private System.Windows.Forms.Button LK_exit;
    }
}