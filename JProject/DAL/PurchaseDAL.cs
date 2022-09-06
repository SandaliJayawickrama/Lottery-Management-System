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
    class PurchaseDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Insert Method for Purchase
        public bool InsertPurchases(PurchaseBLL p)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "INSERT INTO purchase(supplier, po_no, po_date, ticket_name, unit_price, draw_no, draw_date, starting_Bcode, ending_Bcode, order_qty, recieved_qty, line_total, added_date, added_by) VALUES (@supplier, @po_no, @po_date, @ticket_name, @unit_price, @draw_no, @draw_date, @starting_Bcode, @ending_Bcode, @order_qty, @recieved_qty, @line_total, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@supplier", p.supplier);
                cmd.Parameters.AddWithValue("@po_no", p.po_no);
                cmd.Parameters.AddWithValue("@po_date", p.po_date);
                cmd.Parameters.AddWithValue("@ticket_name", p.ticket_Name);
                cmd.Parameters.AddWithValue("@unit_price", p.unit_price);
                cmd.Parameters.AddWithValue("@draw_no", p.draw_no);
                cmd.Parameters.AddWithValue("@draw_date", p.draw_date);
                cmd.Parameters.AddWithValue("@starting_Bcode", p.starting_Bcode);
                cmd.Parameters.AddWithValue("@ending_Bcode", p.ending_Bcode);
                cmd.Parameters.AddWithValue("@order_qty", p.order_qty);
                cmd.Parameters.AddWithValue("@recieved_qty", p.recieved_qty);
                cmd.Parameters.AddWithValue("@line_total", p.line_total);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);

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
