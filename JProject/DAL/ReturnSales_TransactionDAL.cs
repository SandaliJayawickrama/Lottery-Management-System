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
    class ReturnSales_TransactionDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Insert ReturnSales_Transaction
        public bool InsertReturnSales_Transaction(ReturnSales_TransactionBLL rtTranBll, out int returnTransId)
        {
            bool isSuccess = false;
            returnTransId = -1;

            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "INSERT INTO returnSales_Transaction(SReturn_id, agent_name, agent_no, supplier, draw_date, total_qty, total_amount, added_by, added_date) VALUES (@SReturn_id, @agent_name, @agent_no, @supplier, @draw_date, @total_qty, @total_amount, @added_by, @added_date); SELECT @@IDENTITY; ";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@SReturn_id", rtTranBll.SReturn_id);
                cmd.Parameters.AddWithValue("@agent_no", rtTranBll.agent_no);
                cmd.Parameters.AddWithValue("@agent_name", rtTranBll.agent_name);
                cmd.Parameters.AddWithValue("@supplier", rtTranBll.supplier);
                cmd.Parameters.AddWithValue("@draw_date", rtTranBll.draw_date);
                cmd.Parameters.AddWithValue("@total_qty", rtTranBll.total_qty);
                cmd.Parameters.AddWithValue("@total_amount", rtTranBll.total_amount);
                cmd.Parameters.AddWithValue("@added_by", rtTranBll.added_by);
                cmd.Parameters.AddWithValue("@added_date", rtTranBll.added_date);

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


        #region Get last Row Sret_TransId Id From returnSales_Transaction Table to create salees_retId no
        public int GetLastSret_TransId()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            int poId = 0;

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT Sret_TransId FROM returnSales_Transaction WHERE Sret_TransId = (SELECT MAX(Sret_TransId) FROM returnSales_Transaction)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    poId = int.Parse(dt.Rows[0]["Sret_TransId"].ToString());
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
            return poId;
        }
        #endregion

        #region Create SReturn_id
        public string CreateSalesReturnId()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            string SRid = "";

            try
            {
                int MaxIdNo = GetLastSret_TransId();
                int CurrentIdNo = MaxIdNo + 1;
                var yr = DateTime.Now.Year;
                var mon = DateTime.Now.Month;
                var da = DateTime.Now.Day;

                SRid = "SRetNo-" + yr + "/" + mon + "/" + da + "-" + CurrentIdNo;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return SRid;
        }
        #endregion
    }
}
