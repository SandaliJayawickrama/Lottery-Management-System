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
using System.Windows.Forms;

namespace JProject.UI
{
    public partial class Balances_Management : Form
    {
        public Balances_Management()
        {
            InitializeComponent();
        }

        //BalancesDAL balanceDal = new BalancesDAL();
        Balance_TransactionDAL balDal = new Balance_TransactionDAL();
        userDAL Udal = new userDAL();

        private void Balances_Management_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            Balance_TransactionBLL balBll = new Balance_TransactionBLL();
            DataTable balDT = balDal.SelectLastRowBalances();

            string description = "Add new balance";

            balBll.Description = description;
            balBll.Cash = decimal.Parse(balDT.Rows[0][2].ToString()) + decimal.Parse(txtCash.Text);
            balBll.Bank = decimal.Parse(balDT.Rows[0][3].ToString()) + decimal.Parse(txtBank.Text);
            balBll.Win_Nlb = decimal.Parse(balDT.Rows[0][5].ToString()) + decimal.Parse(txtWinNLB.Text);
            balBll.Win_Dlb = decimal.Parse(balDT.Rows[0][6].ToString()) + decimal.Parse(txtWinDLB.Text);
            balBll.Return_recievablesNLB = decimal.Parse(balDT.Rows[0][10].ToString()) + decimal.Parse(txtRetRecNLB.Text);
            balBll.Return_recievablesDLB = decimal.Parse(balDT.Rows[0][11].ToString()) + decimal.Parse(txtRetRecDLB.Text);
            balBll.Return_PayableNLB = decimal.Parse(balDT.Rows[0][14].ToString()) + decimal.Parse(txtRetPayNLB.Text);
            balBll.Return_PayableDLB = decimal.Parse(balDT.Rows[0][15].ToString()) + decimal.Parse(txtRetPayDLB.Text);
            balBll.Credit_PayableNLB = decimal.Parse(balDT.Rows[0][12].ToString()) + decimal.Parse(txtCredPayNlb.Text);
            balBll.Credit_PayableDLB = decimal.Parse(balDT.Rows[0][13].ToString()) + decimal.Parse(txtCredPayDlb.Text);
            balBll.Capital = decimal.Parse(balDT.Rows[0][16].ToString()) + decimal.Parse(txtCapital.Text);

            balBll.Stock = decimal.Parse(balDT.Rows[0][4].ToString());
            balBll.Credi_recievables = decimal.Parse(balDT.Rows[0][7].ToString());
            balBll.Stock_recievablesNLB = decimal.Parse(balDT.Rows[0][8].ToString());
            balBll.Stock_recievablesDLB = decimal.Parse(balDT.Rows[0][9].ToString());
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

            //Inserting Data into Database
            bool issuccess = balDal.InsertInitialBalances(balBll);

            if (issuccess == true)
            {
                //Data succeefully Inserted
                MessageBox.Show("Successfully Added");
                clear();
            }
            else
            {
                //Faild to Insert Data
                MessageBox.Show("Faild to add..!");
            }
                     
        }


