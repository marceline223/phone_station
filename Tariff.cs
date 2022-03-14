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
    public partial class Tariff : Form
    {
        public int id_ = 0;
        public int balance_ = 0;
        public int id_tariff_ = 0;
        public List<int> tariffs_id = new List<int>(); 

        public Tariff(int id)
        {
            id_ = id;
            InitializeComponent();
            cn.Open();
            refresh();
        }

        public void refresh()
        {
            getBalance();
            getTariffId();
            chooseTariff.Items.Clear();
            loadComboBox();
            balance.Text = balance_.ToString();
            currentTariff.Text = getTariffName();
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

        public string getTariffName()
        {
            OleDbCommand command = new OleDbCommand("showinfoAboutTariff", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id_tariff", id_tariff_);
            OleDbDataReader reader = command.ExecuteReader();
            string s = "";
            while (reader.Read())
            {
                s = reader.GetString(0);
            }
            return s;
            
        }
        public int getTariffId()
        {
            OleDbCommand command = new OleDbCommand("showInfoAbonent", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idAbonent", id_);
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id_tariff_ = reader.GetInt32(6);
            }
            return id_tariff_;
        }

        public int getTariffCost(int idTariff)
        {
            OleDbCommand command = new OleDbCommand("showinfoAboutTariff", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id_tariff", idTariff);
            OleDbDataReader reader = command.ExecuteReader();
            int cost = 0;
            while (reader.Read())
            {
                cost = reader.GetInt32(2);
            }
            return cost;
        }

        public void loadComboBox()
        {
            OleDbCommand command = new OleDbCommand("showAvailibleTariff", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id_abonent", id_);

            OleDbDataReader reader = command.ExecuteReader();
            int id;
            while (reader.Read())
            {
                chooseTariff.Items.Add(reader.GetString(1));
                tariffs_id.Add(reader.GetInt32(0));
            }
        }

        private void Tariff_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "phoneStationDataSetTariff.Tariff". При необходимости она может быть перемещена или удалена.
            this.tariffTableAdapter.Fill(this.phoneStationDataSetTariff.Tariff);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "phoneStationDataSet.Tariff". При необходимости она может быть перемещена или удалена.
            //this.tariffTableAdapter.Fill(this.phoneStationDataSet.Tariff);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //перейти на тариф
            if (chooseTariff.SelectedItem == null)
            {
                MessageBox.Show("Для перехода выберите тариф.");
                return;
            }
            int newTariffId = tariffs_id[chooseTariff.SelectedIndex];
            int cost = getTariffCost(newTariffId);
            if (balance_ < cost)
            {
                MessageBox.Show("Недостаточно средств. Пополните баланс или выберите другой тариф.");
                return;
            }

            OleDbCommand command = new OleDbCommand("changeTariff", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idAbonent", id_);
            command.Parameters.AddWithValue("@idTariff", newTariffId);
            command.ExecuteNonQuery();
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
