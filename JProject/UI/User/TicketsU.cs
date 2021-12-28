using JProject.BLL;
using JProject.BLL.AdminBLL;
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

namespace JProject.UI.User
{
    public partial class TicketsU : Form
    {
        public TicketsU()
        {
            InitializeComponent();
        }

        ticketsA_BLL t = new ticketsA_BLL();
        TicketsDAL dal = new TicketsDAL();

        private void TicketsU_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dgvTicketsU.DataSource = dt;
        }

        private void clear()
        {
            txtTcode.Text = "";
            txtTname.Text = "";
            cmbType.Text = "";
            txtUprice.Text = "";
            txtBprice.Text = "";
            txtDes.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            t.ticket_code = txtTcode.Text;
            t.ticket_name = txtTname.Text;
            t.ticket_type = cmbType.Text;
            t.ticket_Uprice = decimal.Parse(txtUprice.Text);
            t.ticket_Bprice = decimal.Parse(txtBprice.Text);
            t.t_description = txtDes.Text;
            t.added_date = DateTime.Now;

            //getting the user name of LoggedIn user
            string loggedUser = Login.loggedIn;
            userBLL urs = dal.GetUsername(loggedUser);

            t.added_by = urs.username;

            //Inserting Data into Database
            bool success = dal.Insert(t);

            if (success == true)
            {
                //Data succeefully Inserted
                MessageBox.Show("Successfully created a new ticket");
                clear();
            }
            else
            {
                //Faild to Insert Data
                MessageBox.Show("Faild to create a new ticket..!");
            }
            //Refreshing Data Grid View
            DataTable dt = dal.Select();
            dgvTicketsU.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //get keyword from Text Box
            string keywords = txtSearch.Text;
            if (keywords != null)
            {
                //Show User based on keyword
                DataTable dt = dal.Search(keywords);
                dgvTicketsU.DataSource = dt;
            }
            else
            {
                //Show all users from the Database
                DataTable dt = dal.Select();
                dgvTicketsU.DataSource = dt;
            }
        }

        private void txtUprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtBprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
