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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        loginBLL l = new loginBLL();
        loginDAL dal = new loginDAL();
        public static string loggedIn;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            l.username = txtusername.Text.Trim();
            l.password = txtpassword.Text.Trim();
            l.user_type = combotype.Text.Trim();

            //checking the login credentials
            bool success = dal.logincheck(l);
            if (success==true)
            {
                //Login Successfull
                MessageBox.Show("Login Successful..");
                loggedIn = l.username;
                //Open respective from based on user type
                switch (l.user_type)
                {
                    case "Admin":
                        {
                            //Display Admin Dashboard
                            AdminDashboard admin = new AdminDashboard();
                            admin.Show();
                            this.Hide();
                        }
                        break;
                    case "User":
                        {
                            //Display User Dashboard
                            UserDashboard user = new UserDashboard();
                            user.Show();
                            this.Hide();
                        }
                        break;
                    default:
                        {
                            //Display an Errorr message
                            MessageBox.Show("Invalid User type!");
                        }
                        break;
                }
            }
            else
            {
                //Login Faild
                MessageBox.Show("Login Faild..!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
