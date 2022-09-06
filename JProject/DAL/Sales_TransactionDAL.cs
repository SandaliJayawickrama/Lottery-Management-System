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
    class Sales_TransactionDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Get last Row Sales Id From Sales_Transaction Table to create SalesId
        public int GetLastSales_TransactionId()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            int sid = 0;

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT st_id FROM sales_transaction WHERE st_id = (SELECT MAX(st_id) FROM sales_transaction)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    sid = int.Parse(dt.Rows[0]["st_id"].ToString());
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
            return sid;
        }
        #endregion

        #region Create Sales Invoice No
        public string CreateSalesInvNo()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            string stinvNo = "";

            try
            {
                int MaxIdNo = GetLastSales_TransactionId();
                int CurrentIdNo = MaxIdNo + 1;
                var yr = DateTime.Now.Year;

                stinvNo = "SalesInv-" + yr + "-" + CurrentIdNo;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return stinvNo;
        }
        #endregion

        #region Insert Sales_Transaction
        public bool InsertSalesTransaction(Sales_TransactionBLL stBll, out int salesTransId)
        {
            bool isSuccess = false;
            salesTransId = -1;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "INSERT INTO sales_transaction (inv_no, agent_name, agent_no, total_qty, total_billAmount, cash, winings_nlb, winings_dlb, return_nlb, return_dlb, credits, added_date, added_by, free_nlb, free_dlb) VALUES (@inv_no, @agent_name, @agent_no, @total_qty, @total_billAmount, @cash, @winings_nlb, @winings_dlb, @return_nlb, @return_dlb, @credits, @added_date, @added_by, @free_nlb, @free_dlb); SELECT @@IDENTITY; ";

                SqlCommand cmd = new SqlCommand(sql,conn);

                cmd.Parameters.AddWithValue("@inv_no", stBll.inv_no);
                cmd.Parameters.AddWithValue("@agent_name", stBll.agent_name);
                cmd.Parameters.AddWithValue("@agent_no", stBll.agent_no);
                cmd.Parameters.AddWithValue("@total_qty", stBll.total_qty);
                cmd.Parameters.AddWithValue("@total_billAmount", stBll.total_billAmount);
                cmd.Parameters.AddWithValue("@cash", stBll.cash);
                cmd.Parameters.AddWithValue("@winings_nlb", stBll.winings_nlb);
                cmd.Parameters.AddWithValue("@winings_dlb", stBll.winings_dlb);
                cmd.Parameters.AddWithValue("@return_nlb", stBll.return_nlb);
                cmd.Parameters.AddWithValue("@return_dlb", stBll.return_dlb);
                cmd.Parameters.AddWithValue("@credits", stBll.credits);
                cmd.Parameters.AddWithValue("@added_date", stBll.added_date);
                cmd.Parameters.AddWithValue("@added_by", stBll.added_by);
                cmd.Parameters.AddWithValue("@free_nlb", stBll.free_nlb);
                cmd.Parameters.AddWithValue("@free_dlb", stBll.free_dlb);

                conn.Open();

                object o = cmd.ExecuteScalar();

                //if the query is executed successfully then the value will not be null else it will be null
                if (o != null)
                {
                    salesTransId = int.Parse(o.ToString());
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



        #region Select Sales list for SalesList Gridview
        public DataTable SelectSalesList()
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();
            DataTable filledDT = new DataTable();
            try
            {
                string sql = "SELECT st_id, inv_no, agent_name, agent_no, total_qty, total_billAmount, added_date FROM sales_transaction";

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

        #region Search Sales in Database
        public DataTable SearchSales(string keyword)
        {
            //Create a Database connection
            SqlConnection conn = new SqlConnection(myconnstring);

            //Create a Data Table to hold the values temporaly
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT st_id, inv_no, agent_name, agent_no, total_qty, total_billAmount, added_date FROM sales_transaction WHERE agent_name LIKE '%" + keyword + "%' OR inv_no LIKE '%" + keyword + "%' OR added_date LIKE '%" + keyword + "%' ";

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



        #region Getting Sales Transaction details For Agent Summery
        /*public Sales_TransactionBLL GetSalesTransForAgentSummery(string givenDate)
        {
            Sales_TransactionBLL stBll = new Sales_TransactionBLL();
            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT agent_name, agent_no, total_billAmount, cash, winings_nlb, winings_dlb, return_nlb, return_dlb, free_nlb, free_dlb, credits FROM sales_transaction WHERE agent_name = '" + givenDate + "' ";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();

                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    stBll.agent_name = dt.Rows[0]["agent_name"].ToString();
                    stBll.agent_no = dt.Rows[0]["agent_no"].ToString();
                    stBll.total_billAmount = decimal.Parse(dt.Rows[0]["total_billAmount"].ToString());
                    stBll.cash = decimal.Parse(dt.Rows[0]["cash"].ToString());
                    stBll.winings_nlb = decimal.Parse(dt.Rows[0]["winings_nlb"].ToString());
                    stBll.winings_dlb = decimal.Parse(dt.Rows[0]["winings_dlb"].ToString());
                    stBll.return_nlb = decimal.Parse(dt.Rows[0]["return_nlb"].ToString());
                    stBll.return_dlb = decimal.Parse(dt.Rows[0]["return_dlb"].ToString());
                    stBll.credits = decimal.Parse(dt.Rows[0]["free_nlb"].ToString());
                    stBll.free_nlb = decimal.Parse(dt.Rows[0]["free_dlb"].ToString());
                    stBll.free_dlb = decimal.Parse(dt.Rows[0]["credits"].ToString());
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
            return stBll;
        }*/
        #endregion

        #region Select Sales list for SalesList Gridview Agent Summery
        public DataTable SelectSalesTransForAgentSummery(DateTime givenDate)
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();
            DataTable filledDT = new DataTable();
            try
            {
                string sql = "SELECT s.agent_name, s.agent_no, s.total_billAmount, s.cash, s.winings_nlb, s.winings_dlb, s.return_nlb, s.return_dlb, s.free_nlb, s.free_dlb, s.credits, a.credit_amount FROM sales_transaction s, agents a WHERE s.agent_name=a.agent_name AND s.added_date = '" + givenDate + "' ";

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



        #region Get the Total(sum) value of Monthly Sales Amount
        public decimal GetMonthlySalesAmount(int month, int year)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal total = 0;

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT coalesce(SUM(total_billAmount),0) as total FROM sales_transaction WHERE month(added_date)=@month AND YEAR(added_date)=@year ";

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

        #region Get the Total(sum) value of Monthly Cash Sales Amount
        public decimal GetMonthlyCashSalesAmount(int month, int year)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal total = 0;

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT coalesce(SUM(cash),0) as total FROM sales_transaction WHERE month(added_date)=@month AND YEAR(added_date)=@year ";

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

        #region Get the Total(sum) value of Monthly Credit Sales Amount
        public decimal GetMonthlyCreditSalesAmount(int month, int year)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal total = 0;

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT coalesce(SUM(credits),0) as total FROM sales_transaction WHERE month(added_date)=@month AND YEAR(added_date)=@year ";

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

        #region Get the Total(sum) value of Monthly Nlb Win Sales Amount
        public decimal GetMonthlyNlbWinSalesAmount(int month, int year)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal total = 0;

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT coalesce(SUM(winings_nlb),0) as total FROM sales_transaction WHERE month(added_date)=@month AND YEAR(added_date)=@year ";

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

        #region Get the Total(sum) value of Monthly Dlb Win Sales Amount
        public decimal GetMonthlyDlbWinSalesAmount(int month, int year)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal total = 0;

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT coalesce(SUM(winings_dlb),0) as total FROM sales_transaction WHERE month(added_date)=@month AND YEAR(added_date)=@year ";

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

        #region Get Total Cash and Win sales
        public decimal GetTotalCashBankWinSales(int month, int year)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal total = 0;

            decimal cash = GetMonthlyCashSalesAmount(month, year);
            decimal Nlbwin = GetMonthlyNlbWinSalesAmount(month, year);
            decimal Dlbwin = GetMonthlyDlbWinSalesAmount(month, year);


            total = cash + Nlbwin + Dlbwin;

            return total;
        }
        #endregion

        #region Get the Total(sum) value of Monthly Nlb Return Sales Amount
        public decimal GetMonthlyNlbRetSalesAmount(int month, int year)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal total = 0;

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT coalesce(SUM(return_nlb),0) as total FROM sales_transaction WHERE month(added_date)=@month AND YEAR(added_date)=@year ";

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

        #region Get the Total(sum) value of Monthly Dlb Return Sales Amount
        public decimal GetMonthlyDlbRetSalesAmount(int month, int year)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal total = 0;

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT coalesce(SUM(return_dlb),0) as total FROM sales_transaction WHERE month(added_date)=@month AND YEAR(added_date)=@year ";

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

        #region Get Total Nlb, Dlb Return sales
        public decimal GetTotalReturnSales(int month, int year)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal total = 0;

            decimal NlbRet = GetMonthlyNlbRetSalesAmount(month, year);
            decimal DlbRet = GetMonthlyDlbRetSalesAmount(month, year);

            total = NlbRet + DlbRet;

            return total;
        }
        #endregion





        
    }
}
