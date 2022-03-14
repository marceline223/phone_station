
namespace PhoneStation
{
    partial class Abonent_Services
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
            this.label1 = new System.Windows.Forms.Label();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.service_balance = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_main = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.blackListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(464, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "Услуги";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(431, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ваши подписки:";
            // 
            // cn
            // 
            this.cn.ConnectionString = "Provider=SQLNCLI11;Data Source=localhost;Integrated Security=SSPI;Initial Catalog" +
    "=PhoneStation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Подключение услуг:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(97, 434);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(173, 33);
            this.button1.TabIndex = 15;
            this.button1.Text = "Подключить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(56, 119);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(253, 293);
            this.checkedListBox1.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(800, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Баланс:";
            // 
            // service_balance
            // 
            this.service_balance.Location = new System.Drawing.Point(865, 324);
            this.service_balance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.service_balance.Name = "service_balance";
            this.service_balance.ReadOnly = true;
            this.service_balance.Size = new System.Drawing.Size(71, 22);
            this.service_balance.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(935, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "руб.";
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(435, 119);
            this.checkedListBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(268, 293);
            this.checkedListBox2.TabIndex = 21;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(468, 437);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(215, 30);
            this.button2.TabIndex = 22;
            this.button2.Text = "Отключить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(411, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(411, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "При отключении деньги не возвращаются.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(761, 119);
            this.label8.MaximumSize = new System.Drawing.Size(211, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(211, 85);
            this.label8.TabIndex = 24;
            this.label8.Text = "Для подключения/отключения выберите одну или несколько услуг из списка и нажмите " +
    "соответствующую кнопку";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_main,
            this.menu_balance,
            this.menu_services,
            this.menu_tariff,
            this.menu_messages,
            this.menu_appeals});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(65, 24);
            this.toolStripMenuItem1.Text = "Меню";
            // 
            // menu_main
            // 
            this.menu_main.Name = "menu_main";
            this.menu_main.Size = new System.Drawing.Size(250, 26);
            this.menu_main.Text = "Главная";
            this.menu_main.Click += new System.EventHandler(this.menu_main_Click);
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
            this.blackListToolStripMenuItem});
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
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // blackListToolStripMenuItem
            // 
            this.blackListToolStripMenuItem.Name = "blackListToolStripMenuItem";
            this.blackListToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.blackListToolStripMenuItem.Text = "Черный список";
            this.blackListToolStripMenuItem.Click += new System.EventHandler(this.blackListToolStripMenuItem_Click);
            // 
            // Abonent_Services
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.service_balance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Abonent_Services";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление услугами";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox service_balance;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menu_main;
        private System.Windows.Forms.ToolStripMenuItem menu_balance;
        private System.Windows.Forms.ToolStripMenuItem menu_services;
        private System.Windows.Forms.ToolStripMenuItem menu_tariff;
        private System.Windows.Forms.ToolStripMenuItem menu_messages;
        private System.Windows.Forms.ToolStripMenuItem menu_messages_newMessage;
        private System.Windows.Forms.ToolStripMenuItem menu_messages_incoming;
        private System.Windows.Forms.ToolStripMenuItem menu_messages_outgoing;
        private System.Windows.Forms.ToolStripMenuItem blackListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_appeals;
        private System.Windows.Forms.ToolStripMenuItem menu_appeals_newAppeal;
        private System.Windows.Forms.ToolStripMenuItem menu_appeals_showMyAppeals;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}