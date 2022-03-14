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
    public partial class OutgoingMessages : Form
    {
        public int id_;
        public OutgoingMessages(int id)
        {
            InitializeComponent();
            id_ = id;
            cn.Open();
            refresh();
        }

        public void refresh()
        {
            listOutgoing.Rows.Clear();
            loadList();
        }

        public void loadList()
        {
            OleDbCommand command = new OleDbCommand("showOutgoing", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idFrom", id_);
            OleDbDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[4]);

                data[data.Count - 1][0] = reader.GetInt32(0).ToString();
                data[data.Count - 1][1] = reader.GetString(1);
                data[data.Count - 1][2] = reader.GetString(2);
                data[data.Count - 1][3] = reader.GetDateTime(3).ToString().Substring(0, 10);
            }

            foreach (string[] s in data)
            {
                listOutgoing.Rows.Add(s);
            }
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
        private void menu_messages_newMessage_Click(object sender, EventArgs e)
        {
            CreateMessage createMessage = new CreateMessage(id_);
            Hide();
            createMessage.ShowDialog();
            
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
