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
    public partial class Abonent_Services : Form
    {
        public int id_ = 0;
        public int balance_ = 0;
        public List<int> accesibleServices = new List<int>();
        public List<int> currentServices = new List<int>();
        public Abonent_Services(int id)
        {
            InitializeComponent();
            cn.Open();
            id_ = id;
            balance_ = getBalance();

            refresh();
        }

        public void loadList()
        {
            OleDbCommand command = new OleDbCommand("showAccesibleServicesForAbonent", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", id_);

            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                checkedListBox1.Items.Add(reader.GetString(0) + " - " + reader.GetInt32(1).ToString() + " руб.");
                accesibleServices.Add(reader.GetInt32(2));
            }
        }

        public void loadListForDelete()
        {
            OleDbCommand command = new OleDbCommand("showServicesForAbonent", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id", id_);

            OleDbDataReader reader = command.ExecuteReader();
            List<string> data = new List<string>();
            while (reader.Read())
            {
                data.Add(reader.GetString(0));
                currentServices.Add(reader.GetInt32(1)); //добавляем id сервиса в список подключенных
            }
            foreach (String s in data)
            {
               checkedListBox2.Items.Add(s);
            }
        }

        public void refresh()
        {
            service_balance.Text = getBalance().ToString();
            accesibleServices.Clear();
            checkedListBox1.Items.Clear();
            loadList();
            checkedListBox2.Items.Clear();
            loadListForDelete();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Отметьте услуги для подключения.");
                return;
            }

            int totalCost = 0;
            for (int i = 0; i <= (checkedListBox1.Items.Count - 1); i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    //считаем, сколько денег нужно для подключения всех услуг
                    totalCost += getCostService(accesibleServices[i]);
                }
            }
            if (getBalance() < totalCost)
            {
                MessageBox.Show("Недостаточно средств для подключения всех услуг. Пожалуйста, пополните баланс или отмените выбор.");
                return;
            }

            for (int i = 0; i <= (checkedListBox1.Items.Count - 1); i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    OleDbCommand command = new OleDbCommand("connectService", cn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idAbonent", id_);
                    command.Parameters.AddWithValue("@idService", accesibleServices[i]);
                    command.ExecuteNonQuery();

                }
            }
            MessageBox.Show("Услуги успешно подключены.");
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

        public int getCostService(int idService)
        {
            OleDbCommand command = new OleDbCommand("showInfoAboutService", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idService", idService);
            OleDbDataReader reader = command.ExecuteReader();
            int cost = 0;
            while (reader.Read())
            {
                cost = reader.GetInt32(2);
            }
            return cost;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkedListBox2.CheckedItems.Count == 0)
            {
                MessageBox.Show("Отметьте услуги для удаления.");
                return;
            }

            for (int i = 0; i <= (checkedListBox2.Items.Count - 1); i++)
            {
                if (checkedListBox2.GetItemChecked(i))
                {
                    OleDbCommand command = new OleDbCommand("disconnectService", cn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@idAbonent", id_);
                    command.Parameters.AddWithValue("@idService", currentServices[i]);
                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("Услуги успешно отключены.");
            refresh();
        }


        private void menu_messages_newMessage_Click(object sender, EventArgs e)
        {
            CreateMessage createMessage = new CreateMessage(id_);
            Hide();
            createMessage.ShowDialog();
            
            refresh();
        }

        private void menu_tariff_Click(object sender, EventArgs e)
        {
            Tariff tariff = new Tariff(id_);
            Hide();
            tariff.ShowDialog();
            
            refresh();
        }

        private void menu_services_Click(object sender, EventArgs e)
        {
            Abonent_Services abonent_Services = new Abonent_Services(id_);
            Hide();
            abonent_Services.ShowDialog();
            
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

        private void menu_appeals_newAppeal_Click(object sender, EventArgs e)
        {
            CreateAppeal createAppeal = new CreateAppeal(id_);
            Hide();
            createAppeal.ShowDialog();
            
            refresh();
        }

        private void menu_appeals_showMyAppeals_Click(object sender, EventArgs e)
        {
            AbonentAppeals abonentAppeals = new AbonentAppeals(id_);
            Hide();
            abonentAppeals.ShowDialog();
            
            refresh();
        }

        private void menu_main_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void menu_balance_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance(id_);
            Hide();
            balance.ShowDialog();

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
