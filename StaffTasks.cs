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
    public partial class StaffTasks : Form
    {
        public int idStaff_;
        public StaffTasks(int idStaff)
        {
            InitializeComponent();
            idStaff_ = idStaff;
        }

        private void StaffTasks_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "phoneStationDataSet3.Task". При необходимости она может быть перемещена или удалена.
            this.taskTableAdapter.Fill(this.phoneStationDataSet3.Task);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                taskTableAdapter.Update(phoneStationDataSet3);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
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
