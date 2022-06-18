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
                string sql = "INSERT INTO agents (agent_name, agent_no, credit_Limit, description, added_date, added_by, agent_address, credit_amount) VALUES (@agent_name, @agent_no, @credit_Limit, @description, @added_date, @added_by, @agent_address, @credit_amount)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@agent_name", a.agent_name);
                cmd.Parameters.AddWithValue("@agent_no", a.agent_no);
                cmd.Parameters.AddWithValue("@credit_Limit", a.credit_Limit);
                cmd.Parameters.AddWithValue("@description", a.description);
                cmd.Parameters.AddWithValue("@added_date", a.added_date);
                cmd.Parameters.AddWithValue("@added_by", a.added_by);
                cmd.Parameters.AddWithValue("@agent_address", a.agent_address);
                cmd.Parameters.AddWithValue("@credit_amount", a.credit_amount);

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
                string sql = "UPDATE agents SET agent_name=@agent_name, agent_no=@agent_no, credit_Limit=@credit_Limit, description=@description, added_date=@added_date, added_by=@added_by, agent_address=@agent_address, credit_amount=@credit_amount WHERE id=@id";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@agent_name", a.agent_name);
                cmd.Parameters.AddWithValue("@agent_no", a.agent_no);
                cmd.Parameters.AddWithValue("@credit_Limit", a.credit_Limit);
                cmd.Parameters.AddWithValue("@description", a.description);
                cmd.Parameters.AddWithValue("added_date", a.added_date);
                cmd.Parameters.AddWithValue("@added_by", a.added_by);
                cmd.Parameters.AddWithValue("@id", a.id);
                cmd.Parameters.AddWithValue("@agent_address", a.agent_address);
                cmd.Parameters.AddWithValue("@credit_amount", a.credit_amount);
                

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
                string sql = "SELECT agent_name, agent_no FROM agents WHERE agent_name LIKE '%" + keyword + "%' OR agent_no LIKE '%" + keyword + "%' OR agent_address LIKE '%" + keyword + "%' ";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();

                //Pass the values from adapter to dt
                adapter.Fill(dt);

                //If we have any values on dt then set the values to ticketsA_BLL
                if (dt.Rows.Count > 0)
                {
                    agentSales.agent_name = dt.Rows[0]["agent_name"].ToString();
                    agentSales.agent_no = dt.Rows[0]["agent_no"].ToString();
                    //agentSales.agent_address = dt.Rows[0]["agent_address"].ToString();
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

        #region Get Credit Limit for Sales and credit settle Module
        public decimal GetCreditLimit(string Aname, string Ano)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal credit = 0;

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT credit_Limit FROM agents WHERE agent_name=@agent_name AND agent_no=@agent_no";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@agent_name", Aname);
                cmd.Parameters.AddWithValue("agent_no", Ano);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    credit = decimal.Parse(dt.Rows[0]["credit_Limit"].ToString());
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

            return credit;
        }
        #endregion

        #region Get Current Credit Amount for Sales and Credit settle Module
        public decimal GetCurrentCreditAmount(string Aname, string Ano)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal credit = 0;

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT credit_amount FROM agents WHERE agent_name=@agent_name AND agent_no=@agent_no";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@agent_name", Aname);
                cmd.Parameters.AddWithValue("agent_no", Ano);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    credit = decimal.Parse(dt.Rows[0]["credit_amount"].ToString());
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

            return credit;
        }
        #endregion

        #region Update Credit Amount for Sales and Settle Modules
        public bool UpdateCreditAmount(string Aname, string Ano, decimal CrAmount)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            bool isSuccess = false;

            try
            {
                string sql = "UPDATE agents SET credit_amount=@credit_amount WHERE agent_name=@agent_name AND agent_no=@agent_no";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@agent_name", Aname);
                cmd.Parameters.AddWithValue("@agent_no", Ano);
                cmd.Parameters.AddWithValue("@credit_amount", CrAmount);

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

        #region Increase Credit amount in Credit settle Module
        public bool IncreaseCreditAmount(string Aname, string Ano, decimal Newcredit) 
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            bool isSuccess = false;

            try
            {
                decimal CurrentAmount = GetCurrentCreditAmount(Aname, Ano);

                decimal totCredit = CurrentAmount + Newcredit;

                isSuccess = UpdateCreditAmount(Aname,Ano,totCredit);
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

        #region Decrease Credit amount in Credit Settleing
        public bool DecreaseCreditAmount(string Aname, string Ano, decimal settleAmount)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            bool isSuccess = false;

            try
            {
                decimal CurrentAmount = GetCurrentCreditAmount(Aname, Ano);

                decimal totCredit = CurrentAmount - settleAmount;
                if (totCredit < 0)
                {
                    isSuccess = false;
                }
                else
                {
                    isSuccess = UpdateCreditAmount(Aname, Ano, totCredit);
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

            return isSuccess;
        }
        #endregion

        #region Search Agent for credit Settlement
        public AgentBLL SearchAgent_ForCreditSettle(string keyword)
        {
            AgentBLL agentSettle = new AgentBLL();

            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT agent_name, agent_no, credit_Limit, credit_amount FROM agents WHERE agent_name LIKE '%" + keyword + "%' OR agent_no LIKE '%" + keyword + "%' OR agent_address LIKE '%" + keyword + "%' ";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();

                //Pass the values from adapter to dt
                adapter.Fill(dt);

                //If we have any values on dt then set the values to ticketsA_BLL
                if (dt.Rows.Count > 0)
                {
                    agentSettle.agent_name = dt.Rows[0]["agent_name"].ToString();
                    agentSettle.agent_no = dt.Rows[0]["agent_no"].ToString();
                    agentSettle.credit_Limit = decimal.Parse( dt.Rows[0]["credit_Limit"].ToString());
                    agentSettle.credit_amount = decimal.Parse(dt.Rows[0]["credit_amount"].ToString());
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
            return agentSettle;
        }
        #endregion




        #region Select Agent list for Agent List Gridview
        public DataTable SelectAgentList()
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();
            DataTable filledDT = new DataTable();
            try
            {
                string sql = "SELECT id, agent_name, agent_no, agent_address, credit_Limit, credit_amount, description FROM agents";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    filledDT = dt;
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
            return filledDT;
        }
        #endregion

        #region Search Agents in Database
        public DataTable SearchAgentList(string keyword)
        {
            //Create a Database connection
            SqlConnection conn = new SqlConnection(myconnstring);

            //Create a Data Table to hold the values temporaly
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT id, agent_name, agent_no, agent_address, credit_Limit, credit_amount, description FROM agents WHERE id LIKE '%" + keyword + "%' OR agent_name LIKE '%" + keyword + "%' OR agent_no LIKE '%" + keyword + "%' OR agent_address LIKE '%" + keyword + "%' ";

                SqlCommand cmd = new SqlCommand(sql, conn);

                //Create SqlData Adapter to execute the query
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                //Open Database connection
                conn.Open();

                //Transfer the data from SqlDataAdapter to DataTable
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


        #region Calculate Total credit Amount For Summery Sheet
        public decimal CalculateTotalCredit()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal TotCredit = 0;

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT coalesce(sum(credit_amount),0) AS totalCredit FROM agents";

                SqlCommand cmd = new SqlCommand(sql, conn);
              
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    TotCredit = decimal.Parse(dt.Rows[0]["totalCredit"].ToString());
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

            return TotCredit;
        }
        #endregion

    }
}
