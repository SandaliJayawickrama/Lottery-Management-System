using JProject.UI.Admin;
using JProject.UI.User;
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
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            lblloggedIn.Text = Login.loggedIn;
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {            
        }

        
        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        { 
        }       

        private void purchaseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Instant_purchases instant_Purchases = new Instant_purchases();
            instant_Purchases.Show();
        }

        private void addAgentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agents agents = new Agents();
            agents.Show();
        }

        private void creditSettleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Credit_Settle credit_Settle = new Credit_Settle();
            credit_Settle.Show();
        }

        private void agentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agent_List agent_List = new Agent_List();
            agent_List.Show();
        }

        private void addNewTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketsU ticketsU = new TicketsU();
            ticketsU.Show();
        }

        private void updateTicketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketsA tickets = new TicketsA();
            tickets.Show();
        }

        private void ticketListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ticket_List ticket_List = new Ticket_List();
            ticket_List.Show();
        }

        private void purchaseListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Purchase_Infor purchase_Infor = new Purchase_Infor();
            purchase_Infor.Show();
        }

        private void salesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
        }

        private void salesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales_Infor sales_Infor = new Sales_Infor();
            sales_Infor.Show();
        }

        private void purchaseReturnsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return_Purchase return_Purchase = new Return_Purchase();
            return_Purchase.Show();
        }

        private void salesSummeryDailyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agents_Summery agSmmery = new Agents_Summery();
            agSmmery.Show();
        }

        private void stockDrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stock_List stock_List = new Stock_List();
            stock_List.Show();
        }

        private void stockInstantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsStock_List insStock = new InsStock_List();
            insStock.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createNewDrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase_Order purchase_order = new Purchase_Order();
            purchase_order.Show();
        }

        private void createNewInstantToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void drawInstantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Purchase purchaseIn = new Purchase();
            purchaseIn.Show();
        }
    }
}
