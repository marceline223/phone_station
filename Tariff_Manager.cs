using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneStation
{
    public partial class Tariff_Manager : Form
    {
        public Tariff_Manager()
        {
            InitializeComponent();
        }

        private void Tariff_Manager_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "phoneStationDataSet6.Tariff". При необходимости она может быть перемещена или удалена.
            this.tariffTableAdapter.Fill(this.phoneStationDataSet6.Tariff);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                tariffTableAdapter.Update(phoneStationDataSet6.Tariff);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Изменения успешно применены");
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
