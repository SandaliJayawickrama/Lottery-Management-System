using JProject.UI;
using JProject.UI.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JProject
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_Alogin_Click(object sender, EventArgs e)
        {
            //page that needed to be load next
            //AdLogin adLogin = new AdLogin();
            //adLogin.Show();
            this.Hide();
        }

        private void btn_Ologin_Click(object sender, EventArgs e)
        {
            //page that needed to be load next
            //OpLogin opLogin = new OpLogin();
            //opLogin.Show();
            this.Hide();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lblloggedIn.Text = Login.loggedIn;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsers user = new FrmUsers();
            user.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void purchaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            purchase.Show();
        }

        private void salesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Sales sales = new Sales();
            sales.Show();
        }

        private void purchaseReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Return_Purchase return_Purchase = new Return_Purchase();
            return_Purchase.Show();
        }

        private void purchaseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Instant_purchases instant_Purchases = new Instant_purchases();
            instant_Purchases.Show();
        }

        private void agentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agents agents = new Agents();
            agents.Show();
        }

        private void agentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Credit_Settle settle = new Credit_Settle();
            settle.Show();
        }

        private void agentListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Agent_List agent_List = new Agent_List();
            agent_List.Show();
        }

        private void addTicketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketsA tickets = new TicketsA();
            tickets.Show();
        }

        private void ticketListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ticket_List ticket_List = new Ticket_List();
            ticket_List.Show();
        }

        private void stockToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Stock_List stock_List = new Stock_List();
            stock_List.Show();
        }

        private void stockInstantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsStock_List insStock = new InsStock_List();
            insStock.Show();
        }

        private void salesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sales_Infor sales_Infor = new Sales_Infor();
            sales_Infor.Show();
        }

        private void purchaseListToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Purchase_Infor purchase_Infor = new Purchase_Infor();
            purchase_Infor.Show();
        }

        private void winToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void salesSummeryDailyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agents_Summery agSmmery = new Agents_Summery();
            agSmmery.Show();
        }

        private void monthlyBalancesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Monthly_Summery monthSummery = new Monthly_Summery();
            monthSummery.Show();
        }

        private void payableSettleNLBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payable_Settlement SettleNlb = new Payable_Settlement();
            SettleNlb.Show();
        }

       
    }
}
