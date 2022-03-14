
namespace PhoneStation
{
    partial class OutgoingMessages
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
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
            this.listOutgoing = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.черныйСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOutgoing)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(365, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список исходящих сообщений:";
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
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
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
            // 
            // menu_balance
            // 
            this.menu_balance.Name = "menu_balance";
            this.menu_balance.Size = new System.Drawing.Size(250, 26);
            this.menu_balance.Text = "Управление балансом";
            // 
            // menu_services
            // 
            this.menu_services.Name = "menu_services";
            this.menu_services.Size = new System.Drawing.Size(250, 26);
            this.menu_services.Text = "Услуги";
            // 
            // menu_tariff
            // 
            this.menu_tariff.Name = "menu_tariff";
            this.menu_tariff.Size = new System.Drawing.Size(250, 26);
            this.menu_tariff.Text = "Тарифы";
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
            // listOutgoing
            // 
            this.listOutgoing.AllowUserToAddRows = false;
            this.listOutgoing.AllowUserToDeleteRows = false;
            this.listOutgoing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listOutgoing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.listOutgoing.Location = new System.Drawing.Point(27, 82);
            this.listOutgoing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listOutgoing.Name = "listOutgoing";
            this.listOutgoing.ReadOnly = true;
            this.listOutgoing.RowHeadersWidth = 51;
            this.listOutgoing.RowTemplate.Height = 24;
            this.listOutgoing.Size = new System.Drawing.Size(1013, 460);
            this.listOutgoing.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номер телефона";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Имя";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 250;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Текст сообщения";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 500;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Дата отправки";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // черныйСписокToolStripMenuItem
            // 
            this.черныйСписокToolStripMenuItem.Name = "черныйСписокToolStripMenuItem";
            this.черныйСписокToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.черныйСписокToolStripMenuItem.Text = "Черный список";
            this.черныйСписокToolStripMenuItem.Click += new System.EventHandler(this.черныйСписокToolStripMenuItem_Click);
            // 
            // OutgoingMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.listOutgoing);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OutgoingMessages";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OutgoingMessages";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listOutgoing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menu_main;
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
        private System.Windows.Forms.DataGridView listOutgoing;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ToolStripMenuItem черныйСписокToolStripMenuItem;
    }
}