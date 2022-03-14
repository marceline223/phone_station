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
    public partial class CreateAppeal : Form
    {
        public int id_ = 0;
        public CreateAppeal(int id)
        {
            InitializeComponent();
            cn.Open();
            id_ = id;
            refresh();
        }

        public void refresh()
        {
            appeal_text.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idStaff = findStaffForAppeal();
            string appealText = appeal_text.Text;
            if (appealText.Length == 0)
            {
                MessageBox.Show("Нельзя создать пустое обращение.");
                return;
            }

            OleDbCommand command = new OleDbCommand("createNewAppeal", cn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@idAbonent", id_);
            command.Parameters.AddWithValue("@idStaff", idStaff);
            command.Parameters.AddWithValue("@textAppeal", appealText);
            command.Parameters.AddWithValue("@date", DateTime.Today);

            command.ExecuteNonQuery();
            MessageBox.Show("Обращение успешно создано.");
        }

        public int findStaffForAppeal()
        {
            OleDbCommand command = new OleDbCommand("showStaffFreeForAppeal", cn);
            command.CommandType = CommandType.StoredProcedure;
            OleDbDataReader reader = command.ExecuteReader();
            int idStaff = -1;
            while (reader.Read())
            {
                idStaff = reader.GetInt32(0);
            }
            return idStaff;
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
        private void menu_appeals_showMyAppeals_Click(object sender, EventArgs e)
        {
            AbonentAppeals abonentAppeals = new AbonentAppeals(id_);
            Hide();
            abonentAppeals.ShowDialog();
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

        private void черныйСписокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BlackList blackList = new BlackList(id_);
            Hide();
            blackList.ShowDialog();

            refresh();
        }
    }
}
