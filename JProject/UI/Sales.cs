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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        userDAL uDal = new userDAL();
        AgentDAL agDal = new AgentDAL();
        TicketsDAL Tdal = new TicketsDAL();
        StockDAL stkDal = new StockDAL();
        Sales_TransactionDAL salesDal = new Sales_TransactionDAL();
        DataTable SalesDT = new DataTable();
        SalesDAL Sdal = new SalesDAL();
        Instant_StockDAL InsStkDal = new Instant_StockDAL();

        private void txtAgentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchAgent_TextChanged(object sender, EventArgs e)
        {
            //Get the keyword from searching txtBox
            string keyword = txtSearchAgent.Text;

            //Check the value
            if (keyword == "")
            {
                txtAgentName.Text = "";
                txtAgentNo.Text = "";
                return;
            }

            //Searching agent details display respective values on the txtBoxes
            AgentBLL ag = agDal.SearchAgent_ForSales(keyword);

            //Set the values on textboxes, based on ag object
            txtAgentName.Text = ag.agent_name;
            txtAgentNo.Text = ag.agent_no;
        }

        private void txtSearchTicket_TextChanged(object sender, EventArgs e)
        {
            //Get the keyword from searching txtBox
            string keyword = txtSearchTicket.Text;

            //Check the value
            if (keyword == "")
            {
                txtTname.Text = "";
                txtSupplier.Text = "";
                txtUprice.Text = "0";
                txtDrawNo.Text = "";
                txtDrawDate.Text = "";
                txtStBcode.Text = "0";
                txtQty.Text = "0";
                txtEdBcode.Text = "";
                txtLineTotal.Text = "0";
                txtInventory.Text = "0";
                txtTotInven.Text = "0";
                return;
            }

            //Searching ticket details display respective values on the txtBoxes
            ticketsA_BLL t = Tdal.SearchTicket_ForPuechase(keyword);

            //Set the values on textboxes, based on t object
            txtTname.Text = t.ticket_name;
            txtSupplier.Text = t.ticket_type;
            txtUprice.Text = t.ticket_Uprice.ToString();
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

        private void txtSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtTname_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtInventory_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtInvNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtDrawDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtDrawDate_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void txtTotAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtStBcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtTotInven_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void lblTname_Click(object sender, EventArgs e)
        {

        }

        private void dgvSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtInventory_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvSalesStock_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void txtDrawDate_TextChanged(object sender, EventArgs e)
        {

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvSalesStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void txtTname_TextChanged(object sender, EventArgs e)
        {
            string Tname = txtTname.Text;
            string sup = txtSupplier.Text;
            string category = Tdal.GetTicketCategory(Tname, sup);

            if(category== "Instant" || category== "Special Instant")
            {
                decimal inventory = 0;
                inventory = InsStkDal.Get_InsInventoryBalance(Tname, sup);

                //Set inventrory balance
                txtInventory.Text = inventory.ToString();
            }
        }     

        private void txtDrawNo_TextChanged(object sender, EventArgs e)
        {
            string tickName = txtTname.Text;
            string drawNo = txtDrawNo.Text;
            decimal inventory = 0;
            DateTime DrDate = new DateTime();

            if (tickName == "" || drawNo == "")
            {
                txtTotInven.Text = "0";
                txtDrawDate.Text = "";
                dgvSalesStock.DataSource = null;
            }
            else
            {
                //Display available inventories in Data Grid View
                DataTable dt = stkDal.SelectAvailableStock(tickName,drawNo);               
                dgvSalesStock.DataSource = dt;

                //Display Draw Date in Text Box
                DrDate = stkDal.GetDrawDate(drawNo, tickName);
                txtDrawDate.Text = DrDate.ToString("yyyy-MM-dd");

                if(dgvSalesStock.Rows.Count>0)
                {
                    //Display available Total inventories in Text Box
                    inventory = stkDal.GetCurrentTotalQty(drawNo, tickName);
                    txtTotInven.Text = inventory.ToString();
                }

            }
        }

        
        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            if (txtQty.Text.ToString() == "")
            {
                txtQty.Text = "0";
            }
            else
            {
                //Get values from txt boxses
                decimal StBcode = decimal.Parse(txtStBcode.Text);
                decimal qty = decimal.Parse(txtQty.Text);
                decimal Uprice = decimal.Parse(txtUprice.Text);

                //calculate Ending-Bcode & Line-Total
                decimal EdBcode = StBcode + qty - 1;
                decimal lineTot = Uprice * qty;


                //Get ticket category
                string Tname = txtTname.Text;
                string supplier = txtSupplier.Text;
                string Tcategory = Tdal.GetTicketCategory(Tname,supplier);

                //Set Ending Bcode if the category is Draw
                if (Tcategory == "Draw")
                {
                    txtEdBcode.Text = EdBcode.ToString();
                }
                else
                {
                    txtEdBcode.Text = "0";
                }
                //Set line total
                txtLineTotal.Text = lineTot.ToString();
            }
        }

        
        private void Sales_Load(object sender, EventArgs e)
        {
            txtInvNo.Text = salesDal.CreateSalesInvNo();

            //Specify columns for SalesDataTable
            SalesDT.Columns.Add("Ticket");
            SalesDT.Columns.Add("Draw no");
            SalesDT.Columns.Add("Draw date");
            SalesDT.Columns.Add("Unit Price");
            SalesDT.Columns.Add("Quantity");
            SalesDT.Columns.Add("Line Total");
            SalesDT.Columns.Add("Starting Bcode");
            SalesDT.Columns.Add("Ending Bcode");
            SalesDT.Columns.Add("Supplier");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tikName = txtTname.Text;
            string drNo = txtDrawNo.Text;
            string drDate = txtDrawDate.Text.ToString();
            decimal uPrice = decimal.Parse(txtUprice.Text);
            decimal qty = decimal.Parse(txtQty.Text);
            decimal lineTot = decimal.Parse(txtLineTotal.Text);
            string STBcode = txtStBcode.Text;
            string EDBcode = txtEdBcode.Text;
            string supplier = txtSupplier.Text;
            decimal inventory = decimal.Parse(txtInventory.Text);

            //calculate total quantity
            decimal tot_Qty = decimal.Parse(txtTotalQty.Text);
            tot_Qty = tot_Qty + qty;

            //calculate grand Total amount
            decimal grandTotal = decimal.Parse(txtTotAmount.Text);
            grandTotal = grandTotal + lineTot;

            //check wether the required details are filled or not
            if(tikName=="" || inventory==0 || qty == 0)
            {
                // Display Error message
                MessageBox.Show("Please fill required details");
            }
            else if(qty > inventory)
            {
                // Display Error message
                MessageBox.Show("Invalid Quantity");
            }
            else
            {
                SalesDT.Rows.Add(tikName, drNo, drDate, uPrice, qty, lineTot, STBcode, EDBcode, supplier);

                //Show in Data Grid view 
                dgvSales.DataSource = SalesDT;

                //Clear the data grid view 

                dgvSalesStock.DataSource = null;
                dgvSalesStock.Rows.Clear();
                dgvSalesStock.Refresh();

                clear();
                txtTotalQty.Text = tot_Qty.ToString();
                txtTotAmount.Text = grandTotal.ToString();
            }
        }

        private void clear()
        {
            txtSearchTicket.Text = "";
            txtSupplier.Text = "";
            txtTname.Text = "";
            txtUprice.Text = "0";
            txtDrawNo.Text = "";
            txtDrawDate.Text = "NULL";
            txtInventory.Text = "0";
            txtStBcode.Text = "0";
            txtEdBcode.Text = "";
            txtQty.Text = "0";
            txtLineTotal.Text = "0";
            txtTotInven.Text = "0";
        }

        private void txtStBcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Get values for Sales Transaction
            Sales_TransactionBLL salesTranBll = new Sales_TransactionBLL();

            salesTranBll.inv_no = txtInvNo.Text;
            salesTranBll.agent_name = txtAgentName.Text;
            salesTranBll.agent_no = txtAgentNo.Text;
            salesTranBll.total_qty = decimal.Parse(txtTotalQty.Text);
            salesTranBll.total_billAmount = decimal.Parse(txtTotAmount.Text);
            salesTranBll.cash = decimal.Parse(txtCash.Text);
            salesTranBll.winings_nlb = decimal.Parse(txtWinNlb.Text);
            salesTranBll.winings_dlb = decimal.Parse(txtWinDlb.Text);
            salesTranBll.return_nlb = decimal.Parse(txtReturnNlb.Text);
            salesTranBll.return_dlb = decimal.Parse(txtReturnDlb.Text);
            salesTranBll.credits = decimal.Parse(txtCredit.Text);
            salesTranBll.added_date = DateTime.Now;
            salesTranBll.free_nlb = decimal.Parse(txtFreeNlb.Text);
            salesTranBll.free_dlb = decimal.Parse(txtFreeDlb.Text);

            //get the username of logged in user
            string username = Login.loggedIn;
            userBLL usr = uDal.GetUsername(username);

            salesTranBll.added_by = usr.username;
            salesTranBll.SalesTrans = SalesDT;

            bool isSuccess = false;

            using (TransactionScope scope = new TransactionScope())
            {
                int sales_tranID = -1;

                bool StranSuccess = salesDal.InsertSalesTransaction(salesTranBll, out sales_tranID);

                //Use for loop to insert sales
                for(int i=0; i<SalesDT.Rows.Count; i++)
                {
                    SalesBLL sales = new SalesBLL();

                    sales.inv_no = txtInvNo.Text;
                    sales.agent_name = txtAgentName.Text;
                    sales.agent_no = txtAgentNo.Text;
                    sales.ticket_name = SalesDT.Rows[i][0].ToString();
                    sales.draw_no = SalesDT.Rows[i][1].ToString();
                    sales.st_Bcode = SalesDT.Rows[i][6].ToString();
                    sales.en_Bcode = SalesDT.Rows[i][7].ToString();
                    sales.quantity = decimal.Parse(SalesDT.Rows[i][4].ToString());
                    sales.supplier = SalesDT.Rows[i][8].ToString();
                    sales.line_total = decimal.Parse(SalesDT.Rows[i][5].ToString());
                    sales.added_date = DateTime.Now;
                    sales.added_by = usr.username;
                    sales.unit_price = decimal.Parse(SalesDT.Rows[i][3].ToString());
                    //sales.draw_date = DateTime.Parse(SalesDT.Rows[i][2].ToString());

                    
                    string DrDate = SalesDT.Rows[i][2].ToString();
                    if (DrDate == "NULL" || DrDate=="")
                    {
                        sales.draw_date = DateTime.Now;
                    }
                    else
                    {
                        sales.draw_date = DateTime.Parse(SalesDT.Rows[i][2].ToString());
                    }

                    //Get Ticket Ctegory
                    string tname = SalesDT.Rows[i][0].ToString();
                    string sup = SalesDT.Rows[i][8].ToString();
                    string TickCategory = Tdal.GetTicketCategory(tname,sup);
                                    
                    bool stkSuccess = false;

                    if (TickCategory == "Draw")
                    {
                        StockBLL stock = new StockBLL();

                        stock.ticket_name = SalesDT.Rows[i][0].ToString();
                        stock.draw_no = SalesDT.Rows[i][1].ToString();
                        stock.draw_date = DateTime.Parse(SalesDT.Rows[i][2].ToString());
                        stock.quantity = decimal.Parse(SalesDT.Rows[i][4].ToString());
                        stock.supplier = SalesDT.Rows[i][8].ToString();
                        stock.starting_Bcode = SalesDT.Rows[i][6].ToString();
                        stock.ending_Bcode = SalesDT.Rows[i][7].ToString();
                        
                        stkSuccess = stkDal.UpdateOrDeleteStock(stock.starting_Bcode, stock.ticket_name, stock.quantity);
                    }
                    else if(TickCategory == "Instant")
                    {
                        Instant_StockBLL insStk = new Instant_StockBLL();

                        insStk.ticket_name = SalesDT.Rows[i][0].ToString();
                        insStk.supplier = SalesDT.Rows[i][8].ToString();
                        insStk.quantity = decimal.Parse(SalesDT.Rows[i][4].ToString());

                        stkSuccess = InsStkDal.Decrease_InsStockQty(insStk.ticket_name, insStk.quantity);
                    }
                    

                    //Insert sales into Database
                    bool SalesSuccess = Sdal.InsertSales(sales);

                    isSuccess = StranSuccess && stkSuccess && SalesSuccess;
                    //isSuccess = StranSuccess &&  SalesSuccess;
                }

                decimal balance = BalanceCalculation();
                txtBalance.Text = balance.ToString();

                string agent = txtAgentName.Text;
                string agentNo = txtAgentNo.Text;

                if (isSuccess == true && balance==0 && agent!="" && agentNo!="")
                {
                    scope.Complete();
                    MessageBox.Show("Successfull");

                    //Clear the data grid view 
                    dgvSales.DataSource = null;
                    dgvSales.Rows.Clear();
                    dgvSales.Refresh();

                    //Clear all the txt boxes
                    txtAgentName.Text = "";
                    txtAgentNo.Text = "";
                    txtSupplier.Text = "";
                    txtTname.Text = "";
                    txtUprice.Text = "0";
                    txtDrawNo.Text = "";
                    txtDrawDate.Text = "NULL";
                    txtStBcode.Text = "0";
                    txtQty.Text = "0";
                    txtEdBcode.Text = "";
                    txtLineTotal.Text = "0";
                    txtSearchAgent.Text = "";
                    txtSearchTicket.Text = "";
                    txtTotalQty.Text = "0";
                    txtTotAmount.Text = "0";
                    txtCash.Text = "0";
                    txtReturnNlb.Text = "0";
                    txtReturnDlb.Text = "0";
                    txtWinNlb.Text = "0";
                    txtWinDlb.Text = "0";
                    txtCredit.Text = "0";
                    txtBalance.Text = "0";
                    txtFreeNlb.Text = "0";
                    txtFreeDlb.Text = "0";
                }
                else
                {
                    MessageBox.Show("Faild to add sales");
                }
            }
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {

        }

        private decimal BalanceCalculation()
        {
            decimal total = decimal.Parse(txtTotAmount.Text);
            decimal cash = decimal.Parse(txtCash.Text);
            decimal retN = decimal.Parse(txtReturnNlb.Text);
            decimal retD = decimal.Parse(txtReturnDlb.Text);
            decimal winN = decimal.Parse(txtWinNlb.Text);
            decimal winD = decimal.Parse(txtWinDlb.Text);
            decimal credit = decimal.Parse(txtCredit.Text);
            decimal freeN = decimal.Parse(txtFreeNlb.Text);
            decimal freeD = decimal.Parse(txtFreeDlb.Text);

            decimal balance = total - (cash + retN + retD + winN + winD + credit + freeN + freeD);

            if (cash==0 && retN==0 && retD==0 && winN==0 && winD==0 && credit==0 && freeN==0 && freeD==0)
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

        private void dgvSalesStock_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the index of particular row
            int rowIndex = e.RowIndex;

            txtInventory.Text = dgvSalesStock.Rows[rowIndex].Cells[6].Value.ToString();
            txtStBcode.Text = dgvSalesStock.Rows[rowIndex].Cells[2].Value.ToString();
        }

        private void txtDrawNo_Enter(object sender, EventArgs e)
        {
            
        }

        
    }
}
