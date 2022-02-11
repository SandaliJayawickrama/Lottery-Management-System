using JProject.BLL;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JProject.DAL
{
    class Instant_PurchasesDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Insert Method for Instant Purchase
        public bool Insert_InstantPurchases(Instant_PurchasesBLL ins_pur)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "INSERT INTO instant_purchases(ticket_name, supplier, unit_price, quantity, line_total, inv_no, inv_date, added_date, added_by) VALUES (@ticket_name, @supplier, @unit_price, @quantity, @line_total, @inv_no, @inv_date, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ticket_name", ins_pur.ticket_name);
                cmd.Parameters.AddWithValue("@supplier", ins_pur.supplier);
                cmd.Parameters.AddWithValue("@unit_price", ins_pur.unit_price);
                cmd.Parameters.AddWithValue("@quantity", ins_pur.quantity);
                cmd.Parameters.AddWithValue("@line_total", ins_pur.line_total);
                cmd.Parameters.AddWithValue("@inv_no", ins_pur.inv_no);
                cmd.Parameters.AddWithValue("@inv_date", ins_pur.inv_date);
                cmd.Parameters.AddWithValue("@added_date", ins_pur.added_date);
                cmd.Parameters.AddWithValue("@added_by", ins_pur.added_by);
                

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
    }
}
