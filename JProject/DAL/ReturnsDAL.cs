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
    class ReturnsDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Insert Returns into returns Table
        public bool InsertReturn(ReturnsBLL RetBll)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            bool isSuccess = false;

            try
            {
                string sql = "INSERT INTO returns(ticket_name, supplier, draw_no, draw_date, starting_Bcode, ending_Bcode, quantity, line_total, agent_name, added_by, added_date) VALUES (@ticket_name, @supplier, @draw_no, @draw_date, @starting_Bcode, @ending_Bcode, @quantity, @line_total, @agent_name, @added_by, @added_date)" ;
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ticket_name", RetBll.ticket_name);
                cmd.Parameters.AddWithValue("@supplier", RetBll.supplier);
                cmd.Parameters.AddWithValue("@draw_no", RetBll.draw_no);
                cmd.Parameters.AddWithValue("@draw_date", RetBll.draw_date);
                cmd.Parameters.AddWithValue("@starting_Bcode", RetBll.starting_Bcode);
                cmd.Parameters.AddWithValue("@ending_Bcode", RetBll.ending_Bcode);
                cmd.Parameters.AddWithValue("@quantity", RetBll.quantity);
                cmd.Parameters.AddWithValue("@line_total", RetBll.line_total);
                cmd.Parameters.AddWithValue("@agent_name", RetBll.agent_name);
                cmd.Parameters.AddWithValue("@added_by", RetBll.added_by);
                cmd.Parameters.AddWithValue("@added_date", RetBll.added_date);


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
