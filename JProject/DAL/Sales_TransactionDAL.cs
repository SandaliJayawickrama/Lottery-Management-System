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

        #region Get last Row Sales Id From Sales_Transaction Table
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
    }
}
