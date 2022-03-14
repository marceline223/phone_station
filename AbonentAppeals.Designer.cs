
namespace PhoneStation
{
    partial class AbonentAppeals
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.listAppeals = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.blackListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listAppeals)).BeginInit();
            this.SuspendLayout();
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
            // listAppeals
            // 
            this.listAppeals.AllowUserToAddRows = false;
            this.listAppeals.AllowUserToDeleteRows = false;
            this.listAppeals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listAppeals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.listAppeals.Location = new System.Drawing.Point(27, 73);
            this.listAppeals.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listAppeals.Name = "listAppeals";
            this.listAppeals.ReadOnly = true;
            this.listAppeals.RowHeadersWidth = 51;
            this.listAppeals.RowTemplate.Height = 24;
            this.listAppeals.Size = new System.Drawing.Size(1013, 457);
            this.listAppeals.TabIndex = 22;
            // 
            // Column2
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column2.HeaderText = "Дата создания";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column3.HeaderText = "Текст обращения";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 500;
            // 
            // Column4
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column4.HeaderText = "Статус обращения";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column5.HeaderText = "Ответ";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(432, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Мои обращения";
            // 
            // blackListToolStripMenuItem
            // 
            this.blackListToolStripMenuItem.Name = "blackListToolStripMenuItem";
            this.blackListToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.blackListToolStripMenuItem.Text = "Черный список";
            this.blackListToolStripMenuItem.Click += new System.EventHandler(this.blackListToolStripMenuItem_Click);
            // 
            // AbonentAppeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.listAppeals);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AbonentAppeals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AbonentAppeals";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listAppeals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridView listAppeals;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ToolStripMenuItem blackListToolStripMenuItem;
    }
}