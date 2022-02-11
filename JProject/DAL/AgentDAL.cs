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
                string sql = "INSERT INTO agents (agent_name, agent_no, credit_Limit, description, added_date, added_by, agent_address) VALUES (@agent_name, @agent_no, @credit_Limit, @description, @added_date, @added_by, @agent_address)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@agent_name", a.agent_name);
                cmd.Parameters.AddWithValue("@agent_no", a.agent_no);
                cmd.Parameters.AddWithValue("@credit_Limit", a.credit_Limit);
                cmd.Parameters.AddWithValue("@description", a.description);
                cmd.Parameters.AddWithValue("@added_date", a.added_date);
                cmd.Parameters.AddWithValue("@added_by", a.added_by);
                cmd.Parameters.AddWithValue("@agent_address", a.agent_address);

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
                string sql = "UPDATE agents SET agent_name=@agent_name, agent_no=@agent_no, credit_Limit=@credit_Limit, description=@description, added_date=@added_date, added_by=@added_by, agent_address=@agent_address WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@agent_name", a.agent_name);
                cmd.Parameters.AddWithValue("@agent_no", a.agent_no);
                cmd.Parameters.AddWithValue("@credit_Limit", a.credit_Limit);
                cmd.Parameters.AddWithValue("@description", a.description);
                cmd.Parameters.AddWithValue("added_date", a.added_date);
                cmd.Parameters.AddWithValue("@added_by", a.added_by);
                cmd.Parameters.AddWithValue("@id", a.id);
                cmd.Parameters.AddWithValue("@agent_address", a.agent_address);              

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
            //Create a Database connection
            SqlConnection conn = new SqlConnection(myconnstring);

            //Create a Data Table to hold the values temporaly
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM agents WHERE id LIKE '%"+keyword+"%' OR agent_name LIKE '%"+keyword+"%' OR agent_no LIKE '%"+keyword+ "%' OR agent_address LIKE '%" + keyword + "%' ";

                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create SqlData Adapter to execute the query
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Open Database connection
                conn.Open();

                //Transfer the data from SqlDataAdapter to DataTable
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

        #region Search Agent for Sales module
        public AgentBLL SearchAgent_ForSales(string keyword)
        {
            AgentBLL agentSales = new AgentBLL();

            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT agent_name, agent_no, agent_address FROM agents WHERE agent_name LIKE '%" + keyword + "%' OR agent_no LIKE '%" + keyword + "%' OR agent_address LIKE '%" + keyword + "%' ";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();

                //Pass the values from adapter to dt
                adapter.Fill(dt);

                //If we have any values on dt then set the values to ticketsA_BLL
                if (dt.Rows.Count > 0)
                {
                    agentSales.agent_name = dt.Rows[0]["agent_name"].ToString();
                    agentSales.agent_no = dt.Rows[0]["agent_no"].ToString();
                    agentSales.agent_address = dt.Rows[0]["agent_address"].ToString();
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
            return agentSales;
        }
        #endregion

    }
}
