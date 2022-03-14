
namespace PhoneStation
{
    partial class StaffTasks
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
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idtaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptiontaskDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.taskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.phoneStationDataSet3 = new PhoneStation.PhoneStationDataSet3();
            this.taskTableAdapter = new PhoneStation.PhoneStationDataSet3TableAdapters.TaskTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.LKStaff_main = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStaff_Abonents = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStaff_connectAbonent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStaff_showInfoAbonent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStaff_appeals = new System.Windows.Forms.ToolStripMenuItem();
            this.StaffTask = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneStationDataSet3)).BeginInit();
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
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(440, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 29);
            this.label5.TabIndex = 20;
            this.label5.Text = "Текущие задачи";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtaskDataGridViewTextBoxColumn,
            this.nametaskDataGridViewTextBoxColumn,
            this.descriptiontaskDataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.taskBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(48, 82);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(980, 356);
            this.dataGridView1.TabIndex = 21;
            // 
            // idtaskDataGridViewTextBoxColumn
            // 
            this.idtaskDataGridViewTextBoxColumn.DataPropertyName = "id_task";
            this.idtaskDataGridViewTextBoxColumn.HeaderText = "№";
            this.idtaskDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idtaskDataGridViewTextBoxColumn.Name = "idtaskDataGridViewTextBoxColumn";
            this.idtaskDataGridViewTextBoxColumn.ReadOnly = true;
            this.idtaskDataGridViewTextBoxColumn.Width = 50;
            // 
            // nametaskDataGridViewTextBoxColumn
            // 
            this.nametaskDataGridViewTextBoxColumn.DataPropertyName = "name_task";
            this.nametaskDataGridViewTextBoxColumn.HeaderText = "Тема";
            this.nametaskDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nametaskDataGridViewTextBoxColumn.Name = "nametaskDataGridViewTextBoxColumn";
            this.nametaskDataGridViewTextBoxColumn.ReadOnly = true;
            this.nametaskDataGridViewTextBoxColumn.Width = 250;
            // 
            // descriptiontaskDataGridViewTextBoxColumn
            // 
            this.descriptiontaskDataGridViewTextBoxColumn.DataPropertyName = "description_task";
            this.descriptiontaskDataGridViewTextBoxColumn.HeaderText = "Описание задачи";
            this.descriptiontaskDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptiontaskDataGridViewTextBoxColumn.Name = "descriptiontaskDataGridViewTextBoxColumn";
            this.descriptiontaskDataGridViewTextBoxColumn.ReadOnly = true;
            this.descriptiontaskDataGridViewTextBoxColumn.Width = 500;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Выполнена";
            this.statusDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.Width = 125;
            // 
            // taskBindingSource
            // 
            this.taskBindingSource.DataMember = "Task";
            this.taskBindingSource.DataSource = this.phoneStationDataSet3;
            // 
            // phoneStationDataSet3
            // 
            this.phoneStationDataSet3.DataSetName = "PhoneStationDataSet3";
            this.phoneStationDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // taskTableAdapter
            // 
            this.taskTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(417, 465);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 42);
            this.button1.TabIndex = 25;
            this.button1.Text = "Сохранить изменения";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.menuStrip1.TabIndex = 26;
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
            // StaffTask
            // 
            this.StaffTask.Name = "StaffTask";
            this.StaffTask.Size = new System.Drawing.Size(175, 26);
            this.StaffTask.Text = "Задачи";
            this.StaffTask.Click += new System.EventHandler(this.StaffTask_Click);
            // 
            // StaffTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StaffTasks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Текущие задачи";
            this.Load += new System.EventHandler(this.StaffTasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taskBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneStationDataSet3)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Data.OleDb.OleDbConnection cn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PhoneStationDataSet3 phoneStationDataSet3;
        private System.Windows.Forms.BindingSource taskBindingSource;
        private PhoneStationDataSet3TableAdapters.TaskTableAdapter taskTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem LKStaff_main;
        private System.Windows.Forms.ToolStripMenuItem menuStaff_Abonents;
        private System.Windows.Forms.ToolStripMenuItem menuStaff_connectAbonent;
        private System.Windows.Forms.ToolStripMenuItem menuStaff_showInfoAbonent;
        private System.Windows.Forms.ToolStripMenuItem menuStaff_appeals;
        private System.Windows.Forms.ToolStripMenuItem StaffTask;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptiontaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
    }
}