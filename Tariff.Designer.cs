
namespace PhoneStation
{
    partial class Tariff
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
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.tariffBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.label1 = new System.Windows.Forms.Label();
            this.currentTariff = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.balance = new System.Windows.Forms.TextBox();
            this.chooseTariff = new System.Windows.Forms.ComboBox();
            this.phoneStationDataSetTariff = new PhoneStation.PhoneStationDataSetTariff();
            this.tariffBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tariffTableAdapter = new PhoneStation.PhoneStationDataSetTariffTableAdapters.TariffTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idtariffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.черныйСписокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneStationDataSetTariff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(483, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Тарифы";
            // 
            // tariffBindingSource
            // 
            this.tariffBindingSource.DataMember = "Tariff";
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
            this.menuStrip1.TabIndex = 18;
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
            this.label1.Location = new System.Drawing.Point(637, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ваш текущий тарифный план - ";
            // 
            // currentTariff
            // 
            this.currentTariff.Location = new System.Drawing.Point(851, 94);
            this.currentTariff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currentTariff.Name = "currentTariff";
            this.currentTariff.ReadOnly = true;
            this.currentTariff.Size = new System.Drawing.Size(177, 22);
            this.currentTariff.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(319, 34);
            this.label2.TabIndex = 21;
            this.label2.Text = "Вы можете перейти на другой тарифный план.\r\nЧтобы перейти, выберите из списка:\r\n";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(968, 178);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Перейти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(841, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Баланс:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(965, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "руб.";
            // 
            // balance
            // 
            this.balance.Location = new System.Drawing.Point(907, 377);
            this.balance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.balance.Name = "balance";
            this.balance.ReadOnly = true;
            this.balance.Size = new System.Drawing.Size(53, 22);
            this.balance.TabIndex = 25;
            // 
            // chooseTariff
            // 
            this.chooseTariff.FormattingEnabled = true;
            this.chooseTariff.Location = new System.Drawing.Point(640, 177);
            this.chooseTariff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chooseTariff.Name = "chooseTariff";
            this.chooseTariff.Size = new System.Drawing.Size(309, 24);
            this.chooseTariff.TabIndex = 27;
            // 
            // phoneStationDataSetTariff
            // 
            this.phoneStationDataSetTariff.DataSetName = "PhoneStationDataSetTariff";
            this.phoneStationDataSetTariff.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tariffBindingSource1
            // 
            this.tariffBindingSource1.DataMember = "Tariff";
            this.tariffBindingSource1.DataSource = this.phoneStationDataSetTariff;
            // 
            // tariffTableAdapter
            // 
            this.tariffTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtariffDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView2.DataSource = this.tariffBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(16, 97);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(600, 399);
            this.dataGridView2.TabIndex = 28;
            // 
            // idtariffDataGridViewTextBoxColumn
            // 
            this.idtariffDataGridViewTextBoxColumn.DataPropertyName = "id_tariff";
            this.idtariffDataGridViewTextBoxColumn.HeaderText = "id_tariff";
            this.idtariffDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idtariffDataGridViewTextBoxColumn.Name = "idtariffDataGridViewTextBoxColumn";
            this.idtariffDataGridViewTextBoxColumn.ReadOnly = true;
            this.idtariffDataGridViewTextBoxColumn.Visible = false;
            this.idtariffDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "tariff_name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Название тарифа";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "tariff_description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "tariff_cost";
            this.dataGridViewTextBoxColumn3.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // черныйСписокToolStripMenuItem
            // 
            this.черныйСписокToolStripMenuItem.Name = "черныйСписокToolStripMenuItem";
            this.черныйСписокToolStripMenuItem.Size = new System.Drawing.Size(289, 26);
            this.черныйСписокToolStripMenuItem.Text = "Черный список";
            this.черныйСписокToolStripMenuItem.Click += new System.EventHandler(this.черныйСписокToolStripMenuItem_Click);
            // 
            // Tariff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.chooseTariff);
            this.Controls.Add(this.balance);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentTariff);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Tariff";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тарифы";
            this.Load += new System.EventHandler(this.Tariff_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneStationDataSetTariff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
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
        private System.Windows.Forms.BindingSource tariffBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox currentTariff;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox balance;
        private System.Windows.Forms.ComboBox chooseTariff;
        private System.Windows.Forms.DataGridViewTextBoxColumn tariffnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tariffdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tariffcostDataGridViewTextBoxColumn;
        private PhoneStationDataSetTariff phoneStationDataSetTariff;
        private System.Windows.Forms.BindingSource tariffBindingSource1;
        private PhoneStationDataSetTariffTableAdapters.TariffTableAdapter tariffTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtariffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStripMenuItem черныйСписокToolStripMenuItem;
    }
}