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
    class PO_TransactionDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Get last Row PO Id From PO_transaction Table to create PO no
        public int GetLastPO_TransactionId()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            int poId = 0;

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT pot_id FROM po_transaction WHERE pot_id = (SELECT MAX(pot_id) FROM po_transaction)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    poId = int.Parse(dt.Rows[0]["pot_id"].ToString());
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

        #region Create Draw PO No
        public string CreatePurchaseOrderNo()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            string PoNo = "";

            try
            {
                int MaxIdNo = GetLastPO_TransactionId();
                int CurrentIdNo = MaxIdNo + 1;
                var yr = DateTime.Now.Year;
                var mon = DateTime.Now.Month;
                var da = DateTime.Now.Day;

                PoNo = "Drw/PO-" + yr + "/" + mon + "/" + da + "-" + CurrentIdNo;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return PoNo;
        }
        #endregion

        #region Insert PO_Transaction
        public bool Insert_PO_Transaction(PO_TransactionBLL pt, out int POtransactionId)
        {
            bool isSuccess = false;
            POtransactionId = -1;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO po_transaction (supplier, po_no, po_date, total_quantity, grand_total, added_date, added_by, category, cash, bank, scan_nlb, scan_dlb, return_nlb, return_dlb, credit, balance_qty, balance_amount) VALUES (@supplier, @po_no, @po_date, @total_quantity, @grand_total, @added_date, @added_by, @category, @cash, @bank, @scan_nlb, @scan_dlb, @return_nlb, @return_dlb, @credit, @balance_qty, @balance_amount); SELECT @@IDENTITY;";

                //Sql command to pass the value in sql query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passing the values to sql query using cmd                         
                cmd.Parameters.AddWithValue("@supplier", pt.supplier);
                cmd.Parameters.AddWithValue("@po_no", pt.po_no);
                cmd.Parameters.AddWithValue("@po_date", pt.po_date);
                cmd.Parameters.AddWithValue("@total_quantity", pt.total_quantity);
                cmd.Parameters.AddWithValue("@grand_total", pt.grand_total);
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
                cmd.Parameters.AddWithValue("@balance_qty", pt.balance_qty);
                cmd.Parameters.AddWithValue("@balance_amount", pt.balance_amount);
                

                //Open Database Connection
                conn.Open();

                //Execute the query
                object o = cmd.ExecuteScalar();

                //if the query is executed successfully then the value will not be null else it will be null
                if (o != null)
                {
                    POtransactionId = int.Parse(o.ToString());
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
                //close DB connection
                conn.Close();
            }
            return isSuccess;
        }
        #endregion




        #region Search PO No For Purchase Module
        public PO_TransactionBLL SearchPoNo_ForPurchase(string keyword)
        {
            PO_TransactionBLL purchase = new PO_TransactionBLL();

            SqlConnection conn = new SqlConnection(myconnstring);
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT po_no, po_date, supplier, category FROM po_transaction WHERE po_no LIKE '%" + keyword + "%' ";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                conn.Open();

                //Pass the values from adapter to dt
                adapter.Fill(dt);

                //If we have any values on dt then set the values to PO_TransactionBLL
                if (dt.Rows.Count > 0)
                {
                    purchase.po_no = dt.Rows[0]["po_no"].ToString();
                    purchase.po_date = DateTime.Parse(dt.Rows[0]["po_date"].ToString());
                    purchase.supplier = dt.Rows[0]["supplier"].ToString();
                    purchase.category = dt.Rows[0]["category"].ToString();
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
            return purchase;
        }
        #endregion
    }
}
