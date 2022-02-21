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
    public partial class Credit_Settle : Form
    {
        public Credit_Settle()
        {
            InitializeComponent();
        }

        AgentDAL agDal = new AgentDAL();

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

        }

        //Calculate Total SEttlement
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

        private void lblTotAmount_Click(object sender, EventArgs e)
        {

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
            bool isSuccess = false;

            string Aname = txtAgentName.Text;
            string Ano = txtAgentNo.Text;

            decimal credit = decimal.Parse(txtCreditAmount.Text);

            decimal settle = CalcTotalSettlement();
            decimal creditBalance = CalcCreditBalance();
            txtTotSettle.Text = settle.ToString();
            txtCreditBalance.Text = creditBalance.ToString();

            isSuccess = agDal.DecreaseCreditAmount(Aname,Ano, settle);

            if (isSuccess == true && settle<=credit && credit!=0)
            {
                //Data succeefully Inserted
                MessageBox.Show("Successfull");
                clear();
            }
            else
            {
                //Faild to Insert Data
                MessageBox.Show("Faild to settle!");
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
        }

        private void Credit_Settle_Load(object sender, EventArgs e)
        {

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
    }
}
