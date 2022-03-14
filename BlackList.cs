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
    public partial class BlackList : Form
    {
        public int id_ = 0;
        public BlackList(int id)
        {
            InitializeComponent();
            id_ = id;
            cn.Open();
            refresh();
        }

        public void refresh()
        {
            list.Rows.Clear();
            loadList();
        }

        public void loadList()
        {
            OleDbCommand command = new OleDbCommand("showBlackList", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idAbonent", id_);
            OleDbDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[2]);

                data[data.Count - 1][0] = reader.GetInt32(0).ToString();
                data[data.Count - 1][1] = reader.GetString(1);
            }

            foreach (string[] s in data)
            {
                list.Rows.Add(s);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = -1;
            try
            {
                number = Int32.Parse(phoneNumber.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода. Введите номер телефона, состоящий из цифр.");
                return;
            }
            if (number < 0)
            {
                MessageBox.Show("Ошибка ввода. Введите номер телефона, состоящий из цифр.");
                return;
            }

            OleDbCommand command = new OleDbCommand("checkAbonent", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@phonenumber", number);
            int idAbonent = -1;
            OleDbDataReader reader = command.ExecuteReader();
            bool isConnected = false;
            while (reader.Read())
            {
                idAbonent = reader.GetInt32(0);
                isConnected = reader.GetBoolean(7);
            }
            if (idAbonent == -1)
            {
                MessageBox.Show("Номер не найден. Попробуйте ещё раз.");
                phoneNumber.Text = "";
                return;
            }
            if (!isConnected)
            {
                MessageBox.Show("Абонент отключен и не может быть в черном списке.");
                phoneNumber.Text = "";
                return;
            }

            OleDbCommand command1 = new OleDbCommand("addToBlackList", cn);
            command1.CommandType = CommandType.StoredProcedure;
            command1.Parameters.AddWithValue("@idAbonent", id_);
            command1.Parameters.AddWithValue("@idAbonentToBlock", idAbonent);
            command1.ExecuteNonQuery();
            MessageBox.Show("Номер успешно заблокирован. Теперь Вы не сможете получать от абонента сообщения.");

            refresh();
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

        private void menu_services_Click(object sender, EventArgs e)
        {
            Abonent_Services abonent_Services = new Abonent_Services(id_);
            Hide();
            abonent_Services.ShowDialog();

            refresh();
        }

        private void menu_balance_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance(id_);
            Hide();
            balance.ShowDialog();

            refresh();
        }

        private void menu_main_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void menu_tariff_Click(object sender, EventArgs e)
        {
            Tariff tariff = new Tariff(id_);
            Hide();
            tariff.ShowDialog();

            refresh();
        }

        private void blackListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlackList blackList = new BlackList(id_);
            Hide();
            blackList.ShowDialog();

            refresh();
        }

    }
}
