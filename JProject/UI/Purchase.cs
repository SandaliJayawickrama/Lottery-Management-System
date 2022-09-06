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
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }

        DataTable purchaseDT = new DataTable();
        userDAL userDal = new userDAL();
        PO_TransactionDAL PoTransDal = new PO_TransactionDAL();
        Purchase_OrderDAL PoDal = new Purchase_OrderDAL();      
        StockDAL stkDal = new StockDAL();
        Instant_StockDAL InsStkDal = new Instant_StockDAL();
        PurchaseDAL purDal = new PurchaseDAL();
        Balance_TransactionDAL balDal = new Balance_TransactionDAL();

        private void Purchase_Load(object sender, EventArgs e)
        {
            //Specify columns for Purchase DataTable
            purchaseDT.Columns.Add("Ticket Name");           
            purchaseDT.Columns.Add("Draw Date");
            purchaseDT.Columns.Add("Draw No");
            purchaseDT.Columns.Add("Order Qty");
            purchaseDT.Columns.Add("Recieved Qty");
            purchaseDT.Columns.Add("Line Total");           
            purchaseDT.Columns.Add("Starting Bcode");
            purchaseDT.Columns.Add("Ending Bcode");
            purchaseDT.Columns.Add("Unit Price");
            purchaseDT.Columns.Add("PO Id");
        }

        private void txtSearchPo_TextChanged(object sender, EventArgs e)
        {
            //Get the keyword from searching txtBox
            string keyword = txtSearchPo.Text;

            //Check the value
            if (keyword == "")
            {
                txtPoNo.Text = "";
                txtSupplier1.Text = "";
                txtCategory.Text = "";
                txtPoDate.Text = "";            
                return;
            }

            //Searched PO details displaying respective values on the txtBoxes
            PO_TransactionBLL pt = PoTransDal.SearchPoNo_ForPurchase(keyword);

            //Set the values on textboxes, based on pt object
            txtPoNo.Text = pt.po_no;
            txtPoDate.Text = pt.po_date.ToString("yyyy-MM-dd");
            txtSupplier1.Text = pt.supplier;
            txtCategory.Text = pt.category;
        }

        private void txtPoNo_TextChanged(object sender, EventArgs e)
        {
            string PoNo = txtPoNo.Text;

            //string sup = txtSupplier1.Text;

            if (PoNo == "" )
            {
                dgvOrder.DataSource = null;
            }
            else
            {
                //Display available order details in Data Grid View
                DataTable dt = PoDal.SelectPurchaseOrders(PoNo);
                dgvOrder.DataSource = dt;
            }
        }

        private void dgvOrder_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the index of particular row
            int rowIndex = e.RowIndex;

            decimal ordQty = decimal.Parse(dgvOrder.Rows[rowIndex].Cells[3].Value.ToString());
            decimal recQty = decimal.Parse(dgvOrder.Rows[rowIndex].Cells[4].Value.ToString());
            decimal balance = ordQty - recQty;

            DateTime drdate = DateTime.Parse(dgvOrder.Rows[rowIndex].Cells[2].Value.ToString());

            txtTickName.Text = dgvOrder.Rows[rowIndex].Cells[1].Value.ToString();
            txtDrDate.Text = drdate.ToString("yyyy-MM-dd");           
            txtOrdQty.Text = dgvOrder.Rows[rowIndex].Cells[3].Value.ToString();
            txtUprice.Text = dgvOrder.Rows[rowIndex].Cells[5].Value.ToString();
            txtPoId.Text = dgvOrder.Rows[rowIndex].Cells[6].Value.ToString();           
            txtBalQty.Text = balance.ToString();
        }

        private void txtRecQty_TextChanged(object sender, EventArgs e)
        {
            if (txtRecQty.Text.ToString() == "")
            {
                txtRecQty.Text = "0";
            }
            else
            {
                //Get values from txt boxses
                decimal StBcode = decimal.Parse(txtStBcode.Text);
                decimal qty = decimal.Parse(txtRecQty.Text);
                decimal Uprice = decimal.Parse(txtUprice.Text);

                //calculate Ending-Bcode & Line-Total
                decimal EdBcode = StBcode + qty - 1;
                decimal lineTot = Uprice * qty;

                //Set Ending BCode & line total
                txtEdBcode.Text = EdBcode.ToString();
                txtLineTotal.Text = lineTot.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal BalQty = decimal.Parse(txtBalQty.Text);
            string tikName = txtTickName.Text;
            string drDate = txtDrDate.Text.ToString();
            string drNo = txtDrno.Text;
            decimal OrdQty = decimal.Parse(txtOrdQty.Text);
            decimal RecQty = decimal.Parse(txtRecQty.Text);
            decimal lineTot = decimal.Parse(txtLineTotal.Text);
            string STBcode = txtStBcode.Text;
            string EDBcode = txtEdBcode.Text;
            decimal uPrice = decimal.Parse(txtUprice.Text);        
            int  PoId = int.Parse(txtPoId.Text);
            
            //calculate total quantity
            decimal tot_Qty = decimal.Parse(txtTotalQty.Text);
            tot_Qty = tot_Qty + RecQty;

            //calculate grand Total amount
            decimal grandTotal = decimal.Parse(txtGndTotal.Text);
            grandTotal = grandTotal + lineTot;

            //Check whethere the poId is duplicate or not
            bool isPoId = true;
            for (int i = 0; i < purchaseDT.Rows.Count; i++)
            {
                int chk_poId = int.Parse(purchaseDT.Rows[i][9].ToString());           
                if (PoId == chk_poId) 
                {
                    isPoId = false;
                    break;
                }
            }

            //check wether the required details are filled or not
            if (tikName == "" || STBcode == "0" || EDBcode == "" || RecQty == 0)
            {
                // Display Error message
                MessageBox.Show("Please fill required details");
            }
            else if (RecQty > BalQty)
            {
                // Display Error message
                MessageBox.Show("Invalid Recieved Quantity!");
            }
            else if (isPoId != true)
            {
                // Display Error message
                MessageBox.Show("Item Duplicated!");
            }
            else
            {
                //Add purchases to the Recieved data Grid view
                purchaseDT.Rows.Add(tikName, drDate, drNo, OrdQty, RecQty, lineTot, STBcode, EDBcode, uPrice, PoId);

                //Show data in recieved Data Grid view 
                dgvRecieved.DataSource = purchaseDT;

                //Clear text boxes
                clear();

                txtTotalQty.Text = tot_Qty.ToString();
                txtGndTotal.Text = grandTotal.ToString();

                //Remove data from Stock DataGridView
                dgvOrder.Rows.Remove(dgvOrder.CurrentRow);                
            }
        }

        private void clear()
        {
            txtTickName.Text = "";
            txtDrDate.Text = "";
            txtPoId.Text = "";
            txtUprice.Text = "0";
            txtOrdQty.Text = "0";
            txtBalQty.Text = "0";
            txtDrno.Text = "";
            txtRecQty.Text = "0";
            txtLineTotal.Text = "0";
            txtStBcode.Text = "0";
            txtEdBcode.Text = "";
        }

        private void clearAll()
        {
            txtSearchPo.Text = "";
            txtPoNo.Text = "";
            txtPoDate.Text = "NULL";
            txtSupplier1.Text = "";
            txtCategory.Text = "";
            txtTotalQty.Text = "0";
            txtGndTotal.Text = "0";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //get the username of logged in user
            string username = Login.loggedIn;
            userBLL usr = userDal.GetUsername(username);

            bool isSuccess = false;

            //Get current balance qty & amount from PO_Transaction table
            string PoNo = txtPoNo.Text;
            string sup = txtSupplier1.Text;
            PO_TransactionBLL ptBll = PoTransDal.GetCurrentBalances(PoNo, sup);
            decimal curBalQty = decimal.Parse(ptBll.balance_qty.ToString());
            decimal curBalAmount = decimal.Parse(ptBll.balance_amount.ToString());

            //calculate new balances
            decimal recQty = decimal.Parse(txtTotalQty.Text);
            decimal recAmount = decimal.Parse(txtGndTotal.Text);

            decimal newBalQty = curBalQty - recQty;
            decimal newBalAmount = curBalAmount - recAmount; 

            using (TransactionScope scope = new TransactionScope())
            {
                //Update Balance Quantity & amount in PO_Transaction table               
                bool PO_TransSuccess = PoTransDal.Update_Balances(PoNo, sup, newBalQty, newBalAmount);


                //Use for loop to insert purchases
                for (int i = 0; i < purchaseDT.Rows.Count; i++)
                {
                    PurchaseBLL purBll = new PurchaseBLL();

                    purBll.supplier = txtSupplier1.Text;
                    purBll.po_no = txtPoNo.Text;
                    purBll.po_date = DateTime.Parse(txtPoDate.Text);
                    purBll.ticket_Name = purchaseDT.Rows[i][0].ToString();
                    purBll.unit_price = decimal.Parse(purchaseDT.Rows[i][8].ToString());
                    purBll.draw_no = purchaseDT.Rows[i][2].ToString();
                    purBll.draw_date = DateTime.Parse(purchaseDT.Rows[i][1].ToString());
                    purBll.starting_Bcode = purchaseDT.Rows[i][6].ToString();
                    purBll.ending_Bcode = purchaseDT.Rows[i][7].ToString();
                    purBll.order_qty = decimal.Parse(purchaseDT.Rows[i][3].ToString());
                    purBll.recieved_qty = decimal.Parse(purchaseDT.Rows[i][4].ToString());
                    purBll.line_total = decimal.Parse(purchaseDT.Rows[i][5].ToString());
                    purBll.added_date = DateTime.Now;
                    purBll.added_by = usr.username;

                    //Update Recieved Quantity in Purchase_Order table
                    decimal newRecQty = decimal.Parse(purchaseDT.Rows[i][4].ToString());
                    string tname = purchaseDT.Rows[i][0].ToString();
                    int poId = int.Parse(purchaseDT.Rows[i][9].ToString());

                    decimal getCrrentRecQty = PoDal.GetCurrentRecQuantity(poId, tname);
                    decimal totRecQty = getCrrentRecQty + newRecQty;

                    bool pur_OrdSuccess = PoDal.UpdateRecQantity_PO(poId,tname,totRecQty);                   

                    //update stock
                    bool stockSuccess = false;
                    string TickCategory = txtCategory.Text;

                    if (TickCategory == "Draw" || TickCategory == "Special Draw")
                    {
                        StockBLL stock = new StockBLL();

                        stock.ticket_name = purchaseDT.Rows[i][0].ToString();
                        stock.starting_Bcode = purchaseDT.Rows[i][6].ToString();
                        stock.ending_Bcode = purchaseDT.Rows[i][7].ToString();
                        stock.draw_no = purchaseDT.Rows[i][2].ToString();
                        stock.draw_date = DateTime.Parse(purchaseDT.Rows[i][1].ToString());
                        stock.quantity = decimal.Parse(purchaseDT.Rows[i][4].ToString());
                        stock.supplier = txtSupplier1.Text;

                        stockSuccess = stkDal.InsertStock(stock);
                    }
                    else if (TickCategory == "Instant" || TickCategory == "Special Instant")
                    {
                        Instant_StockBLL insStk = new Instant_StockBLL();

                        insStk.ticket_name = purchaseDT.Rows[i][0].ToString();
                        insStk.supplier = txtSupplier1.Text;
                        insStk.quantity = decimal.Parse(purchaseDT.Rows[i][4].ToString());

                        //stockSuccess = InsStkDal.Insert_InsStock(insStk);
                        stockSuccess = InsStkDal.Increase_InsStockQty(insStk, insStk.ticket_name, insStk.quantity);
                    }

                    //Insert purchase into Database
                    bool purchaseSuccess = purDal.InsertPurchases(purBll);
                    isSuccess = purchaseSuccess &&  PO_TransSuccess && stockSuccess && pur_OrdSuccess;
                }

                //Updatee balances in Balance Transaction table
                Balance_TransactionBLL balBll = new Balance_TransactionBLL();
                DataTable balDT = balDal.SelectLastRowBalances();

                balBll.Description = "Stock Received";
                balBll.Cash = decimal.Parse(balDT.Rows[0][2].ToString());
                balBll.Bank = decimal.Parse(balDT.Rows[0][3].ToString());
                balBll.Stock = decimal.Parse(balDT.Rows[0][4].ToString()) + decimal.Parse(txtGndTotal.Text);
                balBll.Win_Nlb = decimal.Parse(balDT.Rows[0][5].ToString());
                balBll.Win_Dlb = decimal.Parse(balDT.Rows[0][6].ToString());
                balBll.Credi_recievables = decimal.Parse(balDT.Rows[0][7].ToString());
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

                if (txtSupplier1.Text == "NLB")
                {                  
                    balBll.Stock_recievablesNLB = decimal.Parse(balDT.Rows[0][8].ToString()) - decimal.Parse(txtGndTotal.Text);
                    balBll.Stock_recievablesDLB = decimal.Parse(balDT.Rows[0][9].ToString());
                }
                else if (txtSupplier1.Text == "DLB")
                {                   
                    balBll.Stock_recievablesDLB = decimal.Parse(balDT.Rows[0][9].ToString()) - decimal.Parse(txtGndTotal.Text);
                    balBll.Stock_recievablesNLB = decimal.Parse(balDT.Rows[0][8].ToString());
                }              

                balBll.added_date = DateTime.Now;
                balBll.added_by = usr.username;

                bool isBalanceSettle = balDal.UpdateTransactionBalance(balBll);

                string poNumber = txtPoNo.Text;
                //string tickName = txtTickName.Text;

                if (isSuccess == true && poNumber != "" && isBalanceSettle == true)
                {
                    scope.Complete();
                    MessageBox.Show("Transaction Successfull");

                    //Clear the Order data grid view 
                    dgvOrder.DataSource = null;
                    dgvOrder.Rows.Clear();
                    dgvOrder.Refresh();

                    //Clear the Recieved data grid view 
                    dgvRecieved.DataSource = null;
                    dgvRecieved.Rows.Clear();
                    dgvRecieved.Refresh();

                    //Clear all the txt boxes
                    clear();
                    clearAll();
                }
                else
                {
                    MessageBox.Show("Faild to add stock");
                }
            }
        }

        private void txtPoNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtPoDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtSupplier1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtCategory_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPoId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtOrdQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtDrDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtBalQty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtEdBcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
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

        private void txtUprice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtRecQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
