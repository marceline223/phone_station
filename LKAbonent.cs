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
    public partial class LKAbonent : Form
    {
        public int id_ = 0;
        public string FIO_ = "";
        public DateTime birthday_ = DateTime.MinValue;
        public int passport_ = 0;
        public int phonenumber_ = 0;
        public DateTime dateOfConnection_ = DateTime.MinValue;
        public int balance_ = 0;

        public LKAbonent(int id)
        {
            InitializeComponent();
            cn.Open();
            id_ = id;

            OleDbCommand command = new OleDbCommand("showInfoAbonent", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idAbonent", id);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                FIO_ = reader.GetString(0);
                birthday_ = reader.GetDateTime(1);
                passport_ = reader.GetInt32(2);
                phonenumber_ = reader.GetInt32(3);
                dateOfConnection_ = reader.GetDateTime(4);
                balance_ = reader.GetInt32(5);
            }
            refresh();
        }

        private void menu_balance_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance(id_);
            Hide();
            balance.ShowDialog();
            Show();
            refresh();
        }

        public void refresh()
        {
            getBalance();
            LK_FIO.Text = FIO_;
            LK_birthday.Text = birthday_.ToString().Substring(0, 10);
            LK_passport.Text = passport_.ToString();
            LK_phonenumber.Text = phonenumber_.ToString();
            LK_dateOfConnection.Text = dateOfConnection_.ToString().Substring(0, 10);
            LK_balance.Text = balance_.ToString();
        }

        private void menu_services_Click(object sender, EventArgs e)
        {
            Abonent_Services abonent_Services = new Abonent_Services(id_);
            Hide();
            abonent_Services.ShowDialog();
            Show();
            refresh();
        }

        public int getBalance()
        {
            OleDbCommand command = new OleDbCommand("showInfoAbonent", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idAbonent", id_);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                balance_ = reader.GetInt32(5);
            }
            return balance_;
        }

        private void menu_tariff_Click(object sender, EventArgs e)
        {
            Tariff tariff = new Tariff(id_);
            Hide();
            tariff.ShowDialog();
            Show();
            refresh();
        }

        private void LK_exit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void menu_messages_newMessage_Click(object sender, EventArgs e)
        {
            CreateMessage createMessage = new CreateMessage(id_);
            Hide();
            createMessage.ShowDialog();
            Show();
            refresh();
        }

        private void menu_messages_incoming_Click(object sender, EventArgs e)
        {
            IncomingMessages incoming = new IncomingMessages(id_);
            Hide();
            incoming.ShowDialog();
            Show();
            refresh();
        }

        private void menu_messages_outgoing_Click(object sender, EventArgs e)
        {
            OutgoingMessages outgoing = new OutgoingMessages(id_);
            Hide();
            outgoing.ShowDialog();
            Show();
            refresh();
        }

        private void menu_appeals_showMyAppeals_Click(object sender, EventArgs e)
        {
            AbonentAppeals abonentAppeals = new AbonentAppeals(id_);
            Hide();
            abonentAppeals.ShowDialog();
            Show();
            refresh();
        }

        private void menu_appeals_newAppeal_Click(object sender, EventArgs e)
        {
            CreateAppeal createAppeal = new CreateAppeal(id_);
            Hide();
            createAppeal.ShowDialog();
            Show();
            refresh();
        }

        private void LK_main_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void черныйСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlackList blackList = new BlackList(id_);
            Hide();
            blackList.ShowDialog();

            refresh();
        }
    }
}
