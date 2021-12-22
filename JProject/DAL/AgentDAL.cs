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
    class AgentDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        
        #region Select Data from Database
            public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM agents";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion

        #region Insert Data into Database
            public bool Insert(AgentBLL a)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "INSERT INTO agents (agent_name, agent_no, credit_Limit, description, added_date, added_by) VALUES (@agent_name, @agent_no, @credit_Limit, @description, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@agent_name", a.agent_name);
                cmd.Parameters.AddWithValue("@agent_no", a.agent_no);
                cmd.Parameters.AddWithValue("@credit_Limit", a.credit_Limit);
                cmd.Parameters.AddWithValue("@description", a.description);
                cmd.Parameters.AddWithValue("added_date", a.added_date);
                cmd.Parameters.AddWithValue("@added_by", a.added_by);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
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
            public bool Update(AgentBLL a)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "UPDATE agents SET agent_name=@agent_name, agent_no=@agent_no, credit_Limit=@credit_Limit, description=@description, added_date=@added_date, added_by=@added_by WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@agent_name", a.agent_name);
                cmd.Parameters.AddWithValue("@agent_no", a.agent_no);
                cmd.Parameters.AddWithValue("@credit_Limit", a.credit_Limit);
                cmd.Parameters.AddWithValue("@description", a.description);
                cmd.Parameters.AddWithValue("added_date", a.added_date);
                cmd.Parameters.AddWithValue("@added_by", a.added_by);
                cmd.Parameters.AddWithValue("@id", a.id);

                conn.Open();

                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
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

        #region Delete Data from Database
            public bool Delete(AgentBLL a)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "DELETE FROM agents WHERE id=@id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", a.id);
                conn.Open();

                int rows = cmd.ExecuteNonQuery();

                if(rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
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

        #region Search Agents in Database
            public DataTable Search(string keyword)
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM agents WHERE id LIKE '%"+keyword+"%' OR agent_name LIKE '%"+keyword+"%' OR agent_no LIKE '%"+keyword+"%' ";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion

        #region Getting Username from Database
        public userBLL GetUsername(string username)
        {
            userBLL a = new userBLL();
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT username FROM users WHERE username = '" + username + "' ";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();

                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    a.username = dt.Rows[0]["username"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return a;
        }
        #endregion

    }
}
