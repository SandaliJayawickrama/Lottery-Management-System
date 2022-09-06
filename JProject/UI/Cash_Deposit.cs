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
    public partial class Cash_Deposit : Form
    {
        public Cash_Deposit()
        {
            InitializeComponent();
        }

        Balance_TransactionDAL balDal = new Balance_TransactionDAL();
        Cash_DepositDAL cashDal = new Cash_DepositDAL();
        userDAL Udal = new userDAL();

        private void Cash_Deposit_Load(object sender, EventArgs e)
        {
            DataTable balDT = balDal.SelectLastRowBalances();

            decimal cashBalance1 = decimal.Parse(balDT.Rows[0][2].ToString());
            lblBlance1.Text = cashBalance1.ToString();
        }

        private decimal BalanceCalculation()
        {
            decimal cashBal1 = decimal.Parse(lblBlance1.Text);
            decimal bank = decimal.Parse(txtBank.Text);

            decimal balance = cashBal1 - bank;

            if (bank == 0)
            {
                balance = cashBal1;
            }

            return balance;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal balance = BalanceCalculation();

            lblBalance2.Text = balance.ToString();
        }

        public void clear()
        {
            txtBank.Text = "0";
            cmbDescription.Text = "";
            lblBlance1.Text = "0.00";
            lblBalance2.Text = "0.00";
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            Cash_DepositBLL cashDeptBll = new Cash_DepositBLL();

            cashDeptBll.description = cmbDescription.Text;
            cashDeptBll.amount = decimal.Parse(txtBank.Text);
            cashDeptBll.added_date = DateTime.Now;

            //get the username of logged in user
            string username = Login.loggedIn;
            userBLL usr = Udal.GetUsername(username);           
            cashDeptBll.added_by = usr.username;

            bool isAllSuccess = false;
            
            using (TransactionScope scope = new TransactionScope())
            {
                //Insert Cash Deposit into Database
                bool iscashDept = cashDal.Insert_CashDeposit(cashDeptBll);

                //Updatee balances in Balance Transaction table
                Balance_TransactionBLL balBll = new Balance_TransactionBLL();
                DataTable balDT = balDal.SelectLastRowBalances();

                balBll.Description = "Cash Deposit to Bank";
                balBll.Cash = decimal.Parse(balDT.Rows[0][2].ToString()) - decimal.Parse(txtBank.Text);
                balBll.Bank = decimal.Parse(balDT.Rows[0][3].ToString()) + decimal.Parse(txtBank.Text);
                balBll.Stock = decimal.Parse(balDT.Rows[0][4].ToString());
                balBll.Win_Nlb = decimal.Parse(balDT.Rows[0][5].ToString());
                balBll.Win_Dlb = decimal.Parse(balDT.Rows[0][6].ToString());
                balBll.Credi_recievables = decimal.Parse(balDT.Rows[0][7].ToString());
                balBll.Stock_recievablesNLB = decimal.Parse(balDT.Rows[0][8].ToString());
                balBll.Stock_recievablesDLB = decimal.Parse(balDT.Rows[0][9].ToString());
                balBll.Return_recievablesNLB = decimal.Parse(balDT.Rows[0][10].ToString());
                balBll.Return_recievablesDLB = decimal.Parse(balDT.Rows[0][11].ToString());
                balBll.Credit_PayableNLB = decimal.Parse(balDT.Rows[0][12].ToString());
                balBll.Credit_PayableDLB = decimal.Parse(balDT.Rows[0][13].ToString());
                balBll.Return_PayableNLB = decimal.Parse(balDT.Rows[0][14].ToString());
                balBll.Return_PayableDLB = decimal.Parse(balDT.Rows[0][15].ToString());
                balBll.Capital = decimal.Parse(balDT.Rows[0][16].ToString());
                balBll.Income = decimal.Parse(balDT.Rows[0][17].ToString());
                balBll.Expenses = decimal.Parse(balDT.Rows[0][18].ToString());
                balBll.emai_Nlb = decimal.Parse(balDT.Rows[0][21].ToString());
                balBll.emai_Dlb = decimal.Parse(balDT.Rows[0][22].ToString());
                balBll.freeIssue_receivableNLB = decimal.Parse(balDT.Rows[0][23].ToString());
                balBll.freeIssue_receivableDLB = decimal.Parse(balDT.Rows[0][24].ToString());
                balBll.other_discountGiving = decimal.Parse(balDT.Rows[0][25].ToString());

                balBll.added_date = DateTime.Now;
                balBll.added_by = usr.username;

                bool isBalanceSettle = balDal.UpdateTransactionBalance(balBll);

                //balance settlement calculation
                decimal balance = BalanceCalculation();
                lblBalance2.Text = balance.ToString();

                isAllSuccess = iscashDept && isBalanceSettle;

                decimal balance1 = decimal.Parse(lblBlance1.Text);
                decimal amount = decimal.Parse(txtBank.Text);
            
                if (balance1 < amount || lblBlance1.Text=="0.00")
                {
                    //Error message
                    MessageBox.Show("Balance not sufficient..!");
                }
                else if (isAllSuccess == true && cmbDescription.Text != "" && txtBank.Text != "0")
                {
                    //Deposit Complete
                    scope.Complete();
                    MessageBox.Show("Successfully Deposited");

                    //Clear all the txt boxes
                    clear();
                }
                else
                {
                    //Deposit fail
                    MessageBox.Show("Failed to deposit..!");
                }
            }
        }

        private void txtBank_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void cmbDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtBank_TextChanged(object sender, EventArgs e)
        {
            if (txtBank.Text.ToString() == "")
            {
                txtBank.Text = "0";
            }
        }
    }       
}
