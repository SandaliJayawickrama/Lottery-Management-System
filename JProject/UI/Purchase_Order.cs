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
    public partial class Purchase_Order : Form
    {
        public Purchase_Order()
        {
            InitializeComponent();
        }

        DataTable purOrderDT = new DataTable();
        TicketsDAL ticketDal = new TicketsDAL();
        userDAL Udal = new userDAL();
        Purchase_OrderDAL putOrderDal = new Purchase_OrderDAL();
        PO_TransactionDAL PoTransDal = new PO_TransactionDAL();

        private void Purchase_Order_Load(object sender, EventArgs e)
        {
            txtPoNo.Text = PoTransDal.CreatePurchaseOrderNo();

            //Specify columns for PurchaseDataTable          
            purOrderDT.Columns.Add("Ticket Name");
            purOrderDT.Columns.Add("Draw date");
            purOrderDT.Columns.Add("Unit price");
            purOrderDT.Columns.Add("Quantity");
            purOrderDT.Columns.Add("Line Total");
            purOrderDT.Columns.Add("PO No");
            purOrderDT.Columns.Add("PO Date");
            purOrderDT.Columns.Add("Supplier");
        }

        private void txtPoNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtCat_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
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
                dtpDrdate.Text = "";
                txtQty.Text = "0";
                txtLineTotal.Text = "0";
                return;
            }

            //Searching ticket details display respective values on the txtBoxes
            ticketsA_BLL t = ticketDal.SearchTicket_ForPuechase(keyword);

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

                //display line-total in text boxes
                txtLineTotal.Text = lineTotal.ToString();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Tname = txtTickName.Text;
            DateTime drawDate = DateTime.Parse(dtpDrdate.Text);
            decimal Uprice = decimal.Parse(txtUprice.Text);
            decimal Qty = decimal.Parse(txtQty.Text);
            decimal lineTotal = decimal.Parse(txtLineTotal.Text);
            string poNo = txtPoNo.Text;
            DateTime poDate = DateTime.Parse(dtpPoDate.Text);
            string Supplier = txtSup.Text;

            //Calculate total Quantity
            decimal totQty = decimal.Parse(txtTotalQty.Text);
            totQty = totQty + Qty;

            //calculate grand total amount
            decimal grandTotal = decimal.Parse(txtGndTotal.Text);
            grandTotal = grandTotal + lineTotal;

            //Get Ticket category
            string category = ticketDal.GetTicketCategory(Tname, Supplier);

            //check wether the ticket name is search or not
            if (Tname == "" || Qty == 0)
            {
                //Display Error message
                MessageBox.Show("Enter all details");
            }
            else if (category == "" || category == "Instant" || category == "Special Instant")
            {
                MessageBox.Show("Cannot add Instant Tickets");
            }
            else
            {
                //Add ticket to the data Grid view
                purOrderDT.Rows.Add(Tname, drawDate, Uprice, Qty, lineTotal, poNo, poDate, Supplier);

                //Show in DataGridView
                dgvPurchases.DataSource = purOrderDT;
                clear();
                txtGndTotal.Text = grandTotal.ToString();
                txtTotalQty.Text = totQty.ToString();
            }
        }

        private void clear()
        {
            txtSearch.Text = "";
            txtTickName.Text = "";
            dtpDrdate.Text = "";
            txtUprice.Text = "0";   
            txtQty.Text = "0";
            txtLineTotal.Text = "0";
            txtSup.Text = "";
        }

        private void txtTickName_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtSup_KeyPress(object sender, KeyPressEventArgs e)
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


        private decimal BalanceCalculation()
        {
            decimal total = decimal.Parse(txtGndTotal.Text);
            decimal cash = decimal.Parse(txtCash.Text);
            decimal bank = decimal.Parse(txtBank.Text);
            decimal scanNlb = decimal.Parse(txtScanNlb.Text);
            decimal scanDlb = decimal.Parse(txtScanDlb.Text);
            decimal retNlb = decimal.Parse(txtRetNlb.Text);
            decimal retDlb = decimal.Parse(txtRetDlb.Text);
            decimal credit = decimal.Parse(txtCredit.Text);

            decimal balance = total - (cash + bank + scanNlb + scanDlb + retNlb + retDlb + credit);

            if (cash == 0 && bank == 0 && scanNlb == 0 && scanDlb == 0 && retNlb == 0 && retDlb == 0 && credit == 0)
            {
                balance = total;
            }

            return balance;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            decimal balance = BalanceCalculation();

            txtBalance.Text = balance.ToString();
        }

        private void txtBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Get the value from PurchaseFrm
            PO_TransactionBLL Po_Trans = new PO_TransactionBLL();

            Po_Trans.supplier = cmbSupplier.Text;
            Po_Trans.po_no = txtPoNo.Text;
            Po_Trans.po_date = DateTime.Parse(dtpPoDate.Text);
            Po_Trans.total_quantity = decimal.Parse(txtTotalQty.Text);
            Po_Trans.grand_total = Math.Round(decimal.Parse(txtGndTotal.Text), 2);
            Po_Trans.added_date = DateTime.Now;
            Po_Trans.category = txtCat.Text;
            Po_Trans.cash = decimal.Parse(txtCash.Text);
            Po_Trans.bank = decimal.Parse(txtBank.Text);
            Po_Trans.scan_nlb = decimal.Parse(txtScanNlb.Text);
            Po_Trans.scan_dlb = decimal.Parse(txtScanDlb.Text);
            Po_Trans.return_nlb = decimal.Parse(txtRetNlb.Text);
            Po_Trans.return_dlb = decimal.Parse(txtRetDlb.Text);
            Po_Trans.credit = decimal.Parse(txtCredit.Text);
            Po_Trans.balance_qty = decimal.Parse(txtTotalQty.Text);
            Po_Trans.balance_amount = Math.Round(decimal.Parse(txtGndTotal.Text), 2);

            //get the username of logged in user
            string username = Login.loggedIn;
            userBLL usr = Udal.GetUsername(username);

            Po_Trans.added_by = usr.username;
            Po_Trans.PurchaseTrans = purOrderDT;

            bool isSuccess = false;

            //actual code to insert Purchase and Purchase_Transactions
            using (TransactionScope scope = new TransactionScope())
            {
                int pur_tranID = -1;

                //Insert PO_Transaction into Database
                bool PT = PoTransDal.Insert_PO_Transaction(Po_Trans, out pur_tranID);

                //Use for loop to insert purchases
                for (int i = 0; i < purOrderDT.Rows.Count; i++)
                {
                    //Get all the purchases 
                    Purchase_OrderBLL pur_order = new Purchase_OrderBLL();
                    PurchaseBLL purchase = new PurchaseBLL();

                    pur_order.ticket_Name = purOrderDT.Rows[i][0].ToString();
                    pur_order.draw_date = DateTime.Parse(purOrderDT.Rows[i][1].ToString());
                    pur_order.unit_price = decimal.Parse(purOrderDT.Rows[i][2].ToString());
                    pur_order.order_quantity = decimal.Parse(purOrderDT.Rows[i][3].ToString());
                    pur_order.line_total = Math.Round(decimal.Parse(purOrderDT.Rows[i][4].ToString()), 2);
                    pur_order.po_no = txtPoNo.Text;
                    pur_order.po_date = DateTime.Parse(dtpPoDate.Text);
                    pur_order.added_date = DateTime.Now;
                    pur_order.added_by = usr.username;
                    pur_order.supplier = purOrderDT.Rows[i][7].ToString();

                    //Insert Purchases order into Database
                    bool P = putOrderDal.InsertPurchaseOrders(pur_order);
                    isSuccess = PT && P;

                    //Get Stock
                    /*StockBLL stock = new StockBLL();

                    stock.ticket_name = purOrderDT.Rows[i][0].ToString();
                    stock.starting_Bcode = purOrderDT.Rows[i][4].ToString();
                    stock.ending_Bcode = purOrderDT.Rows[i][5].ToString();
                    stock.draw_no = purOrderDT.Rows[i][6].ToString();
                    stock.draw_date = DateTime.Parse(purOrderDT.Rows[i][7].ToString());
                    stock.quantity = decimal.Parse(purOrderDT.Rows[i][2].ToString());
                    stock.supplier = purOrderDT.Rows[i][8].ToString();

                    bool stkSuccess = false;
                    stkSuccess = StDal.InsertStock(stock);*/
                }

                decimal balance = BalanceCalculation();
                txtBalance.Text = balance.ToString();

                if (isSuccess == true && balance == 0 && cmbSupplier.Text != "")
                {
                    //Purchase Complete
                    scope.Complete();
                    MessageBox.Show("Successfully added Purchase Order");

                    dgvPurchases.DataSource = null;
                    dgvPurchases.Rows.Clear();
                    dgvPurchases.Refresh();

                    //Clear the data grid view and all the txt boxes                  
                    txtPoNo.Text = "";
                    dtpPoDate.Text = "";
                    cmbSupplier.Text = "";
                    txtSearch.Text = "";
                    txtTickName.Text = "";
                    txtSup.Text = "";
                    txtUprice.Text = "0";
                    dtpDrdate.Text = "";
                    txtQty.Text = "0";
                    txtLineTotal.Text = "0";
                    txtTotalQty.Text = "0";
                    txtGndTotal.Text = "0";               
                    txtCash.Text = "0";
                    txtBank.Text = "0";
                    txtScanNlb.Text = "0";
                    txtScanDlb.Text = "0";
                    txtRetNlb.Text = "0";
                    txtRetDlb.Text = "0";
                    txtCredit.Text = "0";
                    txtBalance.Text = "0";
                }
                else
                {
                    //Purchase fail
                    MessageBox.Show("Failed to add..!");
                }
            }
        }

        private void txtCredit_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtRetNlb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtRetDlb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtScanNlb_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtScanDlb_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
