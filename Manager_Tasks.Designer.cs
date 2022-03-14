
namespace PhoneStation
{
    partial class Manager_Tasks
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
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idtaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idstaffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptiontaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.taskBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.phoneStationDataSet4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneStationDataSet4 = new PhoneStation.PhoneStationDataSet4();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.taskTableAdapter = new PhoneStation.PhoneStationDataSet4TableAdapters.TaskTableAdapter();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new PhoneStation.PhoneStationDataSet4TableAdapters.StaffTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.taskBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneStationDataSet4BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneStationDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(481, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Задачи";
            // 
            // cn
            // 
            this.cn.ConnectionString = "Provider=SQLNCLI11;Data Source=localhost;Integrated Security=SSPI;Initial Catalog" +
    "=PhoneStation";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtaskDataGridViewTextBoxColumn,
            this.idstaffDataGridViewTextBoxColumn,
            this.nametaskDataGridViewTextBoxColumn,
            this.descriptiontaskDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.taskBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(30, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(995, 391);
            this.dataGridView1.TabIndex = 14;
            // 
            // idtaskDataGridViewTextBoxColumn
            // 
            this.idtaskDataGridViewTextBoxColumn.DataPropertyName = "id_task";
            this.idtaskDataGridViewTextBoxColumn.HeaderText = "№";
            this.idtaskDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idtaskDataGridViewTextBoxColumn.Name = "idtaskDataGridViewTextBoxColumn";
            this.idtaskDataGridViewTextBoxColumn.ReadOnly = true;
            this.idtaskDataGridViewTextBoxColumn.Width = 35;
            // 
            // idstaffDataGridViewTextBoxColumn
            // 
            this.idstaffDataGridViewTextBoxColumn.DataPropertyName = "id_staff";
            this.idstaffDataGridViewTextBoxColumn.HeaderText = "ID сотрудника";
            this.idstaffDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idstaffDataGridViewTextBoxColumn.Name = "idstaffDataGridViewTextBoxColumn";
            this.idstaffDataGridViewTextBoxColumn.Width = 90;
            // 
            // nametaskDataGridViewTextBoxColumn
            // 
            this.nametaskDataGridViewTextBoxColumn.DataPropertyName = "name_task";
            this.nametaskDataGridViewTextBoxColumn.HeaderText = "Тема";
            this.nametaskDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nametaskDataGridViewTextBoxColumn.Name = "nametaskDataGridViewTextBoxColumn";
            this.nametaskDataGridViewTextBoxColumn.Width = 260;
            // 
            // descriptiontaskDataGridViewTextBoxColumn
            // 
            this.descriptiontaskDataGridViewTextBoxColumn.DataPropertyName = "description_task";
            this.descriptiontaskDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.descriptiontaskDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptiontaskDataGridViewTextBoxColumn.Name = "descriptiontaskDataGridViewTextBoxColumn";
            this.descriptiontaskDataGridViewTextBoxColumn.Width = 500;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Статус";
            this.statusDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.Width = 60;
            // 
            // taskBindingSource2
            // 
            this.taskBindingSource2.DataMember = "Task";
            this.taskBindingSource2.DataSource = this.phoneStationDataSet4BindingSource;
            // 
            // phoneStationDataSet4BindingSource
            // 
            this.phoneStationDataSet4BindingSource.DataSource = this.phoneStationDataSet4;
            this.phoneStationDataSet4BindingSource.Position = 0;
            // 
            // phoneStationDataSet4
            // 
            this.phoneStationDataSet4.DataSetName = "PhoneStationDataSet4";
            this.phoneStationDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataMember = "Task";
            this.taskBindingSource.DataSource = this.phoneStationDataSet4BindingSource;
            // 
            // taskTableAdapter
            // 
            this.taskTableAdapter.ClearBeforeFill = true;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.phoneStationDataSet4BindingSource;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(394, 487);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 42);
            this.button1.TabIndex = 26;
            this.button1.Text = "Сохранить изменения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // taskBindingSource1
            // 
            this.taskBindingSource1.DataMember = "Task";
            this.taskBindingSource1.DataSource = this.phoneStationDataSet4BindingSource;
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
            this.menuStrip1.TabIndex = 34;
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
            // Manager_Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 554);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Name = "Manager_Tasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задачи";
            this.Load += new System.EventHandler(this.Manager_Tasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneStationDataSet4BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneStationDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource phoneStationDataSet4BindingSource;
        private PhoneStationDataSet4 phoneStationDataSet4;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private PhoneStationDataSet4TableAdapters.TaskTableAdapter taskTableAdapter;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private PhoneStationDataSet4TableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource taskBindingSource1;
        private System.Windows.Forms.BindingSource taskBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstaffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptiontaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
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