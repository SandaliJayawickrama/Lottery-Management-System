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
    public partial class Agent_List : Form
    {
        public Agent_List()
        {
            InitializeComponent();
        }

        AgentDAL aDal = new AgentDAL();

        private void Agent_List_Load(object sender, EventArgs e)
        {
            //Display available inventories in Data Grid View
            DataTable dt = aDal.SelectAgentList();
            dgvAgentList.DataSource = dt;
        }

        private void txtSearchAgent_TextChanged(object sender, EventArgs e)
        {
            //get keyword from Text Box
            string keywords = txtSearchAgent.Text;
            if (keywords != null)
            {
                //Show User based on keyword
                DataTable dt = aDal.SearchAgentList(keywords);
                dgvAgentList.DataSource = dt;
            }
            else
            {
                //Show all users from the Database
                DataTable dt = aDal.Select();
                dgvAgentList.DataSource = dt;
            }
        }

        private void dgvAgentList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
