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
    class Instant_StockDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Check ticket name exists or not and Get the Quantity
        public decimal CheckAndGetCurrentQty(string tickName)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal qty = 0;

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT quantity FROM instant_stock WHERE ticket_name = @ticket_name";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ticket_name", tickName);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    qty = decimal.Parse(dt.Rows[0]["quantity"].ToString());
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
            return qty;
        }
        #endregion

        #region Update Instant_Stock Quantity
        public bool UpdateInstantQuantity(string tickName, decimal Qty)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE instant_stock SET quantity=@quantity WHERE ticket_name=@ticket_name";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@quantity", Qty);
                cmd.Parameters.AddWithValue("@ticket_name", tickName);

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

        #region Insert New Ticket to Instant Stock
        public bool Insert_InsStock(Instant_StockBLL ins_stk)
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            bool isSuccess = false;

            try
            {
                string sql = "INSERT INTO instant_stock (ticket_name, supplier, quantity) VALUES(@ticket_name, @supplier, @quantity)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ticket_name", ins_stk.ticket_name);
                cmd.Parameters.AddWithValue("@supplier", ins_stk.supplier);
                cmd.Parameters.AddWithValue("@quantity", ins_stk.quantity);

                conn.Open();

                //declare integer variable and execute the query
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

        #region Delete Ticket from Instant Stock
        public bool Delete_InsStock(string tickName)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            bool isSuccess = false;

            try
            {
                string sql = "DELETE FROM instant_stock WHERE ticket_name=@ticket_name";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ticket_name", tickName);
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

        #region Increase Instant Stock Qty by Purchasing
        public bool Increase_InsStockQty(Instant_StockBLL s, string tickName, decimal NewQty)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            bool isSuccess = false;

            try
            {
                decimal CurrentQty = CheckAndGetCurrentQty(tickName);

                if (CurrentQty > 0)
                {
                    decimal TotalQty = CurrentQty + NewQty;
                    isSuccess = UpdateInstantQuantity(tickName, TotalQty);
                }
                else
                {
                    isSuccess = Insert_InsStock(s);
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

        #region Decrease Instant Stock Qty by Sales
        public bool Decrease_InsStockQty(string tickName, decimal NewQty)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            bool isSuccess = false;

            try
            {
                decimal CurrentQty = CheckAndGetCurrentQty(tickName);

                if (CurrentQty > 0)
                {
                    decimal TotalQty = CurrentQty - NewQty;

                    if (TotalQty > 0)
                    {
                        isSuccess = UpdateInstantQuantity(tickName, TotalQty);
                    }
                    else if (TotalQty < 0)
                    {
                        isSuccess = false;
                    }
                    else if (TotalQty == 0)
                    {
                        isSuccess = Delete_InsStock(tickName);
                    }
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



        #region Get Instant Stock Qty as Inventory for SalesFrm
        public decimal Get_InsInventoryBalance(string tickName, string supplier)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal qty = 0;

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT quantity FROM instant_stock WHERE ticket_name = @ticket_name AND supplier=@supplier ";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ticket_name", tickName);
                cmd.Parameters.AddWithValue("@supplier", supplier);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    qty = decimal.Parse(dt.Rows[0]["quantity"].ToString());
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
            return qty;
        }
        #endregion



        #region Select Stock for Ins-Stock List Gridview
        public DataTable SelectInsStocksList()
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();
            DataTable filledDT = new DataTable();
            try
            {
                string sql = "SELECT * FROM instant_stock";

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

        #region Search Ins-Stock in Database
        public DataTable SearchInsStock(string keyword)
        {
            //Create a Database connection
            SqlConnection conn = new SqlConnection(myconnstring);

            //Create a Data Table to hold the values temporaly
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM instant_stock WHERE ticket_name LIKE '%" + keyword + "%' OR supplier LIKE '%" + keyword + "%' ";

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

    }
}
