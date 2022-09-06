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
    class BalancesDAL
    {
        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        
        #region Get current cash value from balances table
        public decimal GetCurrentCashValue()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal cash = 0;
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT cash FROM balances WHERE bid=@bid";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@bid", 1);


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    cash = decimal.Parse(dt.Rows[0]["cash"].ToString());
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

            return cash;
        }
        #endregion

        #region Get current bank value from balances table
        public decimal GetCurrentBankValue()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal bank = 0;
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT bank FROM balances WHERE bid=@bid";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@bid", 1);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    bank = decimal.Parse(dt.Rows[0]["bank"].ToString());
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

            return bank;
        }
        #endregion

        #region Get current payableNlb value from balances table
        public decimal GetCurrentPayableNlbValue()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal nlb = 0;
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT payable_Nlb FROM balances WHERE bid=@bid";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@bid", 1);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    nlb = decimal.Parse(dt.Rows[0]["payable_Nlb"].ToString());
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

            return nlb;
        }
        #endregion

        #region Get current payableDlb value from balances table
        public decimal GetCurrentPayableDlbValue()
        {
            SqlConnection conn = new SqlConnection(myconnstring);
            decimal dlb = 0;
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT payable_Dlb FROM balances WHERE bid=@bid";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@bid", 1);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    dlb = decimal.Parse(dt.Rows[0]["payable_Dlb"].ToString());
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

            return dlb;
        }
        #endregion




        #region Update Balances from Blance Management
        public bool UpdateBalances(decimal cash, decimal bank, decimal payable_Nlb, decimal payable_Dlb)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE balances SET cash=@cash, bank=@bank, payable_Nlb=@payable_Nlb, payable_Dlb=@payable_Dlb  WHERE bid=1";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cash", cash);
                cmd.Parameters.AddWithValue("@bank", bank);
                cmd.Parameters.AddWithValue("@payable_Nlb", payable_Nlb);
                cmd.Parameters.AddWithValue("@payable_Dlb", payable_Dlb);

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

        #region Increase Balances Table (cash,bank,payableNlb,payableDlb) for Balance Managemrent
        public bool IncreaseBalances(decimal cash, decimal bank, decimal payNlb, decimal payDlb)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                decimal currentCash = GetCurrentCashValue();
                decimal currentBank = GetCurrentBankValue();
                decimal currentPayNlb = GetCurrentPayableNlbValue();
                decimal currentPayDlb = GetCurrentPayableDlbValue();

                //calculate new balances
                decimal NewCash = currentCash + cash;
                decimal NewBank = currentBank + bank;
                decimal NewNlb = currentPayNlb + payNlb;
                decimal NewDlb = currentPayDlb + payDlb;

                if (cash > 0 || bank > 0 || payNlb > 0 || payDlb > 0)
                {
                    isSuccess = UpdateBalances(NewCash,NewBank,NewNlb,NewDlb);                 
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




        #region Update PayableNlb Balance in Balances from Purchases
        public bool UpdatePayableNlb(decimal payable_Nlb)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE balances SET payable_Nlb=@payable_Nlb WHERE bid=1";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@payable_Nlb", payable_Nlb);

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

        #region Increase payableNlb Balance From Purchase
        public bool IncreasepPayableNlbBalance(decimal payNlb)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                decimal currentPayNlb = GetCurrentPayableNlbValue();

                //calculate new balance
                decimal NewNlb = currentPayNlb + payNlb;

                if (payNlb > 0)
                {
                    isSuccess = UpdatePayableNlb(NewNlb);
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



        #region Update PayableDlb Balance in Balances from purchases
        public bool UpdatePayableDlb(decimal payable_Dlb)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstring);
            try
            {
                string sql = "UPDATE balances SET payable_Dlb=@payable_Dlb WHERE bid=1";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@payable_Dlb", payable_Dlb);

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

        #region Increase payableDlb Balance From Purchase
        public bool IncreasepPayableDlbBalance(decimal payDlb)
        {
            bool isSuccess = false;
            SqlConnection conn = new SqlConnection(myconnstring);

            try
            {
                decimal currentPayDlb = GetCurrentPayableDlbValue();

                //calculate new balance
                decimal NewDlb = currentPayDlb + payDlb;

                if (payDlb > 0)
                {
                    isSuccess = UpdatePayableDlb(NewDlb);
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
