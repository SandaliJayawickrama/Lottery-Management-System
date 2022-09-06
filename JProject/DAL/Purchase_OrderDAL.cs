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
    class Purchase_OrderDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Insert Method for Purchase_Order
        public bool InsertPurchaseOrders(Purchase_OrderBLL po)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                string sql = "INSERT INTO purchase_order(supplier, po_no, po_date, ticket_name, unit_price, draw_date, order_quantity, line_total, added_date, added_by) VALUES (@supplier, @po_no, @po_date, @ticket_name, @unit_price, @draw_date, @order_quantity, @line_total, @added_date, @added_by)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@supplier", po.supplier);
                cmd.Parameters.AddWithValue("@po_no", po.po_no);
                cmd.Parameters.AddWithValue("@po_date", po.po_date);
                cmd.Parameters.AddWithValue("@ticket_name", po.ticket_Name);
                cmd.Parameters.AddWithValue("@unit_price", po.unit_price);
                cmd.Parameters.AddWithValue("@draw_date", po.draw_date);
                cmd.Parameters.AddWithValue("@order_quantity", po.order_quantity);
                cmd.Parameters.AddWithValue("@line_total", po.line_total);             
                cmd.Parameters.AddWithValue("@added_date", po.added_date);
                cmd.Parameters.AddWithValue("@added_by", po.added_by);               

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




        #region Select Purchase Order detais in Order Gridview
        public DataTable SelectPurchaseOrders(string PoNo)
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();
            DataTable filledDT = new DataTable();
     
            try
            {

                string sql = "SELECT po_date, ticket_name, draw_date, order_quantity, recieved_quantity, unit_price, po_id FROM purchase_order WHERE po_no=@po_no AND (order_quantity - recieved_quantity) > 0 ";              

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@po_no", PoNo);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    filledDT = dt;
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
            return filledDT;
        }
        #endregion

        #region Get Current Recieved Quantity From Column 
        public decimal GetCurrentRecQuantity(int po_id, string tName)
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();
            decimal RecQty = 0;

            try
            {
                string sql = "SELECT recieved_quantity FROM purchase_order WHERE po_id=@po_id AND ticket_name=@ticket_name";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ticket_name", tName);
                cmd.Parameters.AddWithValue("@po_id", po_id);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);               

                if (dt.Rows.Count > 0)
                {
                    RecQty = decimal.Parse(dt.Rows[0]["recieved_quantity"].ToString());
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

            return RecQty;
        }
        #endregion

        #region Update Recieved Quantity 
        public bool UpdateRecQantity_PO(int po_id, string tName, decimal RecQty)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE purchase_order SET recieved_quantity=@recieved_quantity WHERE po_id=@po_id AND ticket_name=@ticket_name";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@recieved_quantity", RecQty);
                cmd.Parameters.AddWithValue("@po_id", po_id);
                cmd.Parameters.AddWithValue("@ticket_name", tName);

                conn.Open();

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
