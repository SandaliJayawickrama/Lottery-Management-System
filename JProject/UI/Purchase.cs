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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace JProject.UI
{
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }

        TicketsDAL Tdal = new TicketsDAL();
        DataTable purchaseDT = new DataTable();
        userDAL Udal = new userDAL();
        PurchaseDAL pDAL = new PurchaseDAL();
        Purchase_TransactionDAL ptDAL = new Purchase_TransactionDAL();
        StockDAL StDal = new StockDAL();
 
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            //Specify columns for PurchaseDataTable
            purchaseDT.Columns.Add("Ticket Name");
            purchaseDT.Columns.Add("Unit price");
            purchaseDT.Columns.Add("Quantity");
            purchaseDT.Columns.Add("Total");
            purchaseDT.Columns.Add("Starting Bcode");
            purchaseDT.Columns.Add("Ending Bcode");
            purchaseDT.Columns.Add("Draw No");
            purchaseDT.Columns.Add("Draw date");
            purchaseDT.Columns.Add("Supplier");
        }

        private void txtLineTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Get the keyword from searching txtBox
            string keyword = txtSearch.Text;

            //Check the value
            if (keyword=="")
            {
                txtTickName.Text = "";
                txtSup.Text = "";
                txtUprice.Text = "0";
                txtDrno.Text = "";
                dtpDrdate.Text = "";
                txtStBcode.Text = "0";
                txtQty.Text = "0";
                txtEdBcode.Text = "";
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
                decimal StBcode = decimal.Parse(txtStBcode.Text);

                //calculate Line-Total & Ending-Barcode
                decimal lineTotal = Uprice * Qty;
                decimal endBcode = StBcode + Qty - 1;

                //display line-total & & Ending-Barcode in text boxes
                txtLineTotal.Text = lineTotal.ToString();
                txtEdBcode.Text = endBcode.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string Tname = txtTickName.Text;
            string Supplier = txtSup.Text;
            decimal Uprice = decimal.Parse(txtUprice.Text);
            string drawNo = txtDrno.Text;
            DateTime drawDate = DateTime.Parse(dtpDrdate.Text);
            string STcode = txtStBcode.Text;
            decimal Qty = decimal.Parse(txtQty.Text);
            string EDcode = txtEdBcode.Text;           
            decimal lineTotal = decimal.Parse(txtLineTotal.Text);

            //calculate total Quantity
            decimal totQty = decimal.Parse(txtTotalQty.Text);
            totQty = totQty + Qty;

            //calculate grand total amount
            decimal grandTotal = decimal.Parse(txtGndTotal.Text);
            grandTotal = grandTotal + lineTotal;

            //Get Ticket category
            string category = Tdal.GetTicketCategory(Tname, Supplier);

            //check wether the ticket name is search or not
            if (Tname=="" || Qty == 0)
            {
                //Display Error message
                MessageBox.Show("Invalid Ticket or Quantity!");
            }
            else if(category=="" || category== "Instant" || category== "Special Instant")
            {
                MessageBox.Show("Cannot add Instant Tickets");
            }
            else
            {
                //Add ticket to the data Grid view
                purchaseDT.Rows.Add(Tname, Uprice, Qty, lineTotal, STcode, EDcode, drawNo, drawDate, Supplier);
                
                //Show in DataGridView
                dgvPurchases.DataSource = purchaseDT;
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
            txtDrno.Text = "";
            dtpDrdate.Text = "";
            txtStBcode.Text = "0";
            txtQty.Text = "0";
            txtEdBcode.Text = "";
            txtLineTotal.Text = "0";
            txtSup.Text = "";
        }

        private void txtTname_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46 )
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

        private void txtCat_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void lblSupplier1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Get the value from PurchaseFrm
            Purchase_TransactionBLL pur_Trans = new Purchase_TransactionBLL();
            
            pur_Trans.inv_no = txtInvNo.Text;
            pur_Trans.supplier = cmbSupplier.Text;
            pur_Trans.total_quantity = decimal.Parse(txtTotalQty.Text);
            pur_Trans.grand_total = Math.Round(decimal.Parse(txtGndTotal.Text),2);
            pur_Trans.inv_date = DateTime.Parse(dtpInvDate.Text);
            pur_Trans.added_date = DateTime.Now;
            pur_Trans.category = txtCat.Text;

            //get the username of logged in user
            string username = Login.loggedIn;
            userBLL usr = Udal.GetUsername(username);

            pur_Trans.added_by = usr.username;
            pur_Trans.PurchaseTrans = purchaseDT;

            bool isSuccess = false;

            //actual code to insert Purchase and Purchase_Transactions
            using (TransactionScope scope = new TransactionScope() )
            {
                int pur_tranID = -1;

                //Insert Purchase_Transactions into Database
                bool PT = ptDAL.Insert_Puechase_Transaction(pur_Trans, out pur_tranID);

                //Use for loop to insert purchases
                for(int i=0; i<purchaseDT.Rows.Count; i++)
                {
                    //Get all the purchases 
                    PurchaseBLL purchase = new PurchaseBLL();

                    purchase.ticket_Name = purchaseDT.Rows[i][0].ToString();
                    purchase.unit_price = decimal.Parse(purchaseDT.Rows[i][1].ToString());
                    purchase.draw_No = purchaseDT.Rows[i][6].ToString();
                    purchase.draw_date = DateTime.Parse(purchaseDT.Rows[i][7].ToString());
                    purchase.starting_Bcode = purchaseDT.Rows[i][4].ToString();
                    purchase.ending_Bcode = purchaseDT.Rows[i][5].ToString();
                    purchase.quantity = decimal.Parse(purchaseDT.Rows[i][2].ToString());
                    purchase.line_total = Math.Round(decimal.Parse(purchaseDT.Rows[i][3].ToString()),2);
                    purchase.inv_no = txtInvNo.Text;
                    purchase.inv_date = DateTime.Parse(dtpInvDate.Text);
                    purchase.added_date = DateTime.Now;
                    purchase.added_by = usr.username;
                    purchase.supplier = purchaseDT.Rows[i][8].ToString();

                    //Get Stock
                    StockBLL stock = new StockBLL();

                    stock.ticket_name = purchaseDT.Rows[i][0].ToString();
                    stock.starting_Bcode = purchaseDT.Rows[i][4].ToString();
                    stock.ending_Bcode = purchaseDT.Rows[i][5].ToString();
                    stock.draw_no = purchaseDT.Rows[i][6].ToString();
                    stock.draw_date = DateTime.Parse(purchaseDT.Rows[i][7].ToString());
                    stock.quantity = decimal.Parse(purchaseDT.Rows[i][2].ToString());
                    stock.supplier = purchaseDT.Rows[i][8].ToString();

                    bool stkSuccess = false;
                    stkSuccess = StDal.InsertStock(stock);

                    //Insert Purchasess into Database
                    bool P = pDAL.InsertPurchases(purchase);
                    isSuccess = PT && P && stkSuccess;
                }
              
                if (isSuccess == true)
                {
                    //Purchase Complete
                    scope.Complete();
                    MessageBox.Show("Successfully added new Purchase");

                    dgvPurchases.DataSource = null;
                    dgvPurchases.Rows.Clear();
                    dgvPurchases.Refresh();

                    //Clear the data grid view and all the txt boxes                  
                    txtInvNo.Text = "";
                    dtpInvDate.Text = "";
                    cmbSupplier.Text = "";
                    txtTotalQty.Text = "0";
                    txtGndTotal.Text = "0";
                    txtSearch.Text = "";
                    txtSup.Text = "";
                    txtTickName.Text = "";
                    txtUprice.Text = "0";
                    txtDrno.Text = "";
                    dtpDrdate.Text = "";
                    txtStBcode.Text = "0";
                    txtQty.Text = "0";
                    txtEdBcode.Text = "";
                    txtLineTotal.Text = "0";
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
