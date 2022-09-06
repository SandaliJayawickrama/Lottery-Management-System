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
    class StockDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Insert New inventory to Stock For Purchasing Module
        public bool InsertStock(StockBLL stk)
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            bool isSuccess = false;

            try
            {
                string sql = "INSERT INTO stock (ticket_name, starting_Bcode, ending_Bcode, draw_no, draw_date, quantity, supplier) VALUES(@ticket_name, @starting_Bcode, @ending_Bcode, @draw_no, @draw_date, @quantity, @supplier)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ticket_name", stk.ticket_name);
                cmd.Parameters.AddWithValue("@starting_Bcode", stk.starting_Bcode);
                cmd.Parameters.AddWithValue("@ending_Bcode", stk.ending_Bcode);
                cmd.Parameters.AddWithValue("@draw_no", stk.draw_no);
                cmd.Parameters.AddWithValue("@draw_date", stk.draw_date);
                cmd.Parameters.AddWithValue("@quantity", stk.quantity);
                cmd.Parameters.AddWithValue("@supplier", stk.supplier);

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

       


        #region Get Current Inventory Balance From Relevent Column
        public decimal GetCurrentQuantity(string tName, string StBcode)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal Qty = 0;

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT quantity FROM stock WHERE ticket_name=@ticket_name AND starting_Bcode=@starting_Bcode";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ticket_name", tName);
                cmd.Parameters.AddWithValue("@starting_Bcode", StBcode);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Qty = decimal.Parse(dt.Rows[0]["quantity"].ToString());
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

            return Qty;
        }
        #endregion

        #region Get Stock Id
        public int GetStockId(string tName, string StBcode)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            int stkId = 0;
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT stk_id FROM stock WHERE ticket_name=@ticket_name AND starting_Bcode=@starting_Bcode";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ticket_name", tName);
                cmd.Parameters.AddWithValue("@starting_Bcode", StBcode);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();

                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    stkId = int.Parse(dt.Rows[0]["stk_id"].ToString());
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

            return stkId;
        }
        #endregion

        #region Update Stock Quantity
        public bool UpdateQtyAndStBcode(string tName, int stklId, string stBcode, decimal Qty)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE stock SET quantity=@quantity, starting_Bcode=@starting_Bcode WHERE ticket_name=@ticket_name AND stk_id=@stk_id";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@quantity", Qty);
                cmd.Parameters.AddWithValue("@ticket_name", tName);
                cmd.Parameters.AddWithValue("@starting_Bcode", stBcode);
                cmd.Parameters.AddWithValue("@stk_id", stklId);

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

        #region Delete tickets from Stock For Sales Module
        public bool DeleteStock(string tName, string stBcode)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "DELETE FROM stock WHERE ticket_name=@ticket_name AND starting_Bcode=@starting_Bcode";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ticket_name", tName);
                cmd.Parameters.AddWithValue("@starting_Bcode", stBcode);
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

        #region Decrease Stock Qty Or Delete Stock by Sales
        public bool UpdateOrDeleteStock(string StBcode, string tName, decimal Qty)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                decimal CurrentQty = GetCurrentQuantity(tName, StBcode);
                int StockId = GetStockId(tName, StBcode);

                if (CurrentQty > 0)
                {
                    //calculate new quantity
                    decimal NewQty = CurrentQty - Qty;

                    //calculate new starting barcode
                    decimal starBcode = decimal.Parse(StBcode);
                    decimal newStBcode = starBcode + Qty;
                    //convert new starting barcode into string
                    string NewStBarcode = newStBcode.ToString();

                    if (NewQty > 0)
                    {
                        isSuccess = UpdateQtyAndStBcode(tName, StockId, NewStBarcode, NewQty);
                    }
                    else if (NewQty < 0)
                    {
                        isSuccess = false;
                    }
                    else if (NewQty == 0)
                    {
                        isSuccess = DeleteStock(tName, StBcode);
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

        #region Select Stock for Sales stock Gridview
        public DataTable SelectAvailableStock(string tName, string drawNo)
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();
            DataTable filledDT = new DataTable();
            try
            {
                string sql = "SELECT * FROM stock WHERE ticket_name=@ticket_name AND draw_no=@draw_no";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ticket_name", tName);
                cmd.Parameters.AddWithValue("@draw_no", drawNo);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    filledDT = dt;
                    //stkId = int.Parse(dt.Rows[0]["stk_id"].ToString());
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

        #region Get Draw date for SalesFrm
        public DateTime GetDrawDate(string drawNo, string tikName)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            //DateTime? DrDate = null;
            DateTime DrDate = new DateTime();

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT draw_date FROM stock WHERE draw_no = @draw_no AND ticket_name=@ticket_name ";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@draw_no", drawNo);
                cmd.Parameters.AddWithValue("@ticket_name", tikName);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    DrDate = DateTime.Parse(dt.Rows[0]["draw_date"].ToString());
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

            return DrDate;
        }
        #endregion

        #region Get the Total(sum) Quantity
        public decimal GetCurrentTotalQty(string drawNo, string tName)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal total = 0;

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT sum(quantity) AS total FROM stock WHERE ticket_name=@ticket_name AND draw_no = @draw_no";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@draw_no", drawNo);
                cmd.Parameters.AddWithValue("@ticket_name", tName);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    total = decimal.Parse(dt.Rows[0]["total"].ToString());
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
            return total;
        }
        #endregion



           
        #region Select Today draw Dated Stock for Purchase Return
        public DataTable SelectTodayStock(string supplier)
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM stock WHERE draw_date = cast(getdate() as Date) AND supplier=@supplier";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@supplier", supplier);

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





        #region Select Stock for Stock List Gridview
        public DataTable SelectStockList()
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();
            DataTable filledDT = new DataTable();
            try
            {
                string sql = "SELECT stk_id, ticket_name, quantity, starting_Bcode, ending_Bcode, draw_no, draw_date, supplier FROM stock ";

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

        #region Search Stock in Database
        public DataTable SearchStock(string keyword)
        {
            //Create a Database connection
            SqlConnection conn = new SqlConnection(myconnstring);

            //Create a Data Table to hold the values temporaly
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT stk_id, ticket_name, quantity, starting_Bcode, ending_Bcode, draw_no, draw_date, supplier FROM stock WHERE ticket_name LIKE '%" + keyword + "%' OR draw_no LIKE '%" + keyword + "%' OR draw_date LIKE '%" + keyword + "%' OR supplier LIKE '%" + keyword + "%' ";

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
