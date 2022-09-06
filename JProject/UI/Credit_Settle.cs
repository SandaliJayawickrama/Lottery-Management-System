using JProject.BLL;
using JProject.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace JProject.UI
{
    public partial class Credit_Settle : Form
    {
        public Credit_Settle()
        {
            InitializeComponent();
        }

        AgentDAL agDal = new AgentDAL();
        Balance_TransactionDAL balDal = new Balance_TransactionDAL();
        userDAL Udal = new userDAL();

        private void txtSearchAgent_TextChanged(object sender, EventArgs e)
        {
            //Get the keyword from searching txtBox
            string keyword = txtSearchAgent.Text;

            //Check the value
            if (keyword == "")
            {
                txtAgentName.Text = "";
                txtAgentNo.Text = "";
                txtCreditLimit.Text = "0";
                txtCreditAmount.Text = "0";
                txtTotSettle.Text = "0";
                txtCreditBalance.Text = "0";
                clear();
                return;
            }

            //Searching agent details display respective values on the txtBoxes
            AgentBLL ag = agDal.SearchAgent_ForCreditSettle(keyword);

            //Set the values on textboxes, based on ag object
            txtAgentName.Text = ag.agent_name;
            txtAgentNo.Text = ag.agent_no;
            txtCreditLimit.Text = ag.credit_Limit.ToString();
            txtCreditAmount.Text = ag.credit_amount.ToString();
            txtRetLimitNlb.Text = ag.returnBal_nlb.ToString();
            txtRetLimitDlb.Text = ag.returnBal_dlb.ToString();

        }

        //Calculate Total Settlement
        private decimal CalcTotalSettlement()
        {
            decimal cash = decimal.Parse(txtCash.Text);
            decimal cheque = decimal.Parse(txtCheque.Text);
            decimal retN = decimal.Parse(txtReturnNlb.Text);
            decimal retD = decimal.Parse(txtReturnDlb.Text);
            decimal winN = decimal.Parse(txtWinNlb.Text);
            decimal winD = decimal.Parse(txtWinDlb.Text);
       
            decimal TotSettlement = cash + cheque + retN + retD + winN + winD;

            if (cash == 0 && cheque == 0 && retN == 0 && retD == 0 && winN == 0 && winD == 0 )
            {
                TotSettlement = 0;
            }
            return TotSettlement;
        }

        private decimal CalcCreditBalance()
        {
            decimal creditAmount = decimal.Parse(txtCreditAmount.Text);
            decimal settlement = CalcTotalSettlement();

            decimal balance = creditAmount - settlement;

            if (settlement == 0)
            {
                balance = 0;
            }
            return balance;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal settlement = CalcTotalSettlement();
            decimal creditBalance = CalcCreditBalance();
            txtTotSettle.Text = settlement.ToString();
            txtCreditBalance.Text = creditBalance.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string Aname = txtAgentName.Text;
            string Ano = txtAgentNo.Text;
            decimal retLimitNlb = decimal.Parse(txtRetLimitNlb.Text);
            decimal retLimitDlb = decimal.Parse(txtRetLimitDlb.Text);
            decimal credit = decimal.Parse(txtCreditAmount.Text);

            decimal settle = CalcTotalSettlement();
            decimal creditBalance = CalcCreditBalance();

            txtTotSettle.Text = settle.ToString();
            txtCreditBalance.Text = creditBalance.ToString();

            bool isRetBalance = false;
            bool isAllSuccess = false;

            using (TransactionScope scope = new TransactionScope()) 
            {

                //check return balances                
                decimal retNlb = decimal.Parse(txtReturnNlb.Text);
                decimal retDlb = decimal.Parse(txtReturnDlb.Text);

                if (retLimitNlb >= retNlb && retLimitDlb >= retDlb)
                {
                    isRetBalance = true;
                }
                else
                {
                    //Faild to Insert Data
                    MessageBox.Show("Invalid Return amount..!");
                }

                //Decrease credit and return amounts
                bool isAgentCreditSuccess = agDal.DecreaseCreditAmount(Aname, Ano, settle);
                bool isAgentRetSuccess = agDal.DecreaseReturnAmount(Aname, Ano, retNlb, retDlb);

                //settle credit recievables in Balance Transaction table
                Balance_TransactionBLL balBll = new Balance_TransactionBLL();
                DataTable balDT = balDal.SelectLastRowBalances();

                decimal totCash = decimal.Parse(txtCash.Text) + decimal.Parse(txtCheque.Text);

                balBll.Description = "Settle Credit Recievable";
                balBll.Cash = decimal.Parse(balDT.Rows[0][2].ToString()) + totCash;
                balBll.Win_Nlb = decimal.Parse(balDT.Rows[0][5].ToString()) + decimal.Parse(txtWinNlb.Text);
                balBll.Win_Dlb = decimal.Parse(balDT.Rows[0][6].ToString()) + decimal.Parse(txtWinDlb.Text);
                balBll.Credi_recievables = decimal.Parse(balDT.Rows[0][7].ToString()) - decimal.Parse(txtTotSettle.Text);
                balBll.Return_PayableNLB = decimal.Parse(balDT.Rows[0][14].ToString()) - decimal.Parse(txtReturnNlb.Text);
                balBll.Return_PayableDLB = decimal.Parse(balDT.Rows[0][15].ToString()) - decimal.Parse(txtReturnDlb.Text);

                balBll.Bank = decimal.Parse(balDT.Rows[0][3].ToString());
                balBll.Stock = decimal.Parse(balDT.Rows[0][4].ToString());
                balBll.Stock_recievablesNLB = decimal.Parse(balDT.Rows[0][8].ToString());
                balBll.Stock_recievablesDLB = decimal.Parse(balDT.Rows[0][9].ToString());
                balBll.Return_recievablesNLB = decimal.Parse(balDT.Rows[0][10].ToString());
                balBll.Return_recievablesDLB = decimal.Parse(balDT.Rows[0][11].ToString());  
                balBll.Credit_PayableNLB = decimal.Parse(balDT.Rows[0][12].ToString());
                balBll.Credit_PayableDLB = decimal.Parse(balDT.Rows[0][13].ToString());
                balBll.Capital = decimal.Parse(balDT.Rows[0][16].ToString());
                balBll.Income = decimal.Parse(balDT.Rows[0][17].ToString());
                balBll.Expenses = decimal.Parse(balDT.Rows[0][18].ToString());
                balBll.emai_Nlb = decimal.Parse(balDT.Rows[0][21].ToString());
                balBll.emai_Dlb = decimal.Parse(balDT.Rows[0][22].ToString());
                balBll.freeIssue_receivableNLB = decimal.Parse(balDT.Rows[0][23].ToString());
                balBll.freeIssue_receivableDLB = decimal.Parse(balDT.Rows[0][24].ToString());
                balBll.other_discountGiving = decimal.Parse(balDT.Rows[0][25].ToString());

                balBll.added_date = DateTime.Now;

                //getting the user name of LoggedIn user
                string loggedUser = Login.loggedIn;
                userBLL urs = Udal.GetUsername(loggedUser);
                balBll.added_by = urs.username;

                bool isBalanceSettle = balDal.UpdateTransactionBalance(balBll);

                isAllSuccess = isAgentCreditSuccess && isAgentRetSuccess && isBalanceSettle && isRetBalance;


                if (isAllSuccess == true && settle <= credit && credit != 0)
                {
                    //Data succeefully Inserted
                    scope.Complete();
                    MessageBox.Show("Successfull");

                    //Clear all the txt boxes
                    clear();
                }
                else
                {
                    //Faild to Insert Data
                    MessageBox.Show("Faild to settle!");
                }

            }
        }
        

        private void clear()
        {
            txtSearchAgent.Text = "";
            txtAgentName.Text = "";
            txtAgentNo.Text = "";
            txtCreditAmount.Text = "0";
            txtCreditLimit.Text = "0";
            txtCreditBalance.Text = "0";
            txtTotSettle.Text = "0";
            txtCash.Text = "0";
            txtCheque.Text = "0";
            txtWinNlb.Text = "0";
            txtWinDlb.Text = "0";
            txtReturnNlb.Text = "0";
            txtReturnDlb.Text = "0";
            txtRetLimitNlb.Text = "0";
            txtRetLimitDlb.Text = "0";
        }

        private void Credit_Settle_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtAgentName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtAgentNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtCreditLimit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtCreditAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtCreditBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtTotSettle_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtCheque_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtWinNlb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtWinDlb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtReturnNlb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtReturnDlb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            if (txtCash.Text.ToString() == "")
            {
                txtCash.Text = "0";
            }
        }

        private void txtCheque_TextChanged(object sender, EventArgs e)
        {
            if (txtCheque.Text.ToString() == "")
            {
                txtCheque.Text = "0";
            }
        }

        private void txtWinNlb_TextChanged(object sender, EventArgs e)
        {
            if (txtWinNlb.Text.ToString() == "")
            {
                txtWinNlb.Text = "0";
            }
        }

        private void txtWinDlb_TextChanged(object sender, EventArgs e)
        {
            if (txtWinDlb.Text.ToString() == "")
            {
                txtWinDlb.Text = "0";
            }
        }

        private void txtCreditBalance_TextChanged(object sender, EventArgs e)
        {
            if (txtCreditBalance.Text.ToString() == "")
            {
                txtCreditBalance.Text = "0";
            }
        }

        private void txtReturnNlb_TextChanged(object sender, EventArgs e)
        {
            if (txtReturnNlb.Text.ToString() == "")
            {
                txtReturnNlb.Text = "0";
            }
        }

        private void txtReturnDlb_TextChanged(object sender, EventArgs e)
        {
            if (txtReturnDlb.Text.ToString() == "")
            {
                txtReturnDlb.Text = "0";
            }
        }

        private void txtTotSettle_TextChanged(object sender, EventArgs e)
        {
            if (txtTotSettle.Text.ToString() == "")
            {
                txtTotSettle.Text = "0";
            }
        }

        private void txtRetLimitNlb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtRetLimitDlb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