        private void btnDeduct_Click(object sender, EventArgs e)
        {
            Balance_TransactionBLL balBll = new Balance_TransactionBLL();
            DataTable balDT = balDal.SelectLastRowBalances();

            string description = "Ajust balances";
            //decimal cashBal = decimal.Parse(balDT.Rows[0][2].ToString());

            balBll.Description = description;
            balBll.Cash = decimal.Parse(balDT.Rows[0][2].ToString()) - decimal.Parse(txtCash.Text);
            balBll.Bank = decimal.Parse(balDT.Rows[0][3].ToString()) - decimal.Parse(txtBank.Text);
            balBll.Win_Nlb = decimal.Parse(balDT.Rows[0][5].ToString()) - decimal.Parse(txtWinNLB.Text);
            balBll.Win_Dlb = decimal.Parse(balDT.Rows[0][6].ToString()) - decimal.Parse(txtWinDLB.Text);
            balBll.Return_recievablesNLB = decimal.Parse(balDT.Rows[0][10].ToString()) - decimal.Parse(txtRetRecNLB.Text);
            balBll.Return_recievablesDLB = decimal.Parse(balDT.Rows[0][11].ToString()) - decimal.Parse(txtRetRecDLB.Text);
            balBll.Return_PayableNLB = decimal.Parse(balDT.Rows[0][14].ToString()) - decimal.Parse(txtRetPayNLB.Text);
            balBll.Return_PayableDLB = decimal.Parse(balDT.Rows[0][15].ToString()) - decimal.Parse(txtRetPayDLB.Text);
            balBll.Credit_PayableNLB = decimal.Parse(balDT.Rows[0][12].ToString()) - decimal.Parse(txtCredPayNlb.Text);
            balBll.Credit_PayableDLB = decimal.Parse(balDT.Rows[0][13].ToString()) - decimal.Parse(txtCredPayDlb.Text);
            balBll.Capital = decimal.Parse(balDT.Rows[0][16].ToString()) - decimal.Parse(txtCapital.Text);

            balBll.Stock = decimal.Parse(balDT.Rows[0][4].ToString());
            balBll.Credi_recievables = decimal.Parse(balDT.Rows[0][7].ToString());
            balBll.Stock_recievablesNLB = decimal.Parse(balDT.Rows[0][8].ToString());
            balBll.Stock_recievablesDLB = decimal.Parse(balDT.Rows[0][9].ToString());
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

            //Inserting Data into Database
            bool issuccess = balDal.InsertInitialBalances(balBll);

            if (issuccess == true)
            {
                //Data succeefully Inserted
                MessageBox.Show("Successfully Added");
                clear();
            }
            else
            {
                //Faild to Insert Data
                MessageBox.Show("Faild to add..!");
            }
        }

        public void clear()
        {
            txtCash.Text = "0";
            txtBank.Text = "0";
            txtWinNLB.Text = "0";
            txtWinDLB.Text = "0";
            txtRetRecNLB.Text = "0";
            txtRetRecDLB.Text = "0";
            txtRetPayNLB.Text = "0";
            txtRetPayDLB.Text = "0";
            txtCredPayNlb.Text = "0";
            txtCredPayDlb.Text = "0";
            txtCapital.Text = "0";
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            if (txtCash.Text.ToString() == "")
            {
                txtCash.Text = "0";
            }
        }

        private void txtBank_TextChanged(object sender, EventArgs e)
        {
            if (txtBank.Text.ToString() == "")
            {
                txtBank.Text = "0";
            }
        }
     
        private void txtWinNLB_TextChanged(object sender, EventArgs e)
        {
            if (txtWinNLB.Text.ToString() == "")
            {
                txtWinNLB.Text = "0";
            }
        }

        private void txtWinDLB_TextChanged(object sender, EventArgs e)
        {
            if (txtWinDLB.Text.ToString() == "")
            {
                txtWinDLB.Text = "0";
            }
        }

        private void txtRetRecNLB_TextChanged(object sender, EventArgs e)
        {
            if (txtRetRecNLB.Text.ToString() == "")
            {
                txtRetRecNLB.Text = "0";
            }
        }

        private void txtRetRecDLB_TextChanged(object sender, EventArgs e)
        {
            if (txtRetRecDLB.Text.ToString() == "")
            {
                txtRetRecDLB.Text = "0";
            }
        }

        private void txtRetPayNLB_TextChanged(object sender, EventArgs e)
        {
            if (txtRetPayNLB.Text.ToString() == "")
            {
                txtRetPayNLB.Text = "0";
            }
        }

        private void txtRetPayDLB_TextChanged(object sender, EventArgs e)
        {
            if (txtRetPayDLB.Text.ToString() == "")
            {
                txtRetPayDLB.Text = "0";
            }
        }

        private void txtCredPayNlb_TextChanged(object sender, EventArgs e)
        {
            if (txtCredPayNlb.Text.ToString() == "")
            {
                txtCredPayNlb.Text = "0";
            }
        }

        private void txtCredPayDlb_TextChanged(object sender, EventArgs e)
        {
            if (txtCredPayDlb.Text.ToString() == "")
            {
                txtCredPayDlb.Text = "0";
            }
        }

        private void txtCapital_TextChanged(object sender, EventArgs e)
        {
            if (txtCapital.Text.ToString() == "")
            {
                txtCapital.Text = "0";
            }
        }

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
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

        private void txtWinNLB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtWinDLB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtRetRecNLB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtRetRecDLB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtRetPayNLB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtRetPayDLB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtCredPayNlb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtCredPayDlb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtCapital_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

       
    }
}
