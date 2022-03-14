
namespace PhoneStation
{
    partial class Tariff_Manager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idtariffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tariffnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tariffdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tariffcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tariffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneStationDataSet6 = new PhoneStation.PhoneStationDataSet6();
            this.tariffTableAdapter = new PhoneStation.PhoneStationDataSet6TableAdapters.TariffTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneStationDataSet6)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(479, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 29);
            this.label1.TabIndex = 47;
            this.label1.Text = "Тарифы";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtariffDataGridViewTextBoxColumn,
            this.tariffnameDataGridViewTextBoxColumn,
            this.tariffdescriptionDataGridViewTextBoxColumn,
            this.tariffcostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tariffBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(31, 89);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(731, 408);
            this.dataGridView1.TabIndex = 48;
            // 
            // idtariffDataGridViewTextBoxColumn
            // 
            this.idtariffDataGridViewTextBoxColumn.DataPropertyName = "id_tariff";
            this.idtariffDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idtariffDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idtariffDataGridViewTextBoxColumn.Name = "idtariffDataGridViewTextBoxColumn";
            this.idtariffDataGridViewTextBoxColumn.ReadOnly = true;
            this.idtariffDataGridViewTextBoxColumn.Width = 50;
            // 
            // tariffnameDataGridViewTextBoxColumn
            // 
            this.tariffnameDataGridViewTextBoxColumn.DataPropertyName = "tariff_name";
            this.tariffnameDataGridViewTextBoxColumn.HeaderText = "Название";
            this.tariffnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tariffnameDataGridViewTextBoxColumn.Name = "tariffnameDataGridViewTextBoxColumn";
            this.tariffnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // tariffdescriptionDataGridViewTextBoxColumn
            // 
            this.tariffdescriptionDataGridViewTextBoxColumn.DataPropertyName = "tariff_description";
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tariffdescriptionDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle9;
            this.tariffdescriptionDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.tariffdescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tariffdescriptionDataGridViewTextBoxColumn.Name = "tariffdescriptionDataGridViewTextBoxColumn";
            this.tariffdescriptionDataGridViewTextBoxColumn.Width = 350;
            // 
            // tariffcostDataGridViewTextBoxColumn
            // 
            this.tariffcostDataGridViewTextBoxColumn.DataPropertyName = "tariff_cost";
            this.tariffcostDataGridViewTextBoxColumn.HeaderText = "Стоимость";
            this.tariffcostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tariffcostDataGridViewTextBoxColumn.Name = "tariffcostDataGridViewTextBoxColumn";
            this.tariffcostDataGridViewTextBoxColumn.Width = 125;
            // 
            // tariffBindingSource
            // 
            this.tariffBindingSource.DataMember = "Tariff";
            this.tariffBindingSource.DataSource = this.phoneStationDataSet6;
            // 
            // phoneStationDataSet6
            // 
            this.phoneStationDataSet6.DataSetName = "PhoneStationDataSet6";
            this.phoneStationDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tariffTableAdapter
            // 
            this.tariffTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(804, 249);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(217, 52);
            this.button1.TabIndex = 49;
            this.button1.Text = "Сохранить изменения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1047, 28);
            this.menuStrip1.TabIndex = 50;
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
            // Tariff_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 554);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Tariff_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тарифы";
            this.Load += new System.EventHandler(this.Tariff_Manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tariffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneStationDataSet6)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PhoneStationDataSet6 phoneStationDataSet6;
        private System.Windows.Forms.BindingSource tariffBindingSource;
        private PhoneStationDataSet6TableAdapters.TariffTableAdapter tariffTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtariffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tariffnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tariffdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tariffcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
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