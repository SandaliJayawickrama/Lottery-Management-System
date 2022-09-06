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
    class SalesDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Insert Sales to sales Tables
        public bool InsertSales(SalesBLL saBll)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            bool isSuccess = false;

            try
            {
                string sql = "INSERT INTO sales(inv_no, agent_name, agent_no, ticket_name, draw_no, st_Bcode, en_Bcode, quantity, supplier, line_total, added_date, added_by, unit_price, draw_date) VALUES (@inv_no, @agent_name, @agent_no, @ticket_name, @draw_no, @st_Bcode, @en_Bcode, @quantity, @supplier, @line_total, @added_date, @added_by, @unit_price, @draw_date)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@inv_no", saBll.inv_no);
                cmd.Parameters.AddWithValue("@agent_name", saBll.agent_name);
                cmd.Parameters.AddWithValue("@agent_no", saBll.agent_no);
                cmd.Parameters.AddWithValue("@ticket_name", saBll.ticket_name);
                cmd.Parameters.AddWithValue("@draw_no", saBll.draw_no);
                cmd.Parameters.AddWithValue("@st_Bcode", saBll.st_Bcode);
                cmd.Parameters.AddWithValue("@en_Bcode", saBll.en_Bcode);
                cmd.Parameters.AddWithValue("@quantity", saBll.quantity);
                cmd.Parameters.AddWithValue("@supplier", saBll.supplier);
                cmd.Parameters.AddWithValue("@line_total", saBll.line_total);
                cmd.Parameters.AddWithValue("@added_date", saBll.added_date);
                cmd.Parameters.AddWithValue("@added_by", saBll.added_by);
                cmd.Parameters.AddWithValue("@unit_price", saBll.unit_price);
                cmd.Parameters.AddWithValue("@draw_date", saBll.draw_date);

                conn.Open();

                // declare integer variable and execute the query
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

        #region Select Today draw Dated Sales Tickets for Sales_Return 
        public DataTable SelectTodayDatedDrawSales()
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM sales WHERE draw_date = cast(getdate() as Date)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();

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
    }
}
