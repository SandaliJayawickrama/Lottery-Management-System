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

        BalancesDAL balanceDal = new BalancesDAL();

        private void Balances_Management_Load(object sender, EventArgs e)
        {
          
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            decimal cash = decimal.Parse(txtCash.Text);
            decimal bank = decimal.Parse(txtBank.Text);
            decimal Pnlb = decimal.Parse(txtPayNlb.Text);
            decimal Pdlb = decimal.Parse(txtPayDlb.Text);
     
            //Updating Data into Database
            bool success = balanceDal.IncreaseBalances(cash,bank,Pnlb,Pdlb);

            if (success == true)
            {
                //Data Updated successfully
                MessageBox.Show("Successfully added..");
                clear();
            }
            else
            {
                //Faild to Update agent
                MessageBox.Show("Faild to add..!");
            }

           
        }

        public void clear()
        {
            txtCash.Text = "";
            txtBank.Text = "";
            txtPayNlb.Text = "";
            txtPayDlb.Text = "";
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

        private void txtPayNlb_TextChanged(object sender, EventArgs e)
        {

            if (txtPayNlb.Text.ToString() == "")
            {
                txtPayNlb.Text = "0";
            }

        }

        private void txtPayDlb_TextChanged(object sender, EventArgs e)
        {

            if (txtPayDlb.Text.ToString() == "")
            {
                txtPayDlb.Text = "0";
            }
        }

        private void lblCash_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
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

        private void txtBank_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtPayNlb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtPayDlb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
