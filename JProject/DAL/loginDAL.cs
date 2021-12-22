using JProject.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JProject.DAL
{
    class loginDAL
    {
        //Static string to connect Database
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        public bool logincheck(loginBLL l)
        {
            bool isSuccess = false;

            //Connecting to Database
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                //Sql querry to check Login
                string sql = "SELECT * FROM users WHERE username=@username AND password=@password AND user_type=@user_type";

                //create sql command to pass values
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@username", l.username);
                cmd.Parameters.AddWithValue("@password", l.password);
                cmd.Parameters.AddWithValue("@user_type", l.user_type);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //conn.Open();
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                //checking the rows in DataTable
                if (dt.Rows.Count > 0)
                {
                    //Login Successfull
                    isSuccess = true;
                }
                else
                {
                    //Login Failed
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }
    }
}
