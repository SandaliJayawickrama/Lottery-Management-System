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
    class Purchase_TransactionDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Insert Purchase_Transaction
        public bool Insert_Puechase_Transaction(Purchase_TransactionBLL pt, out int PtransactionId)
        {
            bool isSuccess = false;
            PtransactionId = -1;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO purchase_transaction (inv_no, supplier, total_quantity, grand_total, inv_date, added_date, added_by, category, cash, bank, scan_nlb, scan_dlb, return_nlb, return_dlb, credit) VALUES (@inv_no, @supplier, @total_quantity, @grand_total, @inv_date, @added_date, @added_by, @category, @cash, @bank, @scan_nlb, @scan_dlb, @return_nlb, @return_dlb, @credit); SELECT @@IDENTITY;";
          
                //Sql command to pass the value in sql query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passing the values to sql query using cmd                         
                cmd.Parameters.AddWithValue("@inv_no", pt.inv_no);              
                cmd.Parameters.AddWithValue("@supplier", pt.supplier);
                cmd.Parameters.AddWithValue("@total_quantity", pt.total_quantity);
                cmd.Parameters.AddWithValue("@grand_total", pt.grand_total);
                cmd.Parameters.AddWithValue("@inv_date", pt.inv_date);
                cmd.Parameters.AddWithValue("@added_date", pt.added_date);
                cmd.Parameters.AddWithValue("@added_by", pt.added_by);
                cmd.Parameters.AddWithValue("@category", pt.category);
                cmd.Parameters.AddWithValue("@cash", pt.cash);
                cmd.Parameters.AddWithValue("@bank", pt.bank);
                cmd.Parameters.AddWithValue("@scan_nlb", pt.scan_nlb);
                cmd.Parameters.AddWithValue("@scan_dlb", pt.scan_dlb);
                cmd.Parameters.AddWithValue("@return_nlb", pt.return_nlb);
                cmd.Parameters.AddWithValue("@return_dlb", pt.return_dlb);
                cmd.Parameters.AddWithValue("@credit", pt.credit);

                //Open Database Connection
                conn.Open();

                //Execute the query
                object o = cmd.ExecuteScalar();

                //if the query is executed successfully then the value will not be null else it will be null
                if(o!=null)
                {
                    PtransactionId = int.Parse(o.ToString());
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
                //close DB connection
                conn.Close();
            }
            return isSuccess;
        }
        #endregion

        #region Select Puechses for Purchse List Gridview
        public DataTable SelectPurchaseList()
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();
            DataTable filledDT = new DataTable();
            try
            {
                string sql = "SELECT pt_id, supplier, inv_no, inv_date, total_quantity, grand_total, category, added_date FROM purchase_transaction";

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

        #region Search Purchases in Database
        public DataTable SearchPurchases(string keyword)
        {
            //Create a Database connection
            SqlConnection conn = new SqlConnection(myconnstring);

            //Create a Data Table to hold the values temporaly
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT pt_id, supplier, inv_no, inv_date, total_quantity, grand_total, category, added_date FROM purchase_transaction WHERE supplier LIKE '%" + keyword + "%' OR category LIKE '%" + keyword + "%' OR category LIKE '%" + keyword + "%' ";

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

        


        #region Calculate Total Daily Purchase Amount For Summery Sheet
        public decimal CalculateDailyPurchses(DateTime givenDate)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal TotCredit = 0;

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT coalesce(sum(grand_total),0) AS totalpurchase FROM purchase_transaction WHERE added_date = '" + givenDate + "' ";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    TotCredit = decimal.Parse(dt.Rows[0]["totalpurchase"].ToString());
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




        #region Get the Total(sum) value of Monthly Purchase Amount
        public decimal GetMonthlyPurchaseAmount(int month, int year)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal total = 0;

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT coalesce(SUM(grand_total),0) as total FROM purchase_transaction WHERE month(inv_date)=@month AND YEAR(inv_date)=@year ";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@year", year);

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

        #region Get the Total(sum) value of Monthly Credit Purchase Amount
        public decimal GetMonthlyCreditPurchaseAmount(int month, int year)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal total = 0;

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT coalesce(SUM(credit),0) as credittotal FROM purchase_transaction WHERE month(inv_date)=@month AND YEAR(inv_date)=@year ";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@year", year);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    total = decimal.Parse(dt.Rows[0]["credittotal"].ToString());
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

        #region Get the Total(sum) value of Monthly Bank Purchase Amount
        public decimal GetMonthlyBankPurchaseAmount(int month, int year)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal total = 0;

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT coalesce(SUM(bank),0) as banktotal FROM purchase_transaction WHERE month(inv_date)=@month AND YEAR(inv_date)=@year ";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@year", year);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    total = decimal.Parse(dt.Rows[0]["banktotal"].ToString());
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

        #region Get the Total(sum) value of Monthly Cash Purchase Amount
        public decimal GetMonthlyCashPurchaseAmount(int month, int year)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal total = 0;

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT coalesce(SUM(cash),0) as cashtotal FROM purchase_transaction WHERE month(inv_date)=@month AND YEAR(inv_date)=@year ";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@year", year);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();

                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    total = decimal.Parse(dt.Rows[0]["cashtotal"].ToString());
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

        #region Get the Total(sum) value of Monthly NLB win Purchase 
        public decimal GetMonthlyNlbWinPurchaseAmount(int month, int year)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal total = 0;

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT coalesce(SUM(scan_nlb),0) as total FROM purchase_transaction WHERE month(inv_date)=@month AND YEAR(inv_date)=@year ";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@year", year);

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

        #region Get the Total(sum) value of Monthly DLB win Purchase 
        public decimal GetMonthlyDlbWinPurchaseAmount(int month, int year)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal total = 0;

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT coalesce(SUM(scan_dlb),0) as total FROM purchase_transaction WHERE month(inv_date)=@month AND YEAR(inv_date)=@year ";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@year", year);

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

        #region Get Total Cash and Bank Purchases
        public decimal GetTotalCashBankWinPurchases(int month, int year)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal total = 0;

            decimal cash = GetMonthlyCashPurchaseAmount(month,year);
            decimal bank = GetMonthlyBankPurchaseAmount(month, year);
            decimal NlbWin = GetMonthlyNlbWinPurchaseAmount(month, year);
            decimal DlbWin = GetMonthlyDlbWinPurchaseAmount(month, year);

            total = cash + bank + NlbWin + DlbWin;

            return total;
        }
        #endregion

        #region Get the Total(sum) value of Monthly Purchase against NLB Returns 
        public decimal GetMonthlyNlbReturnPurchaseAmount(int month, int year)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal total = 0;

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT coalesce(SUM(return_nlb),0) as total FROM purchase_transaction WHERE month(inv_date)=@month AND YEAR(inv_date)=@year ";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@year", year);

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

        #region Get the Total(sum) value of Monthly Purchase against DLB Returns 
        public decimal GetMonthlyDlbReturnPurchaseAmount(int month, int year)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal total = 0;

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT coalesce(SUM(return_dlb),0) as total FROM purchase_transaction WHERE month(inv_date)=@month AND YEAR(inv_date)=@year ";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@month", month);
                cmd.Parameters.AddWithValue("@year", year);

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

        #region Get Total NLB DLB return Purchases
        public decimal GetTotalReturnPurchases(int month, int year)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal total = 0;

            decimal nlb = GetMonthlyNlbReturnPurchaseAmount(month, year);
            decimal dlb = GetMonthlyDlbReturnPurchaseAmount(month, year);
          
            total = nlb + dlb;

            return total;
        }
        #endregion



    }
}
