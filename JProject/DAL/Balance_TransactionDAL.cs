using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using JProject.BLL;
using System.Windows.Forms;
using System.Data;

namespace JProject.DAL
{
    class Balance_TransactionDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        #region Select last row balances from balance_Transaction table
        public DataTable SelectLastRowBalances()
        {
            SqlConnection conn = new SqlConnection(myconnstring);

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM balance_Transaction WHERE bid=(SELECT max(bid) FROM balance_Transaction);";

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

        #region Insert Initial Balances into balance_Transaction Table From Balance Management
        public bool InsertInitialBalances(Balance_TransactionBLL BalanceBll)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            bool isSuccess = false;

            try
            {
                string sql = "INSERT INTO balance_Transaction(Description, Cash, Bank, Stock, Win_Nlb, Win_Dlb, Credi_recievables, Stock_recievablesNLB, Stock_recievablesDLB, Return_recievablesNLB, Return_recievablesDLB, Return_PayableNLB, Return_PayableDLB, Credit_PayableNLB, Credit_PayableDLB, Capital, Income, Expenses, added_by, added_date, emai_Nlb, emai_Dlb, freeIssue_receivableNLB, freeIssue_receivableDLB, other_discountGiving) VALUES (@Description, @Cash, @Bank, @Stock, @Win_Nlb, @Win_Dlb, @Credi_recievables, @Stock_recievablesNLB, @Stock_recievablesDLB, @Return_recievablesNLB, @Return_recievablesDLB, @Return_PayableNLB, @Return_PayableDLB, @Credit_PayableNLB, @Credit_PayableDLB, @Capital, @Income, @Expenses, @added_by, @added_date, @emai_Nlb, @emai_Dlb, @freeIssue_receivableNLB, @freeIssue_receivableDLB, @other_discountGiving)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Description", BalanceBll.Description);
                cmd.Parameters.AddWithValue("@Cash", BalanceBll.Cash);
                cmd.Parameters.AddWithValue("@Bank", BalanceBll.Bank);
                cmd.Parameters.AddWithValue("@Stock", BalanceBll.Stock);                
                cmd.Parameters.AddWithValue("@Win_Nlb", BalanceBll.Win_Nlb);
                cmd.Parameters.AddWithValue("@Win_Dlb", BalanceBll.Win_Dlb);
                cmd.Parameters.AddWithValue("@Credi_recievables", BalanceBll.Credi_recievables);
                cmd.Parameters.AddWithValue("@Stock_recievablesNLB", BalanceBll.Stock_recievablesNLB);
                cmd.Parameters.AddWithValue("@Stock_recievablesDLB", BalanceBll.Stock_recievablesDLB);                                                  
                cmd.Parameters.AddWithValue("@Return_recievablesNLB", BalanceBll.Return_recievablesNLB);
                cmd.Parameters.AddWithValue("@Return_recievablesDLB", BalanceBll.Return_recievablesDLB);
                cmd.Parameters.AddWithValue("@Return_PayableNLB", BalanceBll.Return_PayableNLB);
                cmd.Parameters.AddWithValue("@Return_PayableDLB", BalanceBll.Return_PayableDLB);
                cmd.Parameters.AddWithValue("@Credit_PayableNLB", BalanceBll.Credit_PayableNLB);
                cmd.Parameters.AddWithValue("@Credit_PayableDLB", BalanceBll.Credit_PayableDLB);
                cmd.Parameters.AddWithValue("@Capital", BalanceBll.Capital);
                cmd.Parameters.AddWithValue("@Income", BalanceBll.Income);
                cmd.Parameters.AddWithValue("@Expenses", BalanceBll.Expenses);
                cmd.Parameters.AddWithValue("@emai_Nlb", BalanceBll.emai_Nlb);
                cmd.Parameters.AddWithValue("@emai_Dlb", BalanceBll.emai_Dlb);
                cmd.Parameters.AddWithValue("@freeIssue_receivableNLB", BalanceBll.freeIssue_receivableNLB);
                cmd.Parameters.AddWithValue("@freeIssue_receivableDLB", BalanceBll.freeIssue_receivableDLB);
                cmd.Parameters.AddWithValue("@other_discountGiving", BalanceBll.other_discountGiving);

                cmd.Parameters.AddWithValue("@added_by", BalanceBll.added_by);
                cmd.Parameters.AddWithValue("@added_date", BalanceBll.added_date);

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

        #region Update Balances in balance_Transaction Table 
        public bool UpdateTransactionBalance(Balance_TransactionBLL BalanceBll)
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            bool isSuccess = false;

            try
            {             
                string sql = "INSERT INTO balance_Transaction(Description, Cash, Bank, Stock, Win_Nlb, Win_Dlb, Credi_recievables, Stock_recievablesNLB, Stock_recievablesDLB, Return_recievablesNLB, Return_recievablesDLB, Return_PayableNLB, Return_PayableDLB, Credit_PayableNLB, Credit_PayableDLB, Capital, Income, Expenses, added_by, added_date, emai_Nlb, emai_Dlb, freeIssue_receivableNLB, freeIssue_receivableDLB, other_discountGiving) VALUES (@Description, @Cash, @Bank, @Stock, @Win_Nlb, @Win_Dlb, @Credi_recievables, @Stock_recievablesNLB, @Stock_recievablesDLB, @Return_recievablesNLB, @Return_recievablesDLB, @Return_PayableNLB, @Return_PayableDLB, @Credit_PayableNLB, @Credit_PayableDLB, @Capital, @Income, @Expenses, @added_by, @added_date, @emai_Nlb, @emai_Dlb, @freeIssue_receivableNLB, @freeIssue_receivableDLB, @other_discountGiving)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Description", BalanceBll.Description);
                cmd.Parameters.AddWithValue("@Cash", BalanceBll.Cash);
                cmd.Parameters.AddWithValue("@Bank", BalanceBll.Bank);
                cmd.Parameters.AddWithValue("@Stock", BalanceBll.Stock);
                cmd.Parameters.AddWithValue("@Win_Nlb", BalanceBll.Win_Nlb);
                cmd.Parameters.AddWithValue("@Win_Dlb", BalanceBll.Win_Dlb);
                cmd.Parameters.AddWithValue("@Credi_recievables", BalanceBll.Credi_recievables);
                cmd.Parameters.AddWithValue("@Stock_recievablesNLB", BalanceBll.Stock_recievablesNLB);
                cmd.Parameters.AddWithValue("@Stock_recievablesDLB", BalanceBll.Stock_recievablesDLB);
                cmd.Parameters.AddWithValue("@Return_recievablesNLB", BalanceBll.Return_recievablesNLB);
                cmd.Parameters.AddWithValue("@Return_recievablesDLB", BalanceBll.Return_recievablesDLB);
                cmd.Parameters.AddWithValue("@Return_PayableNLB", BalanceBll.Return_PayableNLB);
                cmd.Parameters.AddWithValue("@Return_PayableDLB", BalanceBll.Return_PayableDLB);
                cmd.Parameters.AddWithValue("@Credit_PayableNLB", BalanceBll.Credit_PayableNLB);
                cmd.Parameters.AddWithValue("@Credit_PayableDLB", BalanceBll.Credit_PayableDLB);
                cmd.Parameters.AddWithValue("@Capital", BalanceBll.Capital);
                cmd.Parameters.AddWithValue("@Income", BalanceBll.Income);
                cmd.Parameters.AddWithValue("@Expenses", BalanceBll.Expenses);
                cmd.Parameters.AddWithValue("@emai_Nlb", BalanceBll.emai_Nlb);
                cmd.Parameters.AddWithValue("@emai_Dlb", BalanceBll.emai_Dlb);
                cmd.Parameters.AddWithValue("@freeIssue_receivableNLB", BalanceBll.freeIssue_receivableNLB);
                cmd.Parameters.AddWithValue("@freeIssue_receivableDLB", BalanceBll.freeIssue_receivableDLB);
                cmd.Parameters.AddWithValue("@other_discountGiving", BalanceBll.other_discountGiving);

                cmd.Parameters.AddWithValue("@added_by", BalanceBll.added_by);
                cmd.Parameters.AddWithValue("@added_date", BalanceBll.added_date);

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
