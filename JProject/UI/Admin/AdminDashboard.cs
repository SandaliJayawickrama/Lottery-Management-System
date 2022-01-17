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
            Agents agents = new Agents();
            agents.Show();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketsA tickets = new TicketsA();
            tickets.Show();
        }

        private void purchaseToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            purchase.Show();
        }
    }
}
