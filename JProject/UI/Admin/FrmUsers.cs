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
    public partial class FrmUsers : Form
    {
        public FrmUsers()
        {
            InitializeComponent();
        }

        userBLL u = new userBLL();
        userDAL dal = new userDAL();


        private void comboUtype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //Getting Data from UI
            u.username = txtUN.Text;
            u.password = txtPSWD.Text;
            u.contact = txtPhone.Text;
            u.user_type = comboUtype.Text;
            u.added_date = DateTime.Now;

            //getting the user name of LoggedIn user
            string loggedUser = Login.loggedIn;
            userBLL usr = dal.GetUsername(loggedUser);

            u.added_by = usr.username;

            //Inserting Data into Database
            bool success = dal.Insert(u);

            if (success == true)
            {
                //Data succeefully Inserted
                MessageBox.Show("Successfully created new user");
                clear();
            }
            else
            {
                //Faild to Insert Data
                MessageBox.Show("Faild to add new user..!");
            }
            //Refreshing Data Grid View
            DataTable dt = dal.Select();
            dgvUser.DataSource = dt;
        }

        private void FrmUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvUser.DataSource = dt;
        }

        private void clear()
        {
            comboUtype.Text = "";
            txtUN.Text = "";
            txtPhone.Text = "";
            txtPSWD.Text = "";
        }

        private void dgvUser_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the index of particular row
            int rowIndex = e.RowIndex;
            txtUN.Text = dgvUser.Rows[rowIndex].Cells[0].Value.ToString();
            txtPSWD.Text = dgvUser.Rows[rowIndex].Cells[1].Value.ToString();
            txtPhone.Text = dgvUser.Rows[rowIndex].Cells[2].Value.ToString();
            comboUtype.Text = dgvUser.Rows[rowIndex].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get the Value from user UI
            u.user_type = comboUtype.Text;
            u.username = txtUN.Text;
            u.contact = txtPhone.Text;
            u.password = txtPSWD.Text;
            u.added_date = DateTime.Now;

            //getting the user name of LoggedIn user
            string loggedUser = Login.loggedIn;
            userBLL usr = dal.GetUsername(loggedUser);

            u.added_by = usr.username;

            //Updating Data into Database
            bool success = dal.Update(u);

            if (success == true)
            {
                //Data Updated successfully
                MessageBox.Show("Successfully Updated..");
                clear();
            }
            else
            {
                //Faild to Update user
                MessageBox.Show("Faild to Update..!");
            }
            //Refreshing Data Grid View
            DataTable dt = dal.Select();
            dgvUser.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Getting user name from the form
            u.username = txtUN.Text;

            bool success = dal.Delete(u);
            if (success == true)
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
            dgvUser.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //get keyword from Text Box
            string keywords = txtSearch.Text;
            if (keywords != null)
            {
                //Show User based on keyword
                DataTable dt = dal.Search(keywords);
                dgvUser.DataSource = dt;
            }
            else
            {
                //Show all users from the Database
                DataTable dt = dal.Select();
                dgvUser.DataSource = dt;
            }
        }
    }
}
