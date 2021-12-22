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
    class userDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Select Data From Database
        public DataTable Select() 
        {
            //static method to connect DBSystem.NullReferenceException
            SqlConnection conn = new SqlConnection(myconnstring);
            //Hold the data from DB
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM users";  //Sql Querry to get data from DB
                SqlCommand cmd = new SqlCommand(sql, conn);  //Executing command to execute sql quarry
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);  //get data from DB using cmd
                conn.Open();  //DB connection Open
                adapter.Fill(dt);  //fill data in dt, that data hold in adapter
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);  //Throw message if any error occurs
            }
            finally
            {
                conn.Close(); //close DB Connection
            }
            //return the value in DataTable
            return dt;
        }
        #endregion

        #region Insert Data in Database
        public bool Insert(userBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "INSERT INTO users (username, password, contactNo, user_type, added_by, added_date) VALUES (@username, @password, @contactNo, @user_type, @added_by, @added_date)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@contactNo", u.contact);
                cmd.Parameters.AddWithValue("@user_type", u.user_type);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                //If the querry is executed successfully then the value to rows will be greater than 0. else it will be less than 0
                if (rows > 0)
                {
                    //Querry is Successfull
                    isSuccess = true;
                }
                else
                {
                    //Querry is Failed
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
        #endregion

        #region Update Data in Database
        public bool Update(userBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "UPDATE users SET username=@username, password=@password, contactNo=@contactNo, user_type=@user_type, added_by=@added_by, added_date=@added_date WHERE username=@username";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@username", u.username);
                cmd.Parameters.AddWithValue("@password", u.password);
                cmd.Parameters.AddWithValue("@contactNo", u.contact);
                cmd.Parameters.AddWithValue("@user_type", u.user_type);
                cmd.Parameters.AddWithValue("@added_by", u.added_by);
                cmd.Parameters.AddWithValue("@added_date", u.added_date);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0) 
                {
                    //Update Successfull
                    isSuccess = true;
                }
                else
                {
                    //Update faild
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
        #endregion

        #region Delete Data From Database
        public bool Delete(userBLL u)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "DELETE FROM users WHERE username=@username";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@username", u.username);
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    //Querry Successfull
                    isSuccess = true;
                }
                else
                {
                    //Querry Faild
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
        #endregion

        #region Search user on Database by using keyword
        public DataTable Search(string keywords)
        {
            //static method to connect DBSystem.NullReferenceException
            SqlConnection conn = new SqlConnection(myconnstring);
            //Hold the data from DB
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM users WHERE username LIKE '%"+keywords+ "%' OR contactNo LIKE '%" + keywords + "%' ";  //Sql Querry to get data from DB
                SqlCommand cmd = new SqlCommand(sql, conn);  //Executing command to execute sql quarry
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);  //get data from DB using cmd
                conn.Open();  //DB connection Open
                adapter.Fill(dt);  //fill data in dt, that data hold in adapter
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);  //Throw message if any error occurs
            }
            finally
            {
                conn.Close(); //close DB Connection
            }
            //return the value in DataTable
            return dt;
        }
        #endregion

        #region Getting User name from Database
            //For added by column
            public userBLL GetUsername(string username)
        {
            userBLL u = new userBLL();
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT username FROM users WHERE username = '"+username+"'";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();

                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    u.username = dt.Rows[0]["username"].ToString();
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
            return u;
        }
        #endregion
    }
}
