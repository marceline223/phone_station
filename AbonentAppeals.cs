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
    public partial class AbonentAppeals : Form
    {
        public int id_ = 0;
        public AbonentAppeals(int id)
        {
            InitializeComponent();
            cn.Open();
            id_ = id;
            refresh();
        }

        public void refresh()
        {
            listAppeals.Rows.Clear();
            loadList();
        }

        public void loadList()
        {
            OleDbCommand command = new OleDbCommand("showAppealsAbonent", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idabonent", id_);
            OleDbDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader.GetDateTime(1).ToString().Substring(0, 10);
                data[data.Count - 1][1] = reader.GetString(2);
                data[data.Count - 1][2] = reader.GetString(3);
                data[data.Count - 1][3] = reader.GetString(4);
                 
            }

            foreach (string[] s in data)
            {
                listAppeals.Rows.Add(s);
            }
        }

        private void menu_appeals_showMyAppeals_Click(object sender, EventArgs e)
        {
            AbonentAppeals abonentAppeals = new AbonentAppeals(id_);
            Hide();
            abonentAppeals.ShowDialog();
        }

        private void menu_messages_newMessage_Click(object sender, EventArgs e)
        {
            CreateMessage createMessage = new CreateMessage(id_);
            Hide();
            createMessage.ShowDialog();
        }

        private void menu_tariff_Click(object sender, EventArgs e)
        {
            Tariff tariff = new Tariff(id_);
            Hide();
            tariff.ShowDialog();
        }

        private void menu_services_Click(object sender, EventArgs e)
        {
            Abonent_Services abonent_Services = new Abonent_Services(id_);
            Hide();
            abonent_Services.ShowDialog();
        }

        private void menu_messages_incoming_Click(object sender, EventArgs e)
        {
            IncomingMessages incoming = new IncomingMessages(id_);
            Hide();
            incoming.ShowDialog();
        }

        private void menu_messages_outgoing_Click(object sender, EventArgs e)
        {
            OutgoingMessages outgoing = new OutgoingMessages(id_);
            Hide();
            outgoing.ShowDialog();
        }

        private void menu_balance_Click(object sender, EventArgs e)
        {
            Balance balance = new Balance(id_);
            Hide();
            balance.ShowDialog();
        }
        private void menu_appeals_newAppeal_Click(object sender, EventArgs e)
        {
            CreateAppeal createAppeal = new CreateAppeal(id_);
            Hide();
            createAppeal.ShowDialog();
        }

        private void menu_main_Click(object sender, EventArgs e)
        {
            Hide();
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
