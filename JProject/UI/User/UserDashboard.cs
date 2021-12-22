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

        private void purchaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void itemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agents agents = new Agents();
            agents.Show();
        }
    }
}
