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

        /*#region Select Data from Database
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM purchase";

                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        #endregion*/

        #region Insert Method for Purchase
        public bool InsertPurchases(PurchaseBLL p)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "INSERT INTO purchase(ticket_name, unit_price, draw_no, draw_date, starting_Bcode, ending_Bcode, quantity, line_total, inv_no, inv_date, added_date, added_by, supplier) VALUES (@ticket_name, @unit_price, @draw_no, @draw_date, @starting_Bcode, @ending_Bcode, @quantity, @line_total, @inv_no, @inv_date, @added_date, @added_by, @supplier)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ticket_name", p.ticket_Name);
                cmd.Parameters.AddWithValue("@unit_price", p.unit_price);
                cmd.Parameters.AddWithValue("@draw_no", p.draw_No);
                cmd.Parameters.AddWithValue("@draw_date", p.draw_date);
                cmd.Parameters.AddWithValue("@starting_Bcode", p.starting_Bcode);
                cmd.Parameters.AddWithValue("@ending_Bcode", p.ending_Bcode);
                cmd.Parameters.AddWithValue("@quantity", p.quantity);
                cmd.Parameters.AddWithValue("@line_total", p.line_total);
                cmd.Parameters.AddWithValue("@inv_no", p.inv_no);
                cmd.Parameters.AddWithValue("@inv_date", p.inv_date);
                cmd.Parameters.AddWithValue("@added_date", p.added_date);
                cmd.Parameters.AddWithValue("@added_by", p.added_by);
                cmd.Parameters.AddWithValue("@supplier", p.supplier);

                conn.Open();

                //declare integer variable and execute the query
                int rows = cmd.ExecuteNonQuery();
                if(rows > 0)
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

    }
}
