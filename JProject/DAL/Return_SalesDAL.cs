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
    class Return_SalesDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Insert Sales Returns into return_Sales tables
        public bool InsertSalesReturns(Return_SalesBLL saBll)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            bool isSuccess = false;

            try
            {
                string sql = "INSERT INTO return_Sales(SReturn_id, agent_name, agent_no, salesInv_no, ticket_name, draw_date, draw_no, starting_Bcode, ending_Bcode, quantity, unit_price, line_total, supplier, added_by, added_date) VALUES (@SReturn_id, @agent_name, @agent_no, @salesInv_no, @ticket_name, @draw_date, @draw_no, @starting_Bcode, @ending_Bcode, @quantity, @unit_price, @line_total, @supplier, @added_by, @added_date)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@SReturn_id", saBll.SReturn_id);
                cmd.Parameters.AddWithValue("@agent_name", saBll.agent_name);
                cmd.Parameters.AddWithValue("@agent_no", saBll.agent_no);
                cmd.Parameters.AddWithValue("@salesInv_no", saBll.salesInv_no);
                cmd.Parameters.AddWithValue("@ticket_name", saBll.ticket_name);
                cmd.Parameters.AddWithValue("@draw_date", saBll.draw_date);
                cmd.Parameters.AddWithValue("@draw_no", saBll.draw_no);
                cmd.Parameters.AddWithValue("@starting_Bcode", saBll.starting_Bcode);
                cmd.Parameters.AddWithValue("@ending_Bcode", saBll.ending_Bcode);
                cmd.Parameters.AddWithValue("@quantity", saBll.quantity);
                cmd.Parameters.AddWithValue("@unit_price", saBll.unit_price);  
                cmd.Parameters.AddWithValue("@line_total", saBll.line_total);
                cmd.Parameters.AddWithValue("@supplier", saBll.supplier);
                cmd.Parameters.AddWithValue("@added_by", saBll.added_by);
                cmd.Parameters.AddWithValue("@added_date", saBll.added_date);

                conn.Open();

                // declare integer variable and execute the query
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
