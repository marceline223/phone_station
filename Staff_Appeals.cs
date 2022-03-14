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
    public partial class Staff_Appeals : Form
    {
        public int idStaff_ = 0;
        public Staff_Appeals(int idStaff)
        {
            InitializeComponent();
            idStaff_ = idStaff;
            cn.Open();
        }

        private void Staff_Appeals_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "phoneStationDataSet2.Status". При необходимости она может быть перемещена или удалена.
            this.statusTableAdapter.Fill(this.phoneStationDataSet2.Status);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "phoneStationDataSet.Appeal". При необходимости она может быть перемещена или удалена.
            this.appealTableAdapter.Fill(this.phoneStationDataSet.Appeal);

            
            try
            {
                this.appealTableAdapter.showAppealsForStaff(this.phoneStationDataSet.Appeal, idStaff_);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                appealTableAdapter.Update(phoneStationDataSet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void StaffTasks_Click(object sender, EventArgs e)
        {
            StaffTasks staffTasks = new StaffTasks(idStaff_);
            Hide();
            staffTasks.ShowDialog();
            Refresh();
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

        private void LKStaff_main_Click(object sender, EventArgs e)
        {
            LKStaff lKStaff = new LKStaff(idStaff_);
            Hide();
            lKStaff.ShowDialog();
        }
    }
}
