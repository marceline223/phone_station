
namespace PhoneStation
{
    partial class Staff_Appeals
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LKStaff_main = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStaff_Abonents = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStaff_connectAbonent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStaff_showInfoAbonent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStaff_appeals = new System.Windows.Forms.ToolStripMenuItem();
            this.StaffTasks = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idappealDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idabonentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appealtextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appealanswerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appealdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appealBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneStationDataSet = new PhoneStation.PhoneStationDataSet();
            this.appealTableAdapter = new PhoneStation.PhoneStationDataSetTableAdapters.AppealTableAdapter();
            this.phoneStationDataSet1 = new PhoneStation.PhoneStationDataSet1();
            this.phoneStationDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idstatusDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneStationDataSet2 = new PhoneStation.PhoneStationDataSet2();
            this.statusTableAdapter = new PhoneStation.PhoneStationDataSet2TableAdapters.StatusTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appealBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneStationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneStationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneStationDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneStationDataSet2)).BeginInit();
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
            this.menuStrip1.TabIndex = 13;
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
            this.LKStaff_main.Size = new System.Drawing.Size(175, 26);
            this.LKStaff_main.Text = "Главная";
            this.LKStaff_main.Click += new System.EventHandler(this.LKStaff_main_Click);
            // 
            // menuStaff_Abonents
            // 
            this.menuStaff_Abonents.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStaff_connectAbonent,
            this.menuStaff_showInfoAbonent});
            this.menuStaff_Abonents.Name = "menuStaff_Abonents";
            this.menuStaff_Abonents.Size = new System.Drawing.Size(175, 26);
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
            this.menuStaff_appeals.Size = new System.Drawing.Size(175, 26);
            this.menuStaff_appeals.Text = "Обращения";
            this.menuStaff_appeals.Click += new System.EventHandler(this.menuStaff_appeals_Click);
            // 
            // StaffTasks
            // 
            this.StaffTasks.Name = "StaffTasks";
            this.StaffTasks.Size = new System.Drawing.Size(175, 26);
            this.StaffTasks.Text = "Задачи";
            this.StaffTasks.Click += new System.EventHandler(this.StaffTasks_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(353, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(333, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Назначенные обращения";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(384, 497);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 42);
            this.button1.TabIndex = 24;
            this.button1.Text = "Сохранить изменения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idappealDataGridViewTextBoxColumn,
            this.idabonentDataGridViewTextBoxColumn,
            this.idstatusDataGridViewTextBoxColumn,
            this.appealtextDataGridViewTextBoxColumn,
            this.appealanswerDataGridViewTextBoxColumn,
            this.appealdateDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.appealBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 74);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(816, 396);
            this.dataGridView1.TabIndex = 25;
            // 
            // idappealDataGridViewTextBoxColumn
            // 
            this.idappealDataGridViewTextBoxColumn.DataPropertyName = "id_appeal";
            this.idappealDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idappealDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idappealDataGridViewTextBoxColumn.Name = "idappealDataGridViewTextBoxColumn";
            this.idappealDataGridViewTextBoxColumn.ReadOnly = true;
            this.idappealDataGridViewTextBoxColumn.Width = 35;
            // 
            // idabonentDataGridViewTextBoxColumn
            // 
            this.idabonentDataGridViewTextBoxColumn.DataPropertyName = "id_abonent";
            this.idabonentDataGridViewTextBoxColumn.HeaderText = "ID абонента";
            this.idabonentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idabonentDataGridViewTextBoxColumn.Name = "idabonentDataGridViewTextBoxColumn";
            this.idabonentDataGridViewTextBoxColumn.Width = 60;
            // 
            // idstatusDataGridViewTextBoxColumn
            // 
            this.idstatusDataGridViewTextBoxColumn.DataPropertyName = "id_status";
            this.idstatusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.idstatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idstatusDataGridViewTextBoxColumn.Name = "idstatusDataGridViewTextBoxColumn";
            this.idstatusDataGridViewTextBoxColumn.Width = 55;
            // 
            // appealtextDataGridViewTextBoxColumn
            // 
            this.appealtextDataGridViewTextBoxColumn.DataPropertyName = "appeal_text";
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.appealtextDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.appealtextDataGridViewTextBoxColumn.HeaderText = "Текст обращения";
            this.appealtextDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.appealtextDataGridViewTextBoxColumn.Name = "appealtextDataGridViewTextBoxColumn";
            this.appealtextDataGridViewTextBoxColumn.Width = 290;
            // 
            // appealanswerDataGridViewTextBoxColumn
            // 
            this.appealanswerDataGridViewTextBoxColumn.DataPropertyName = "appeal_answer";
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.appealanswerDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.appealanswerDataGridViewTextBoxColumn.HeaderText = "Ответ";
            this.appealanswerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.appealanswerDataGridViewTextBoxColumn.Name = "appealanswerDataGridViewTextBoxColumn";
            this.appealanswerDataGridViewTextBoxColumn.Width = 200;
            // 
            // appealdateDataGridViewTextBoxColumn
            // 
            this.appealdateDataGridViewTextBoxColumn.DataPropertyName = "appeal_date";
            this.appealdateDataGridViewTextBoxColumn.HeaderText = "Дата создания";
            this.appealdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.appealdateDataGridViewTextBoxColumn.Name = "appealdateDataGridViewTextBoxColumn";
            this.appealdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // appealBindingSource
            // 
            this.appealBindingSource.DataMember = "Appeal";
            this.appealBindingSource.DataSource = this.phoneStationDataSet;
            // 
            // phoneStationDataSet
            // 
            this.phoneStationDataSet.DataSetName = "PhoneStationDataSet";
            this.phoneStationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appealTableAdapter
            // 
            this.appealTableAdapter.ClearBeforeFill = true;
            // 
            // phoneStationDataSet1
            // 
            this.phoneStationDataSet1.DataSetName = "PhoneStationDataSet1";
            this.phoneStationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // phoneStationDataSet1BindingSource
            // 
            this.phoneStationDataSet1BindingSource.DataSource = this.phoneStationDataSet1;
            this.phoneStationDataSet1BindingSource.Position = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idstatusDataGridViewTextBoxColumn1,
            this.status_name});
            this.dataGridView2.DataSource = this.statusBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(837, 74);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(214, 185);
            this.dataGridView2.TabIndex = 26;
            // 
            // idstatusDataGridViewTextBoxColumn1
            // 
            this.idstatusDataGridViewTextBoxColumn1.DataPropertyName = "id_status";
            this.idstatusDataGridViewTextBoxColumn1.HeaderText = "№";
            this.idstatusDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idstatusDataGridViewTextBoxColumn1.Name = "idstatusDataGridViewTextBoxColumn1";
            this.idstatusDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idstatusDataGridViewTextBoxColumn1.Width = 35;
            // 
            // status_name
            // 
            this.status_name.DataPropertyName = "status_name";
            this.status_name.HeaderText = "Статус";
            this.status_name.MinimumWidth = 6;
            this.status_name.Name = "status_name";
            this.status_name.ReadOnly = true;
            this.status_name.Width = 125;
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.phoneStationDataSet2;
            // 
            // phoneStationDataSet2
            // 
            this.phoneStationDataSet2.DataSetName = "PhoneStationDataSet2";
            this.phoneStationDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // Staff_Appeals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 564);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Staff_Appeals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Назначенные обращения";
            this.Load += new System.EventHandler(this.Staff_Appeals_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appealBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneStationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneStationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneStationDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneStationDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem LKStaff_main;
        private System.Windows.Forms.ToolStripMenuItem menuStaff_Abonents;
        private System.Windows.Forms.ToolStripMenuItem menuStaff_connectAbonent;
        private System.Windows.Forms.ToolStripMenuItem menuStaff_showInfoAbonent;
        private System.Windows.Forms.ToolStripMenuItem menuStaff_appeals;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PhoneStationDataSet phoneStationDataSet;
        private System.Windows.Forms.BindingSource appealBindingSource;
        private PhoneStationDataSetTableAdapters.AppealTableAdapter appealTableAdapter;
        private PhoneStationDataSet1 phoneStationDataSet1;
        private System.Windows.Forms.BindingSource phoneStationDataSet1BindingSource;
        private System.Windows.Forms.DataGridView dataGridView2;
        private PhoneStationDataSet2 phoneStationDataSet2;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private PhoneStationDataSet2TableAdapters.StatusTableAdapter statusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstatusDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_name;
        private System.Windows.Forms.ToolStripMenuItem StaffTasks;
        private System.Windows.Forms.DataGridViewTextBoxColumn idappealDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idabonentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appealtextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appealanswerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn appealdateDataGridViewTextBoxColumn;
    }
}