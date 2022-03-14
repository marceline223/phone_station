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
    public partial class DeleteStaff : Form
    {
        public DeleteStaff()
        {
            InitializeComponent();
            cn.Open();
        }

        private void button_Show_Click(object sender, EventArgs e)
        {
            int id = -1;
            bool isFind = false;
            try
            {
                id = Int32.Parse(idStaff.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода ID сотрудника.");
                return;
            }

            OleDbCommand command = new OleDbCommand("showInfoStaff", cn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idStaff", id);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                fio.Text = reader.GetString(0);

                birthday.Format = DateTimePickerFormat.Custom;
                birthday.CustomFormat = "dd.MM.yyyy";
                birthday.Value = reader.GetDateTime(1);

                dateOfStartWorking.Format = DateTimePickerFormat.Custom;
                dateOfStartWorking.CustomFormat = "dd.MM.yyyy";
                dateOfStartWorking.Value = reader.GetDateTime(3);

                passport.Text = reader.GetInt32(2).ToString();

                isFind = true;
            }

            if (!isFind)
            {
                MessageBox.Show("Сотрудника с данным ID не существует");
                return;
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            int id = -1;
            bool isFind = false;
            try
            {
                id = Int32.Parse(idStaff.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода ID сотрудника.");
                return;
            }

            OleDbCommand command = new OleDbCommand("deleteStaff", cn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idStaff", id);
            command.ExecuteNonQuery();

            MessageBox.Show("Сотрудник успешно уволен. Все задачи и обращения, за которые он был ответственным, перенесены на других сотрудников.");
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
