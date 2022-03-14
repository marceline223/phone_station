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
    public partial class ShowInfoAboutAbonent : Form
    {
        public int idStaff_ = 0;
        public ShowInfoAboutAbonent(int idStaff)
        {
            InitializeComponent();
            cn.Open();
            idStaff_ = idStaff;
            refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int phonenumber = -1;
            try
            {
                phonenumber = Int32.Parse(abonentPhonenumber.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода номера.");
                return;
            }

            OleDbCommand command = new OleDbCommand("showInfoForNumber", cn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@phonenumber", phonenumber);
            OleDbDataReader reader = command.ExecuteReader();
            int isFind = -1;

            while (reader.Read())
            {
                abonentName.Text = reader.GetString(0);
                abonentBirthday.Format = DateTimePickerFormat.Custom;
                abonentBirthday.CustomFormat = "dd.MM.yyyy";
                abonentBirthday.Value = reader.GetDateTime(1);

                abonentPassport.Text = reader.GetInt32(2).ToString();

                abonentDateOfConnection.Format = DateTimePickerFormat.Custom;
                abonentDateOfConnection.CustomFormat = "dd.MM.yyyy";
                abonentDateOfConnection.Value = reader.GetDateTime(3);

                abonentBalance.Text = reader.GetInt32(4).ToString();
                bool isConnected = reader.GetBoolean(6);
                if (isConnected)
                {
                    isConnectedAbonent.CheckState = CheckState.Checked;
                }
                else
                {
                    isConnectedAbonent.CheckState = CheckState.Unchecked;
                }
                isFind = 1;
            }
            if (isFind == -1)
            {
                MessageBox.Show("Номер не найден.");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int phonenumber = -1;
            try
            {
                phonenumber = Int32.Parse(abonentPhonenumber.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода номера.");
                return;
            }

            string name = abonentName.Text;
            DateTime birth = abonentBirthday.Value;
            int passport = -1;
            try
            {
                passport = Int32.Parse(abonentPassport.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода.");
                return;
            }
            DateTime dateConnection = abonentDateOfConnection.Value;
            int balance = -1;
            try
            {
                balance = Int32.Parse(abonentBalance.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода.");
                return;
            }

            bool isConn;
            if (isConnectedAbonent.CheckState == CheckState.Checked)
            {
                isConn = true;
            }
            else
            {
                isConn = false;
            }
            OleDbCommand command = new OleDbCommand("changeAbonentInfo", cn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@phonenumber", phonenumber);
            command.Parameters.AddWithValue("@name", name);
            command.Parameters.AddWithValue("@birthday", birth);
            command.Parameters.AddWithValue("@passport", passport);
            command.Parameters.AddWithValue("@dateOfConnection", dateConnection);
            command.Parameters.AddWithValue("@balance", balance);
            command.Parameters.AddWithValue("@isConnected", isConn);

            command.ExecuteNonQuery();

            MessageBox.Show("Данные успешно обновлены");
        }

        public void refresh()
        {
            abonentName.Clear();
            abonentPassport.Clear();
            abonentBalance.Clear();
            abonentBirthday.Value = DateTime.Today;
            abonentDateOfConnection.Value = DateTime.Today;
            isConnectedAbonent.CheckState = CheckState.Checked;
        }

        private void menuStaff_connectAbonent_Click(object sender, EventArgs e)
        {
            ConnectAbonent connectAbonent = new ConnectAbonent(idStaff_);
            Hide();
            connectAbonent.ShowDialog();
        }

        private void menuStaff_showInfoAbonent_Click(object sender, EventArgs e)
        {
            ShowInfoAboutAbonent showInfoAboutAbonent = new ShowInfoAboutAbonent(idStaff_);
            Hide();
            showInfoAboutAbonent.ShowDialog();
        }

        private void menuStaff_appeals_Click(object sender, EventArgs e)
        {
            Staff_Appeals staff_Appeals = new Staff_Appeals(idStaff_);
            Hide();
            staff_Appeals.ShowDialog();
        }

        private void StaffTask_Click(object sender, EventArgs e)
        {
            StaffTasks staffTasks = new StaffTasks(idStaff_);
            Hide();
            staffTasks.ShowDialog();
            Refresh();
        }

        private void LKStaff_main_Click(object sender, EventArgs e)
        {
            LKStaff lKStaff = new LKStaff(idStaff_);
            Hide();
            lKStaff.ShowDialog();
        }
    }
}
