using JProject.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JProject.UI
{
    public partial class Ticket_List : Form
    {
        public Ticket_List()
        {
            InitializeComponent();
        }

        TicketsDAL ticket = new TicketsDAL();
        private void Ticket_List_Load(object sender, EventArgs e)
        {
            //Display available inventories in Data Grid View
            DataTable dt = ticket.SelectTicketList();
            dgvTicketList.DataSource = dt;
        }

        private void txtSearchTicket_TextChanged(object sender, EventArgs e)
        {
            //get keyword from Text Box
            string keywords = txtSearchTicket.Text;
            if (keywords != null)
            {
                //Show User based on keyword
                DataTable dt = ticket.SearchTicket(keywords);
                dgvTicketList.DataSource = dt;
            }
            else
            {
                //Show all users from the Database
                DataTable dt = ticket.SelectTicketList();
                dgvTicketList.DataSource = dt;
            }
        }
    }
}
