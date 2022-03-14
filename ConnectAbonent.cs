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
    public partial class ConnectAbonent : Form
    {
        public int idStaff_ = 0;
        public ConnectAbonent(int id)
        {
            InitializeComponent();
            idStaff_ = id;
            cn.Open();

            refresh();
        }

        private void refresh()
        {
            fio.Clear();
            birthday.Value = DateTime.Today;
            passport.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fio == null || birthday == null || passport == null)
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return;
            }

            OleDbCommand command = new OleDbCommand("getFreeNumber", cn);
            command.CommandType = CommandType.StoredProcedure;
            OleDbDataReader reader = command.ExecuteReader();
            int number = -1;
            while (reader.Read())
            {
                number = reader.GetInt32(0);
            }
            if (number == -1)
            {
                MessageBox.Show("Нет свободных номеров. Обратитесь к менеджеру.");
                return;
            }

            string name = fio.Text;
            birthday.Format = DateTimePickerFormat.Custom;
            birthday.CustomFormat = "dd.mm.yyyy";
            DateTime birth = birthday.Value;
            int passp = Int32.Parse(passport.Text);

            OleDbCommand command2 = new OleDbCommand("connectAbonent", cn);
            command2.CommandType = CommandType.StoredProcedure;

            command2.Parameters.AddWithValue("@name", name);
            command2.Parameters.AddWithValue("@birthday", birth);
            command2.Parameters.AddWithValue("@passport", passp);
            command2.Parameters.AddWithValue("@phonenumber", number);
            command2.Parameters.AddWithValue("@dateOfConnection", DateTime.Today);

            command2.ExecuteNonQuery();

            MessageBox.Show("Абонент успешно подключен. Ему присвоен номер " + number.ToString());


            OleDbCommand command3 = new OleDbCommand("setNumberNotFree", cn);
            command3.CommandType = CommandType.StoredProcedure;
            command3.Parameters.AddWithValue("@phonenumber", number);
            command3.ExecuteNonQuery();

            refresh();
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

        private void menuStaff_appeals_Click_1(object sender, EventArgs e)
        {
            Staff_Appeals staff_Appeals = new Staff_Appeals(idStaff_);
            Hide();
            staff_Appeals.ShowDialog();
        }

        private void StaffTasks_Click(object sender, EventArgs e)
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
