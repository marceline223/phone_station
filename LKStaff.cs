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
    public partial class LKStaff : Form
    {
        public int idStaff_ = 0;
        public string nameStaff_ = "";
        public DateTime birthdayStaff_ = DateTime.MinValue;
        public int passportStaff_ = 0;
        public DateTime dateOfStartWorkingStaff_ = DateTime.MinValue;

        public LKStaff(int idStaff)
        {
            InitializeComponent();
            idStaff_ = idStaff;
            cn.Open();

            OleDbCommand command = new OleDbCommand("showInfoStaff", cn);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@idStaff", idStaff_);
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                nameStaff_ = reader.GetString(0);
                birthdayStaff_ = reader.GetDateTime(1);
                passportStaff_ = reader.GetInt32(2);
                dateOfStartWorkingStaff_ = reader.GetDateTime(3);
            }

            refresh();
        }

        private void LKStaff_main_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            staffName.Text = nameStaff_;
            staffBirthday.Text = birthdayStaff_.ToString().Substring(0,10);
            staffPassport.Text = passportStaff_.ToString();
            staffDateOfStartWorking.Text = dateOfStartWorkingStaff_.ToString().Substring(0,10);
        }

        private void LK_exit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void menuStaff_connectAbonent_Click(object sender, EventArgs e)
        {
            ConnectAbonent connectAbonent = new ConnectAbonent(idStaff_);
            Hide();
            connectAbonent.ShowDialog();
            Show();
            refresh();
        }

        private void menuStaff_showInfoAbonent_Click(object sender, EventArgs e)
        {
            ShowInfoAboutAbonent showInfoAboutAbonent = new ShowInfoAboutAbonent(idStaff_);
            Hide();
            showInfoAboutAbonent.ShowDialog();
            Show();
            refresh();
        }

        private void menuStaff_appeals_Click(object sender, EventArgs e)
        {
            Staff_Appeals staff_Appeals = new Staff_Appeals(idStaff_);
            Hide();
            staff_Appeals.ShowDialog();
            Show();
            refresh();
        }

        private void StaffTask_Click(object sender, EventArgs e)
        {
            StaffTasks staffTasks = new StaffTasks(idStaff_);
            Hide();
            staffTasks.ShowDialog();
            Show();
            Refresh();
        }
    }
}
