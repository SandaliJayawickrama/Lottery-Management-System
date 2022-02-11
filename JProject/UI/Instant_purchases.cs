using JProject.BLL;
using JProject.BLL.AdminBLL;
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
    public partial class Instant_purchases : Form
    {
        public Instant_purchases()
        {
            InitializeComponent();
        }

        TicketsDAL Tdal = new TicketsDAL();
        DataTable purchaseDT = new DataTable();
        userDAL Udal = new userDAL();
        Instant_PurchasesDAL IpDal = new Instant_PurchasesDAL();
        Purchase_TransactionDAL ptDAL = new Purchase_TransactionDAL();
        Instant_StockDAL istkDal = new Instant_StockDAL();

        private void txtCat_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtTickName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtUprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtLineTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtTotalQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtGndTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void Instant_purchases_Load(object sender, EventArgs e)
        {
            //Specify columns for PurchaseDataTable
            purchaseDT.Columns.Add("Ticket Name");
            purchaseDT.Columns.Add("Unit price");
            purchaseDT.Columns.Add("Quantity");
            purchaseDT.Columns.Add("Total");
            purchaseDT.Columns.Add("Supplier");
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the keyword from searching txtBox
            string keyword = txtSearch.Text;

            //Check the value
            if (keyword == "")
            {
                txtTickName.Text = "";
                txtSup.Text = "";
                txtUprice.Text = "0";
                txtQty.Text = "0";
                txtLineTotal.Text = "0";
                return;
            }

            //Searching ticket details display respective values on the txtBoxes
            ticketsA_BLL t = Tdal.SearchTicket_ForPuechase(keyword);

            //Set the values on textboxes, based on t object
            txtTickName.Text = t.ticket_name;
            txtSup.Text = t.ticket_type;
            txtUprice.Text = t.ticket_Uprice.ToString();
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if (txtQty.Text.ToString() == "")
            {
                txtQty.Text = "0";
            }
            else
            {
                decimal Uprice = decimal.Parse(txtUprice.Text);
                decimal Qty = decimal.Parse(txtQty.Text);

                //calculate Line-Total
                decimal lineTotal = Uprice * Qty;


                //display line-total
                txtLineTotal.Text = lineTotal.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Tname = txtTickName.Text;
            string Supplier = txtSup.Text;
            decimal Uprice = decimal.Parse(txtUprice.Text);
            decimal Qty = decimal.Parse(txtQty.Text);
            decimal lineTotal = decimal.Parse(txtLineTotal.Text);

            //calculate total Quantity
            decimal totQty = decimal.Parse(txtTotalQty.Text);
            totQty = totQty + Qty;

            //calculate grand total amount
            decimal grandTotal = decimal.Parse(txtGndTotal.Text);
            grandTotal = grandTotal + lineTotal;

            //Get Ticket category
            string category = Tdal.GetTicketCategory(Tname, Supplier);

            //check wether the ticket name is search or not and qty
            if (Tname == "" || Qty == 0)
            {
                //Display Error message
                MessageBox.Show("Invalid Ticket or Quantity!");
            }
            else if (category == "" || category == "Draw" || category == "Special Draw")
            {
                MessageBox.Show("Cannot add Draw Tickets");
            }
            else
            {
                //Add ticket to the data Grid view
                purchaseDT.Rows.Add(Tname, Uprice, Qty, lineTotal, Supplier);

                //Show in DataGridView
                dgvInsPurchases.DataSource = purchaseDT;
                clear();
                txtGndTotal.Text = grandTotal.ToString();
                txtTotalQty.Text = totQty.ToString();
            }
        }

        private void clear()
        {
            txtSearch.Text = "";
            txtTickName.Text = "";
            txtUprice.Text = "0";
            txtQty.Text = "0";
            txtSup.Text = "";
            txtLineTotal.Text = "0";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Get the value from PurchaseFrm
            Purchase_TransactionBLL pur_Trans = new Purchase_TransactionBLL();

            pur_Trans.supplier = cmbSupplier.Text;
            pur_Trans.inv_no = txtInvNo.Text;
            pur_Trans.inv_date = DateTime.Parse(dtpInvDate.Text);
            pur_Trans.total_quantity = decimal.Parse(txtTotalQty.Text);
            pur_Trans.grand_total = Math.Round(decimal.Parse(txtGndTotal.Text), 2);
            pur_Trans.added_date = DateTime.Now;
            pur_Trans.category = txtCat.Text;

            //get the username of logged in user
            string username = Login.loggedIn;
            userBLL usr = Udal.GetUsername(username);

            pur_Trans.added_by = usr.username;
            pur_Trans.PurchaseTrans = purchaseDT;

            bool isSuccess = false;

            //actual code to insert Purchase and Purchase_Transactions
            using (TransactionScope scope = new TransactionScope())
            {
                int pur_tranID = -1;

                //Insert Purchase_Transactions into Database
                bool PT = ptDAL.Insert_Puechase_Transaction(pur_Trans, out pur_tranID);

                //Use for loop to insert purchases
                for (int i = 0; i < purchaseDT.Rows.Count; i++)
                {
                    //Get all the purchases 
                    Instant_PurchasesBLL InsPurchase = new Instant_PurchasesBLL();

                    InsPurchase.ticket_name = purchaseDT.Rows[i][0].ToString();
                    InsPurchase.supplier = purchaseDT.Rows[i][4].ToString();
                    InsPurchase.unit_price = decimal.Parse(purchaseDT.Rows[i][1].ToString());
                    InsPurchase.quantity = decimal.Parse(purchaseDT.Rows[i][2].ToString());
                    InsPurchase.line_total = Math.Round(decimal.Parse(purchaseDT.Rows[i][3].ToString()), 2);
                    InsPurchase.inv_no = txtInvNo.Text;
                    InsPurchase.inv_date = DateTime.Parse(dtpInvDate.Text);
                    InsPurchase.added_date = DateTime.Now;
                    InsPurchase.added_by = usr.username;

                    //Get InsStock
                    Instant_StockBLL InsStock = new Instant_StockBLL();

                    InsStock.ticket_name = purchaseDT.Rows[i][0].ToString();
                    InsStock.supplier = purchaseDT.Rows[i][4].ToString();
                    InsStock.quantity = decimal.Parse(purchaseDT.Rows[i][2].ToString());

                    bool stkSuccess = false;
                    stkSuccess = istkDal.Increase_InsStockQty(InsStock, InsStock.ticket_name, InsStock.quantity);

                    //Insert Purchasess into Database
                    bool P = IpDal.Insert_InstantPurchases(InsPurchase);
                    isSuccess = PT && P && stkSuccess;
                }

                if (isSuccess == true)
                {
                    //Purchase Complete
                    scope.Complete();
                    MessageBox.Show("Successfully added new Purchase");

                    dgvInsPurchases.DataSource = null;
                    dgvInsPurchases.Rows.Clear();
                    dgvInsPurchases.Refresh();

                    //Clear the data grid view and all the txt boxes                  
                    txtInvNo.Text = "";
                    dtpInvDate.Text = "";
                    cmbSupplier.Text = "";
                    txtSearch.Text = "";
                    txtTickName.Text = "";
                    txtSup.Text = "";
                    txtUprice.Text = "0";
                    txtQty.Text = "0";
                    txtLineTotal.Text = "0";
                    txtTotalQty.Text = "0";
                    txtGndTotal.Text = "0";
                }
                else
                {
                    //Purchase fail
                    MessageBox.Show("Failed to add..!");
                }
            }
        }
    


    }
}
