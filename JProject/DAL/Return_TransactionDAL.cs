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
    class Return_TransactionDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Insert Sales_Transaction
        public bool InsertReturnTransaction(Return_TransactionBLL rtTranBll, out int returnTransId)
        {
            bool isSuccess = false;
            returnTransId = -1;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "INSERT INTO return_Transaction(supplier, tot_quantity, tot_amount, agent_name, added_by, added_date) VALUES (@supplier, @tot_quantity, @tot_amount, @agent_name, @added_by, @added_date); SELECT @@IDENTITY; ";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@supplier", rtTranBll.supplier);
                cmd.Parameters.AddWithValue("@tot_quantity", rtTranBll.tot_quantity);
                cmd.Parameters.AddWithValue("@tot_amount", rtTranBll.tot_amount);
                cmd.Parameters.AddWithValue("@agent_name", rtTranBll.agent_name);
                cmd.Parameters.AddWithValue("@added_date", rtTranBll.added_date);
                cmd.Parameters.AddWithValue("@added_by", rtTranBll.added_by);

                conn.Open();

                object o = cmd.ExecuteScalar();

                //if the query is executed successfully then the value will not be null else it will be null
                if (o != null)
                {
                    returnTransId = int.Parse(o.ToString());
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


        #region Get the Total(sum) value of Monthly Return Amount
        public decimal GetMonthlyReturnAmount(int month, int year)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal total = 0;

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT coalesce(SUM(tot_amount),0) as total FROM return_Transaction WHERE month(added_date)=@month AND YEAR(added_date)=@year ";

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
    }
}
