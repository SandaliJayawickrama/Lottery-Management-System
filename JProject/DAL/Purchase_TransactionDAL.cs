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
    class Purchase_TransactionDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Insert Purchase_Transaction
        public bool Insert_Puechase_Transaction(Purchase_TransactionBLL pt, out int PtransactionId)
        {
            bool isSuccess = false;
            PtransactionId = -1;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "INSERT INTO purchase_transaction (inv_no, supplier, total_quantity, grand_total, inv_date, added_date, added_by, category) VALUES (@inv_no, @supplier, @total_quantity, @grand_total, @inv_date, @added_date, @added_by, @category); SELECT @@IDENTITY;";
          
                //Sql command to pass the value in sql query
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Passing the values to sql query using cmd                         
                cmd.Parameters.AddWithValue("@inv_no", pt.inv_no);              
                cmd.Parameters.AddWithValue("@supplier", pt.supplier);
                cmd.Parameters.AddWithValue("@total_quantity", pt.total_quantity);
                cmd.Parameters.AddWithValue("@grand_total", pt.grand_total);
                cmd.Parameters.AddWithValue("@inv_date", pt.inv_date);
                cmd.Parameters.AddWithValue("@added_date", pt.added_date);
                cmd.Parameters.AddWithValue("@added_by", pt.added_by);
                cmd.Parameters.AddWithValue("@category", pt.category);
                
                //Open Database Connection
                conn.Open();

                //Execute the query
                object o = cmd.ExecuteScalar();

                //if the query is executed successfully then the value will not be null else it will be null
                if(o!=null)
                {
                    PtransactionId = int.Parse(o.ToString());
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
                //close DB connection
                conn.Close();
            }
            return isSuccess;
        }
        #endregion
    }
}
