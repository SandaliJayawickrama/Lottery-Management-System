using JProject.BLL;
using JProject.BLL.AdminBLL;
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
    class TicketsDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Select Data from Database
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM tickets";

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
        public bool Insert(ticketsA_BLL t)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT into tickets (ticket_code, ticket_name, ticket_type, ticket_Uprice, ticket_Bprice, t_description, added_date, added_by) VALUES (@ticket_code, @ticket_name, @ticket_type, @ticket_Uprice, @ticket_Bprice, @t_description, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ticket_code", t.ticket_code);
                cmd.Parameters.AddWithValue("@ticket_name", t.ticket_name);
                cmd.Parameters.AddWithValue("@ticket_type", t.ticket_type);
                cmd.Parameters.AddWithValue("@ticket_Uprice", t.ticket_Uprice);
                cmd.Parameters.AddWithValue("@ticket_Bprice", t.ticket_Bprice);
                cmd.Parameters.AddWithValue("@t_description", t.t_description);
                cmd.Parameters.AddWithValue("@added_date", t.added_date);
                cmd.Parameters.AddWithValue("@added_by", t.added_by);

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

        #region Update Data in Database
        public bool Update(ticketsA_BLL t)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "UPDATE tickets SET ticket_code=@ticket_code, ticket_name=@ticket_name, @ticket_type=@ticket_type, ticket_Uprice=@ticket_Uprice, ticket_Bprice=@ticket_Bprice, t_description=@t_description, added_date=@added_date, added_by=@added_by WHERE ticket_name=@ticket_name";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ticket_code", t.ticket_code);
                cmd.Parameters.AddWithValue("@ticket_name", t.ticket_name);
                cmd.Parameters.AddWithValue("@ticket_type", t.ticket_type);
                cmd.Parameters.AddWithValue("@ticket_Uprice", t.ticket_Uprice);
                cmd.Parameters.AddWithValue("@ticket_Bprice", t.ticket_Bprice);
                cmd.Parameters.AddWithValue("@t_description", t.t_description);
                cmd.Parameters.AddWithValue("@added_date", t.added_date);
                cmd.Parameters.AddWithValue("@added_by", t.added_by);

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

        #region Delete Data from Database
        public bool Delete(ticketsA_BLL t)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "DELETE FROM tickets WHERE ticket_name=@ticket_name";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ticket_name", t.ticket_name);
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

        #region Search Data from Database
        public DataTable Search(string keyword)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM tickets WHERE ticket_code LIKE '%" + keyword + "%' OR ticket_name LIKE '%" + keyword + "%' OR ticket_type LIKE '%" + keyword + "%' ";
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

        #region Search Ticket Name For Purchase Module
        public ticketsA_BLL SearchTicket_ForPuechase(string keyword)
        {
            ticketsA_BLL tPurchase = new ticketsA_BLL();

            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT ticket_name, ticket_type, ticket_Uprice FROM tickets WHERE ticket_name LIKE '%"+keyword+"%' ";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();

                //Pass the values from adapter to dt
                adapter.Fill(dt);

                //If we have any values on dt then set the values to ticketsA_BLL
                if (dt.Rows.Count > 0)
                {
                    tPurchase.ticket_name = dt.Rows[0]["ticket_name"].ToString();
                    tPurchase.ticket_type = dt.Rows[0]["ticket_type"].ToString();
                    tPurchase.ticket_Uprice = decimal.Parse(dt.Rows[0]["ticket_Uprice"].ToString());
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
            return tPurchase;
        }
        #endregion
    }
}
