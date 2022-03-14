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
    public partial class CreateMessage : Form
    {
        public int id_ = 0;
        public CreateMessage(int id)
        {
            InitializeComponent();
            cn.Open();
            id_ = id;
            refresh();
        }

        public void refresh()
        {
            textMessage.Text = "";
            phonenumber_to.Text = "";
        }

        private void button_sendMessage_Click(object sender, EventArgs e)
        {
            if (textMessage.Text == "" || phonenumber_to.Text == "")
            {
                MessageBox.Show("Введите получателя и текст сообщения.");
                return;
            }
            if (textMessage.Text.Length > 250)
            {
                MessageBox.Show("Текст сообщения превышает лимит в 250 символов.");
                return;
            }
            int phonenumberTo = -1;
            try
            {
                phonenumberTo = Int32.Parse(phonenumber_to.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка ввода. Введите номер телефона, состоящий из цифр.");
                return;
            }
            if (phonenumberTo < 0)
            {
                MessageBox.Show("Ошибка ввода. Введите номер телефона, состоящий из цифр.");
                return;
            }

            OleDbCommand command = new OleDbCommand("checkAbonent", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@phonenumber", phonenumberTo);
            int idAbonentTo = -1;
            OleDbDataReader reader = command.ExecuteReader();
            bool isConnected = false;
            while (reader.Read())
            {
                idAbonentTo = reader.GetInt32(0);
                isConnected = reader.GetBoolean(7);
            }
            if (idAbonentTo == -1)
            {
                MessageBox.Show("Номер не найден. Попробуйте ещё раз.");
                phonenumber_to.Text = "";
                return;
            }
            if (!isConnected)
            {
                MessageBox.Show("Абонент отключен и не может получать сообщения.");
                phonenumber_to.Text = "";
                return;
            }

            command = new OleDbCommand("checkIfAbonentInBlackList", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idAbonent1", idAbonentTo);
            command.Parameters.AddWithValue("@idAbonent2", id_);
            reader = command.ExecuteReader();
            bool isBlocked = false;

            while (reader.Read())
            {
                isBlocked = true;
            }

            if (isBlocked)
            {
                MessageBox.Show("Ошибка: абонент Вас заблокировал, вы не можете отправлять ему сообщения.");
                phonenumber_to.Text = "";
                return;
            }


            string text = textMessage.Text;

            command = new OleDbCommand("newMessage", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idFrom", id_);
            command.Parameters.AddWithValue("@idTo", idAbonentTo);
            command.Parameters.AddWithValue("@text", text);
            command.Parameters.AddWithValue("@date", DateTime.Today);

            command.ExecuteNonQuery();
            MessageBox.Show("Сообщение отправлено");
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

        private void menu_messages_incoming_Click(object sender, EventArgs e)
        {
            IncomingMessages incoming = new IncomingMessages(id_);
            Hide();
            incoming.ShowDialog();

            refresh();
        }

        private void menu_messages_outgoing_Click(object sender, EventArgs e)
        {
            OutgoingMessages outgoingMessages = new OutgoingMessages(id_);
            Hide();
            outgoingMessages.ShowDialog();

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
