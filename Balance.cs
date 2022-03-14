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
    public partial class Balance : Form
    {
        public int id_;
        public int balance_;
        public Balance(int id)
        {
            InitializeComponent();
            cn.Open();
            id_ = id;

            refresh();
        }

        private void button_adjunction_Click(object sender, EventArgs e)
        {
            int sum = 0;
            string res = balance_sumForAdjunction.Text;
            if (res == "")
            {
                MessageBox.Show("Ошибка ввода. Введите положительное число, отличное от нуля.");
                return;
            }
            try
            {
                sum = Int32.Parse(res);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода. Введите положительное число, отличное от нуля.");
                return;
            }
            if (sum <= 0)
            {
                MessageBox.Show("Ошибка ввода. Введите положительное число, отличное от нуля.");
                return;
            }

            OleDbCommand command = new OleDbCommand("balanceAdjunction", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", id_);
            command.Parameters.AddWithValue("@sum", sum);
            command.ExecuteNonQuery();
            refresh();
            MessageBox.Show("Баланс успешно пополнен на " + sum.ToString() + " рублей.");
        }

        public void refresh()
        {
            getBalance();
            balance_info.Text = balance_.ToString();
        }

        private void menu_balance_Click(object sender, EventArgs e)
        {
            return;
        }

        private void menu_services_Click(object sender, EventArgs e)
        {
            Abonent_Services abonent_Services = new Abonent_Services(id_);
            Hide();
            abonent_Services.ShowDialog();
            
            refresh();
        }

        private void menu_tariff_Click(object sender, EventArgs e)
        {
            Tariff tariff = new Tariff(id_);
            Hide();
            tariff.ShowDialog();
            
            refresh();
        }

        private void menu_main_Click(object sender, EventArgs e)
        {
            Hide();
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

        private void menu_messages_newMessage_Click(object sender, EventArgs e)
        {
            CreateMessage createMessage = new CreateMessage(id_);
            Hide();
            createMessage.ShowDialog();
            
            refresh();
        }

        private void menu_messages_incoming_Click(object sender, EventArgs e)
        {
            IncomingMessages incoming = new IncomingMessages(id_);
            Hide();
            incoming.ShowDialog();
            refresh();
        }

        private void menu_messages_outgoing_Click(object sender, EventArgs e)
        {
            OutgoingMessages outgoing = new OutgoingMessages(id_);
            Hide();
            outgoing.ShowDialog();
            refresh();
        }

        private void menu_appeals_showMyAppeals_Click(object sender, EventArgs e)
        {
            AbonentAppeals abonentAppeals = new AbonentAppeals(id_);
            Hide();
            abonentAppeals.ShowDialog();
            
            refresh();
        }
        private void menu_appeals_newAppeal_Click(object sender, EventArgs e)
        {
            CreateAppeal createAppeal = new CreateAppeal(id_);
            Hide();
            createAppeal.ShowDialog();
            
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
