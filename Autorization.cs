using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneStation
{
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
            cn.Open();
        }

        private void button_autorizeAbonent_Click(object sender, EventArgs e)
        {
            //если находим номер в базе абонентов и пароль совпадает - открываем личный кабинет
            //если нет - выдаем ошибку и стираем поле пароля

            if (autorizationPhoneNumber == null || autorizationPassword == null)
            {
                MessageBox.Show("Введите логин и пароль.");
                return;
            }

            OleDbCommand command = new OleDbCommand("checkAbonent", cn);
            command.CommandType = CommandType.StoredProcedure;
            int phoneNumber = -1;
            try
            {
                phoneNumber = Int32.Parse(autorizationPhoneNumber.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода. Введите свой номер телефона");
                return;
            }
            command.Parameters.AddWithValue("@phoneNumber", phoneNumber);

            OleDbDataReader reader = command.ExecuteReader();
            int idAbonent = -1;
            DateTime birthdayAbonent = DateTime.Today;
            bool isConnected = false;
            while (reader.Read())
            {
                idAbonent = reader.GetInt32(0); //получаем id пользователя
                isConnected = reader.GetBoolean(7);
                birthdayAbonent = reader.GetDateTime(2); //получаем его др
            }
            if (idAbonent == -1)
            {
                MessageBox.Show("Такой пользователь не найден. Попробуйте ещё раз.");
                autorizationPassword.Text = "";
                return;
            }
            if (!isConnected)
            {
                MessageBox.Show("Абонент отключен. Обратитесь в службу поддержки.");
                return;
            }
            else //если нашли
            {
                string correctPassword = birthdayAbonent.ToString().Substring(0,2) + birthdayAbonent.ToString().Substring(3,2); //вычисляем правильный пароль для данного пользователя
                if (autorizationPassword.Text == correctPassword)
                {
                    MessageBox.Show("Выполняется вход в личный кабинет.");
                    LKAbonent lKAbonent = new LKAbonent(idAbonent);
                    Hide();
                    lKAbonent.ShowDialog();
                    Show();
                    refresh();
                }
                else
                {
                    MessageBox.Show("Неверный пароль.");
                    autorizationPassword.Text = "";
                    return;
                }
            }
        }

        private void button_autorizeStaff_Click(object sender, EventArgs e)
        {
            //
            if (autorization_staffID == null && autorization_StaffPassword == null)
            {
                MessageBox.Show("Введите идентификатор и пароль.");
                return;
            }
            int idStaff = -1;
            try
            {
                idStaff = Int32.Parse(autorization_staffID.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода. Введите свой идентификатор");
                return;
            }

            OleDbCommand command = new OleDbCommand("showInfoStaff", cn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idStaff", int.Parse(autorization_staffID.Text));
            OleDbDataReader reader = command.ExecuteReader();

            int isFind = -1;
            DateTime dateOfStartWorking = DateTime.Today;

            //если менеджер
            if (idStaff == 999)
            {
                if (autorization_StaffPassword.Text == "111")
                {
                    MessageBox.Show("Выполняется вход в личный кабинет менеджера");
                    LKManager lKManager = new LKManager();
                    Hide();
                    lKManager.ShowDialog();
                    Show();
                    refresh();
                    return;
                }
                else
                {
                    MessageBox.Show("Такой сотрудник не найден. Попробуйте ещё раз.");
                    autorization_StaffPassword.Text = "";
                    return;
                }
            
            }

            while (reader.Read())
            {
                dateOfStartWorking = reader.GetDateTime(3); //получаем дату начала работы (для пароля)
                isFind = 0;
            }
            if (isFind == -1) //если не нашли
            {
                MessageBox.Show("Такой сотрудник не найден. Попробуйте ещё раз.");
                autorization_StaffPassword.Text = "";
                return;
            }
            else //если нашли
            {
                string correctPassword = dateOfStartWorking.ToString().Substring(0, 2) + dateOfStartWorking.ToString().Substring(3, 2); //вычисляем правильный пароль для данного пользователя
                if (autorization_StaffPassword.Text == correctPassword)
                {
                    MessageBox.Show("Выполняется вход в личный кабинет сотрудника.");
                    LKStaff lKStaff = new LKStaff(idStaff);
                    Hide();
                    lKStaff.ShowDialog();
                    Show();
                    refresh();
                }
                else
                {
                    MessageBox.Show("Неверный пароль.");
                    autorizationPassword.Text = "";
                    return;
                }
            }
        }

        public void refresh()
        {
            autorizationPhoneNumber.Text = "";
            autorizationPassword.Text = "";
            autorization_staffID.Text = "";
            autorization_StaffPassword.Text = "";
        }
    }
}
