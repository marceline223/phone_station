
namespace PhoneStation
{
    partial class LKAbonent
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LK_main = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_balance = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_services = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_tariff = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_messages = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_messages_newMessage = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_messages_incoming = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_messages_outgoing = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_appeals = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_appeals_newAppeal = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_appeals_showMyAppeals = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LK_FIO = new System.Windows.Forms.TextBox();
            this.LK_birthday = new System.Windows.Forms.TextBox();
            this.LK_passport = new System.Windows.Forms.TextBox();
            this.LK_phonenumber = new System.Windows.Forms.TextBox();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LK_dateOfConnection = new System.Windows.Forms.TextBox();
            this.LK_balance = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LK_exit = new System.Windows.Forms.Button();
            this.черныйСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LK_main,
            this.menu_balance,
            this.menu_services,
            this.menu_tariff,
            this.menu_messages,
            this.menu_appeals});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(65, 24);
            this.toolStripMenuItem1.Text = "Меню";
            // 
            // LK_main
            // 
            this.LK_main.Name = "LK_main";
            this.LK_main.Size = new System.Drawing.Size(250, 26);
            this.LK_main.Text = "Главная";
            this.LK_main.Click += new System.EventHandler(this.LK_main_Click);
            // 
            // menu_balance
            // 
            this.menu_balance.Name = "menu_balance";
            this.menu_balance.Size = new System.Drawing.Size(250, 26);
            this.menu_balance.Text = "Управление балансом";
            this.menu_balance.Click += new System.EventHandler(this.menu_balance_Click);
            // 
            // menu_services
            // 
            this.menu_services.Name = "menu_services";
            this.menu_services.Size = new System.Drawing.Size(250, 26);
            this.menu_services.Text = "Услуги";
            this.menu_services.Click += new System.EventHandler(this.menu_services_Click);
            // 
            // menu_tariff
            // 
            this.menu_tariff.Name = "menu_tariff";
            this.menu_tariff.Size = new System.Drawing.Size(250, 26);
            this.menu_tariff.Text = "Тарифы";
            this.menu_tariff.Click += new System.EventHandler(this.menu_tariff_Click);
            // 
            // menu_messages
            // 
            this.menu_messages.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_messages_newMessage,
            this.menu_messages_incoming,
            this.menu_messages_outgoing,
            this.черныйСписокToolStripMenuItem});
            this.menu_messages.Name = "menu_messages";
            this.menu_messages.Size = new System.Drawing.Size(250, 26);
            this.menu_messages.Text = "Сообщения";
            // 
            // menu_messages_newMessage
            // 
            this.menu_messages_newMessage.Name = "menu_messages_newMessage";
            this.menu_messages_newMessage.Size = new System.Drawing.Size(289, 26);
            this.menu_messages_newMessage.Text = "Написать новое сообщение";
            this.menu_messages_newMessage.Click += new System.EventHandler(this.menu_messages_newMessage_Click);
            // 
            // menu_messages_incoming
            // 
            this.menu_messages_incoming.Name = "menu_messages_incoming";
            this.menu_messages_incoming.Size = new System.Drawing.Size(289, 26);
            this.menu_messages_incoming.Text = "Входящие";
            this.menu_messages_incoming.Click += new System.EventHandler(this.menu_messages_incoming_Click);
            // 
            // menu_messages_outgoing
            // 
            this.menu_messages_outgoing.Name = "menu_messages_outgoing";
            this.menu_messages_outgoing.Size = new System.Drawing.Size(289, 26);
            this.menu_messages_outgoing.Text = "Исходящие";
            this.menu_messages_outgoing.Click += new System.EventHandler(this.menu_messages_outgoing_Click);
            // 
            // menu_appeals
            // 
            this.menu_appeals.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_appeals_newAppeal,
            this.menu_appeals_showMyAppeals});
            this.menu_appeals.Name = "menu_appeals";
            this.menu_appeals.Size = new System.Drawing.Size(250, 26);
            this.menu_appeals.Text = "Обращения";
            // 
            // menu_appeals_newAppeal
            // 
            this.menu_appeals_newAppeal.Name = "menu_appeals_newAppeal";
            this.menu_appeals_newAppeal.Size = new System.Drawing.Size(294, 26);
            this.menu_appeals_newAppeal.Text = "Создать обращение";
            this.menu_appeals_newAppeal.Click += new System.EventHandler(this.menu_appeals_newAppeal_Click);
            // 
            // menu_appeals_showMyAppeals
            // 
            this.menu_appeals_showMyAppeals.Name = "menu_appeals_showMyAppeals";
            this.menu_appeals_showMyAppeals.Size = new System.Drawing.Size(294, 26);
            this.menu_appeals_showMyAppeals.Text = "Посмотреть мои обращения";
            this.menu_appeals_showMyAppeals.Click += new System.EventHandler(this.menu_appeals_showMyAppeals_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(165, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(64, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Паспортные данные";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(97, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Дата рождения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(87, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Номер телефона";
            // 
            // LK_FIO
            // 
            this.LK_FIO.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LK_FIO.Location = new System.Drawing.Point(235, 108);
            this.LK_FIO.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LK_FIO.Name = "LK_FIO";
            this.LK_FIO.ReadOnly = true;
            this.LK_FIO.Size = new System.Drawing.Size(307, 15);
            this.LK_FIO.TabIndex = 5;
            // 
            // LK_birthday
            // 
            this.LK_birthday.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LK_birthday.Location = new System.Drawing.Point(235, 145);
            this.LK_birthday.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LK_birthday.Name = "LK_birthday";
            this.LK_birthday.ReadOnly = true;
            this.LK_birthday.Size = new System.Drawing.Size(209, 15);
            this.LK_birthday.TabIndex = 6;
            // 
            // LK_passport
            // 
            this.LK_passport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LK_passport.Location = new System.Drawing.Point(235, 187);
            this.LK_passport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LK_passport.Name = "LK_passport";
            this.LK_passport.ReadOnly = true;
            this.LK_passport.Size = new System.Drawing.Size(209, 15);
            this.LK_passport.TabIndex = 7;
            // 
            // LK_phonenumber
            // 
            this.LK_phonenumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LK_phonenumber.Location = new System.Drawing.Point(235, 231);
            this.LK_phonenumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LK_phonenumber.Name = "LK_phonenumber";
            this.LK_phonenumber.ReadOnly = true;
            this.LK_phonenumber.Size = new System.Drawing.Size(209, 15);
            this.LK_phonenumber.TabIndex = 8;
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
            this.label5.Location = new System.Drawing.Point(361, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(344, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Личный кабинет абонента";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(73, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Дата подключения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(152, 310);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Баланс";
            // 
            // LK_dateOfConnection
            // 
            this.LK_dateOfConnection.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LK_dateOfConnection.Location = new System.Drawing.Point(235, 272);
            this.LK_dateOfConnection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LK_dateOfConnection.Name = "LK_dateOfConnection";
            this.LK_dateOfConnection.ReadOnly = true;
            this.LK_dateOfConnection.Size = new System.Drawing.Size(209, 15);
            this.LK_dateOfConnection.TabIndex = 12;
            // 
            // LK_balance
            // 
            this.LK_balance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LK_balance.Location = new System.Drawing.Point(235, 313);
            this.LK_balance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LK_balance.Name = "LK_balance";
            this.LK_balance.ReadOnly = true;
            this.LK_balance.Size = new System.Drawing.Size(59, 15);
            this.LK_balance.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(299, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "руб.";
            // 
            // LK_exit
            // 
            this.LK_exit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.LK_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LK_exit.ForeColor = System.Drawing.Color.Maroon;
            this.LK_exit.Location = new System.Drawing.Point(416, 426);
            this.LK_exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LK_exit.Name = "LK_exit";
            this.LK_exit.Size = new System.Drawing.Size(219, 71);
            this.LK_exit.TabIndex = 15;
            this.LK_exit.Text = "Выход";
            this.LK_exit.UseVisualStyleBackColor = false;
            this.LK_exit.Click += new System.EventHandler(this.LK_exit_Click);
            // 
            // черныйСписокToolStripMenuItem
            // 
            this.черныйСписокToolStripMenuItem.Name = "черныйСписокToolStripMenuItem";
            this.черныйСписокToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.черныйСписокToolStripMenuItem.Text = "Черный список";
            this.черныйСписокToolStripMenuItem.Click += new System.EventHandler(this.черныйСписокToolStripMenuItem_Click);
            // 
            // LKAbonent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.LK_exit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LK_balance);
            this.Controls.Add(this.LK_dateOfConnection);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LK_phonenumber);
            this.Controls.Add(this.LK_passport);
            this.Controls.Add(this.LK_birthday);
            this.Controls.Add(this.LK_FIO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LKAbonent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Личный кабинет";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem menu_balance;
        private System.Windows.Forms.ToolStripMenuItem menu_services;
        private System.Windows.Forms.ToolStripMenuItem menu_tariff;
        private System.Windows.Forms.ToolStripMenuItem menu_messages;
        private System.Windows.Forms.ToolStripMenuItem menu_messages_newMessage;
        private System.Windows.Forms.ToolStripMenuItem menu_messages_incoming;
        private System.Windows.Forms.ToolStripMenuItem menu_messages_outgoing;
        private System.Windows.Forms.ToolStripMenuItem menu_appeals;
        private System.Windows.Forms.ToolStripMenuItem menu_appeals_newAppeal;
        private System.Windows.Forms.ToolStripMenuItem menu_appeals_showMyAppeals;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LK_FIO;
        private System.Windows.Forms.TextBox LK_birthday;
        private System.Windows.Forms.TextBox LK_passport;
        private System.Windows.Forms.TextBox LK_phonenumber;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox LK_dateOfConnection;
        private System.Windows.Forms.TextBox LK_balance;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem LK_main;
        private System.Windows.Forms.Button LK_exit;
        private System.Windows.Forms.ToolStripMenuItem черныйСписокToolStripMenuItem;
    }
}