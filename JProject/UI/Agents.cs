using JProject.BLL;
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
    public partial class Agents : Form
    {
        public Agents()
        {
            InitializeComponent();
        }

        AgentBLL a = new AgentBLL();
        AgentDAL dal = new AgentDAL();
        userDAL Udal = new userDAL();

        private void lblType_Click(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            a.agent_name = txtAname.Text;
            a.agent_no = txtAno.Text;
            a.credit_Limit = decimal.Parse(txtCreditL.Text);
            a.description = txtDescrip.Text;
            a.added_date = DateTime.Now;
            a.agent_address = txtAaddress.Text;

            //getting the user name of LoggedIn user
            string loggedUser = Login.loggedIn;
            userBLL urs = Udal.GetUsername(loggedUser);

            a.added_by = urs.username;

            //Inserting Data into Database
            bool success = dal.Insert(a);

            if(success == true)
            {
                //Data succeefully Inserted
                MessageBox.Show("Successfully created new Agent");
                clear();
            }
            else
            {
                //Faild to Insert Data
                MessageBox.Show("Faild to create new Agent..!");
            }
            //Refreshing Data Grid View
            DataTable dt = dal.Select();
            dgvAgents.DataSource = dt;
        }

        private void Agents_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvAgents.DataSource = dt;
        }

        private void clear()
        {
            txtAId.Text = "";
            txtAname.Text = "";
            txtAno.Text = "";
            txtCreditL.Text = "";
            txtDescrip.Text = "";
            txtAaddress.Text = "";
        }

        private void dgvAgents_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the index of particular row
            int rowIndex = e.RowIndex;

            txtAId.Text = dgvAgents.Rows[rowIndex].Cells[0].Value.ToString();
            txtAname.Text = dgvAgents.Rows[rowIndex].Cells[1].Value.ToString();
            txtAno.Text = dgvAgents.Rows[rowIndex].Cells[2].Value.ToString();           
            txtCreditL.Text = dgvAgents.Rows[rowIndex].Cells[3].Value.ToString();
            txtDescrip.Text = dgvAgents.Rows[rowIndex].Cells[4].Value.ToString();
            txtAaddress.Text = dgvAgents.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void dgvAgents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvAgents_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //get the Value from user UI
            a.id = Convert.ToInt32(txtAId.Text);
            a.agent_name = txtAname.Text;
            a.agent_no = txtAno.Text;
            a.credit_Limit = decimal.Parse(txtCreditL.Text);
            a.description = txtDescrip.Text;
            a.added_date = DateTime.Now;
            a.agent_address = txtAaddress.Text;

            //getting the user name of LoggedIn user
            string loggedUser = Login.loggedIn;
            userBLL usr = Udal.GetUsername(loggedUser);

            a.added_by = usr.username;

            //Updating Data into Database
            bool success = dal.Update(a);

            if(success == true)
            {
                //Data Updated successfully
                MessageBox.Show("Successfully Updated..");
                clear();
            }
            else
            {
                //Faild to Update agent
                MessageBox.Show("Faild to Update..!");
            }

            //Refreshing Data Grid View
            DataTable dt = dal.Select();
            dgvAgents.DataSource = dt;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Getting Agent Id from the form
            a.id = Convert.ToInt32(txtAId.Text);

            bool success = dal.Delete(a);
            if(success == true)
            {
                //Deleted successfully
                MessageBox.Show("Successfully Deleted");
                clear();
            }
            else
            {
                MessageBox.Show("Faild to Delete");
            }

            //Refreshing Data Grid View
            DataTable dt = dal.Select();
            dgvAgents.DataSource = dt;
        }
        
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //get keyword from Text Box
            string keywords = txtSearch.Text;
            if (keywords != null)
            {
                //Show User based on keyword
                DataTable dt = dal.Search(keywords);
                dgvAgents.DataSource = dt;
            }
            else
            {
                //Show all users from the Database
                DataTable dt = dal.Select();
                dgvAgents.DataSource = dt;
            }
        }

        private void txtCreditL_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }


    }
}
