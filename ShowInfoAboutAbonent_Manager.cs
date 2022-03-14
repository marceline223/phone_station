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
    public partial class ShowInfoAboutAbonent_Manager : Form
    {
        public ShowInfoAboutAbonent_Manager()
        {
            InitializeComponent();
            cn.Open();
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

        private void infoStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoStaff info = new InfoStaff();
            Hide();
            info.ShowDialog();
        }

        private void addStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStaff add = new AddStaff();
            Hide();
            add.ShowDialog();
        }

        private void deleteStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStaff deleteStaff = new DeleteStaff();
            Hide();
            deleteStaff.ShowDialog();
        }

        private void allStaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllStaff allStaff = new AllStaff();
            Hide();
            allStaff.ShowDialog();
        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manager_Tasks manager_tasks = new Manager_Tasks();
            Hide();
            manager_tasks.ShowDialog();
        }

        private void infoAbonentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowInfoAboutAbonent_Manager showInfoAboutAbonent = new ShowInfoAboutAbonent_Manager();
            Hide();
            showInfoAboutAbonent.ShowDialog();
        }

        private void allAbonentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllAbonents allAbonents = new AllAbonents();
            Hide();
            allAbonents.ShowDialog();
        }

        private void tariffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tariff_Manager tariff_Manager = new Tariff_Manager();
            Hide();
            tariff_Manager.ShowDialog();
        }

        private void ServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServicesManager servicesManager = new ServicesManager();
            Hide();
            servicesManager.ShowDialog();
        }
    }
}
