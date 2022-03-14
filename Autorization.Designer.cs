
namespace PhoneStation
{
    partial class Autorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.AutorizationAbonentAndStaff = new System.Windows.Forms.TabControl();
            this.autorizationAbonent = new System.Windows.Forms.TabPage();
            this.button_autorizeAbonent = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.autorizationPassword = new System.Windows.Forms.TextBox();
            this.autorizationPhoneNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.autorizationStaff = new System.Windows.Forms.TabPage();
            this.button_autorizeStaff = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.autorization_StaffPassword = new System.Windows.Forms.TextBox();
            this.autorization_staffID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cn = new System.Data.OleDb.OleDbConnection();
            this.AutorizationAbonentAndStaff.SuspendLayout();
            this.autorizationAbonent.SuspendLayout();
            this.autorizationStaff.SuspendLayout();
            this.SuspendLayout();
            // 
            // AutorizationAbonentAndStaff
            // 
            this.AutorizationAbonentAndStaff.Controls.Add(this.autorizationAbonent);
            this.AutorizationAbonentAndStaff.Controls.Add(this.autorizationStaff);
            this.AutorizationAbonentAndStaff.Location = new System.Drawing.Point(2, 2);
            this.AutorizationAbonentAndStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AutorizationAbonentAndStaff.Name = "AutorizationAbonentAndStaff";
            this.AutorizationAbonentAndStaff.SelectedIndex = 0;
            this.AutorizationAbonentAndStaff.Size = new System.Drawing.Size(1065, 555);
            this.AutorizationAbonentAndStaff.TabIndex = 0;
            // 
            // autorizationAbonent
            // 
            this.autorizationAbonent.Controls.Add(this.button_autorizeAbonent);
            this.autorizationAbonent.Controls.Add(this.label4);
            this.autorizationAbonent.Controls.Add(this.autorizationPassword);
            this.autorizationAbonent.Controls.Add(this.autorizationPhoneNumber);
            this.autorizationAbonent.Controls.Add(this.label3);
            this.autorizationAbonent.Controls.Add(this.label2);
            this.autorizationAbonent.Controls.Add(this.label1);
            this.autorizationAbonent.Location = new System.Drawing.Point(4, 25);
            this.autorizationAbonent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autorizationAbonent.Name = "autorizationAbonent";
            this.autorizationAbonent.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autorizationAbonent.Size = new System.Drawing.Size(1057, 526);
            this.autorizationAbonent.TabIndex = 0;
            this.autorizationAbonent.Text = "Абоненты";
            this.autorizationAbonent.UseVisualStyleBackColor = true;
            // 
            // button_autorizeAbonent
            // 
            this.button_autorizeAbonent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_autorizeAbonent.Location = new System.Drawing.Point(424, 418);
            this.button_autorizeAbonent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_autorizeAbonent.Name = "button_autorizeAbonent";
            this.button_autorizeAbonent.Size = new System.Drawing.Size(217, 58);
            this.button_autorizeAbonent.TabIndex = 6;
            this.button_autorizeAbonent.Text = "Войти";
            this.button_autorizeAbonent.UseVisualStyleBackColor = true;
            this.button_autorizeAbonent.Click += new System.EventHandler(this.button_autorizeAbonent_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(384, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "(по умолчанию: ДДММ рождения)";
            // 
            // autorizationPassword
            // 
            this.autorizationPassword.Location = new System.Drawing.Point(161, 256);
            this.autorizationPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autorizationPassword.Name = "autorizationPassword";
            this.autorizationPassword.Size = new System.Drawing.Size(207, 22);
            this.autorizationPassword.TabIndex = 4;
            this.autorizationPassword.UseSystemPasswordChar = true;
            // 
            // autorizationPhoneNumber
            // 
            this.autorizationPhoneNumber.Location = new System.Drawing.Point(161, 174);
            this.autorizationPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autorizationPhoneNumber.Name = "autorizationPhoneNumber";
            this.autorizationPhoneNumber.Size = new System.Drawing.Size(207, 22);
            this.autorizationPhoneNumber.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(93, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Номер телефона:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(382, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вход в личный кабинет";
            // 
            // autorizationStaff
            // 
            this.autorizationStaff.Controls.Add(this.button_autorizeStaff);
            this.autorizationStaff.Controls.Add(this.label7);
            this.autorizationStaff.Controls.Add(this.autorization_StaffPassword);
            this.autorizationStaff.Controls.Add(this.autorization_staffID);
            this.autorizationStaff.Controls.Add(this.label6);
            this.autorizationStaff.Controls.Add(this.label5);
            this.autorizationStaff.Location = new System.Drawing.Point(4, 25);
            this.autorizationStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autorizationStaff.Name = "autorizationStaff";
            this.autorizationStaff.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autorizationStaff.Size = new System.Drawing.Size(1057, 526);
            this.autorizationStaff.TabIndex = 1;
            this.autorizationStaff.Text = "Сотрудники станции";
            this.autorizationStaff.UseVisualStyleBackColor = true;
            // 
            // button_autorizeStaff
            // 
            this.button_autorizeStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_autorizeStaff.Location = new System.Drawing.Point(436, 415);
            this.button_autorizeStaff.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_autorizeStaff.Name = "button_autorizeStaff";
            this.button_autorizeStaff.Size = new System.Drawing.Size(217, 58);
            this.button_autorizeStaff.TabIndex = 7;
            this.button_autorizeStaff.Text = "Войти";
            this.button_autorizeStaff.UseVisualStyleBackColor = true;
            this.button_autorizeStaff.Click += new System.EventHandler(this.button_autorizeStaff_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(392, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(289, 29);
            this.label7.TabIndex = 4;
            this.label7.Text = "Вход для сотрудников";
            // 
            // autorization_StaffPassword
            // 
            this.autorization_StaffPassword.Location = new System.Drawing.Point(161, 256);
            this.autorization_StaffPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autorization_StaffPassword.Name = "autorization_StaffPassword";
            this.autorization_StaffPassword.Size = new System.Drawing.Size(215, 22);
            this.autorization_StaffPassword.TabIndex = 3;
            this.autorization_StaffPassword.UseSystemPasswordChar = true;
            // 
            // autorization_staffID
            // 
            this.autorization_staffID.Location = new System.Drawing.Point(161, 174);
            this.autorization_staffID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.autorization_staffID.Name = "autorization_staffID";
            this.autorization_staffID.Size = new System.Drawing.Size(215, 22);
            this.autorization_staffID.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(93, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Пароль:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Идентификатор:";
            // 
            // cn
            // 
            this.cn.ConnectionString = "Provider=SQLNCLI11;Data Source=localhost;Integrated Security=SSPI;Initial Catalog" +
    "=PhoneStation";
            // 
            // Autorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.AutorizationAbonentAndStaff);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Autorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.AutorizationAbonentAndStaff.ResumeLayout(false);
            this.autorizationAbonent.ResumeLayout(false);
            this.autorizationAbonent.PerformLayout();
            this.autorizationStaff.ResumeLayout(false);
            this.autorizationStaff.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl AutorizationAbonentAndStaff;
        private System.Windows.Forms.TabPage autorizationAbonent;
        private System.Windows.Forms.Button button_autorizeAbonent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox autorizationPassword;
        private System.Windows.Forms.TextBox autorizationPhoneNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage autorizationStaff;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox autorization_StaffPassword;
        private System.Windows.Forms.TextBox autorization_staffID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_autorizeStaff;
        private System.Data.OleDb.OleDbConnection cn;
    }
}

