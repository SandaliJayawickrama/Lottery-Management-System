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
    public partial class Return_Sales : Form
    {
        public Return_Sales()
        {
            InitializeComponent();
        }
    
        DataTable salesRetDT = new DataTable();       
        ReturnSales_TransactionDAL salesRet_TransDal = new ReturnSales_TransactionDAL();
        Return_SalesDAL salesRetDal = new Return_SalesDAL();
        SalesDAL salesDal = new SalesDAL();
        userDAL uDal = new userDAL();
        AgentDAL agentDal = new AgentDAL();
        StockDAL stockDal = new StockDAL();
        Instant_StockDAL insStockDal = new Instant_StockDAL();
        TicketsDAL ticketsDAL = new TicketsDAL();
        Balance_TransactionDAL balDal = new Balance_TransactionDAL();

        private void Sales_Return_Load(object sender, EventArgs e)
        {
            txtSreturnId.Text = salesRet_TransDal.CreateSalesReturnId();

            //Specify columns for Sales Return DataTable
            salesRetDT.Columns.Add("Agent");           
            salesRetDT.Columns.Add("Ticket");
            salesRetDT.Columns.Add("Draw date");
            salesRetDT.Columns.Add("DrawNo");
            salesRetDT.Columns.Add("Quantity");
            salesRetDT.Columns.Add("Starting Bcode");
            salesRetDT.Columns.Add("Ending Bcode");
            salesRetDT.Columns.Add("Line Total");            
            salesRetDT.Columns.Add("AgentNo");
            salesRetDT.Columns.Add("Supplier");
            salesRetDT.Columns.Add("UnitPrice");
            salesRetDT.Columns.Add("SalesInvNo");
        }

        private void txtStBcode_TextChanged(object sender, EventArgs e)
        {
            DataTable salesDT = new DataTable();

            if (txtStBcode.Text.ToString() == "")
            {
                txtStBcode.Text = "0";
                return;
            }
                                 
            salesDT = salesDal.SelectTodayDatedDrawSales();
            double sBcode = double.Parse(txtStBcode.Text);

            for (int i = 0; i < salesDT.Rows.Count; i++)
            {
                SalesBLL salesBll = new SalesBLL();

                salesBll.st_Bcode = salesDT.Rows[i][6].ToString();
                salesBll.en_Bcode = salesDT.Rows[i][7].ToString();

                double getsBcode = double.Parse(salesBll.st_Bcode.ToString());
                double geteBcode = double.Parse(salesBll.en_Bcode.ToString());

                if (getsBcode <= sBcode && sBcode <= geteBcode)
                {
                    salesBll.inv_no = salesDT.Rows[i][1].ToString();
                    salesBll.agent_name = salesDT.Rows[i][2].ToString();
                    salesBll.agent_no = salesDT.Rows[i][3].ToString();
                    salesBll.ticket_name = salesDT.Rows[i][4].ToString();
                    salesBll.draw_no = salesDT.Rows[i][5].ToString();
                    salesBll.unit_price = decimal.Parse(salesDT.Rows[i][13].ToString());
                    salesBll.quantity = decimal.Parse(salesDT.Rows[i][8].ToString());
                    salesBll.supplier = salesDT.Rows[i][9].ToString();
                    salesBll.draw_date = DateTime.Parse(salesDT.Rows[i][14].ToString());

                    txtInvNo.Text = salesBll.inv_no;
                    txtAgentName.Text = salesBll.agent_name;
                    txtAgentNo.Text = salesBll.agent_no;
                    txtTname.Text = salesBll.ticket_name;
                    txtSupplier.Text = salesBll.supplier;
                    txtDrNo.Text = salesBll.draw_no.ToString();
                    txtDrDate.Text = salesBll.draw_date.ToString("yyyy-MM-dd");
                    txtUnitPrice.Text = salesBll.unit_price.ToString();
                    txtOrQty.Text = salesBll.quantity.ToString();

                    break;
                }
                else
                {
                    txtQty.Text = "0";
                    txtEnBcode.Text = "";
                    txtLineTotal.Text = "0";
                    txtTname.Text = "";
                    txtInvNo.Text = "";
                    txtAgentName.Text = "";
                    txtAgentNo.Text = "";
                    txtDrNo.Text = "";
                    txtDrDate.Text = "";
                    txtUnitPrice.Text = "0";
                    txtSupplier.Text = "";
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
                decimal Uprice = decimal.Parse(txtUnitPrice.Text);

                //calculate Ending-Bcode & Line-Total
                decimal EdBcode = StBcode + qty - 1;
                decimal lineTot = Uprice * qty;

                //Set Ending Bcode & line total
                txtEnBcode.Text = EdBcode.ToString();
                txtLineTotal.Text = lineTot.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string agent = txtAgentName.Text;
            string tikName = txtTname.Text;
            string drDate = txtDrDate.Text.ToString();
            string drNo = txtDrNo.Text;           
            decimal qty = decimal.Parse(txtQty.Text);
            string STBcode = txtStBcode.Text;
            string EDBcode = txtEnBcode.Text;
            decimal lineTot = decimal.Parse(txtLineTotal.Text);
            string agentNo = txtAgentNo.Text;
            string supplier = txtSupplier.Text;
            decimal uPrice = decimal.Parse(txtUnitPrice.Text);
            string invNo = txtInvNo.Text;

            //calculate total quantity
            decimal tot_Qty = decimal.Parse(txtTotalQty.Text);
            tot_Qty = tot_Qty + qty;

            //calculate Total amount
            decimal grandTotal = decimal.Parse(txtTotAmount.Text);
            grandTotal = grandTotal + lineTot;

            decimal orQty = decimal.Parse(txtOrQty.Text);

            //Check supplier is same or not
            bool isSupplier = true;
            for (int i = 0; i < salesRetDT.Rows.Count; i++)
            {
                string chk_agent = salesRetDT.Rows[i][0].ToString();
                string chk_sup = salesRetDT.Rows[i][9].ToString();
                if (supplier != chk_sup || agent != chk_agent)
                {
                    isSupplier = false;
                    break;
                }
            }

            //check wether the required details are filled or not
            if (tikName == "" || qty == 0 || qty == 0)
            {
                // Display Error message
                MessageBox.Show("Please fill required details");
            }
            else if (qty > orQty)
            {
                // Display Error message
                MessageBox.Show("Invalid Quantity");
            }
            else if (isSupplier != true)
            {
                // Display Error message
                MessageBox.Show("Invalid Supplier or Agent!");
            }
            else
            {
                salesRetDT.Rows.Add(agent, tikName, drDate, drNo, qty, STBcode, EDBcode, lineTot, agentNo, supplier, uPrice, invNo);
                lblSup1.Text = supplier;
                lblAgentN1.Text = agent;
                lblAgentNo1.Text = agentNo;
                lblDrDate1.Text = drDate;

                //Show in Data Grid view 
                dgvSalesReturn.DataSource = salesRetDT;

                clear();
                txtTotalQty.Text = tot_Qty.ToString();
                txtTotAmount.Text = grandTotal.ToString();
            }
        }


        private void clear()
        {         
            txtSupplier.Text = "";
            txtTname.Text = "";
            txtUnitPrice.Text = "0";
            txtDrNo.Text = "";
            txtDrDate.Text = "";
            txtStBcode.Text = "0";
            txtEnBcode.Text = "";
            txtQty.Text = "0";
            txtOrQty.Text = "0";
            txtLineTotal.Text = "0";
            txtInvNo.Text = "";
            txtAgentName.Text = "";
            txtAgentNo.Text = "";
        }

        private void clearAll()
        {
            txtSreturnId.Text = "";
            lblSup1.Text = "";
            txtTotalQty.Text = "0";
            txtTotAmount.Text = "0";

            //Clear the data grid view 
            dgvSalesReturn.DataSource = null;
            dgvSalesReturn.Rows.Clear();
            dgvSalesReturn.Refresh();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            //Get values for Sales Transaction
            ReturnSales_TransactionBLL ReturnTranBll = new ReturnSales_TransactionBLL();
            
            ReturnTranBll.SReturn_id = txtSreturnId.Text;
            ReturnTranBll.agent_name = lblAgentN1.Text;
            ReturnTranBll.agent_no = lblAgentNo1.Text;
            ReturnTranBll.supplier = lblSup1.Text;
            ReturnTranBll.draw_date = DateTime.Parse(lblDrDate1.Text);
            ReturnTranBll.total_qty = decimal.Parse(txtTotalQty.Text);
            ReturnTranBll.total_amount = decimal.Parse(txtTotAmount.Text);
            ReturnTranBll.added_date = DateTime.Now;

            //get the username of logged in user
            string username = Login.loggedIn;
            userBLL usr = uDal.GetUsername(username);

            ReturnTranBll.added_by = usr.username;
            ReturnTranBll.SalesReturnTrans = salesRetDT;

            //Get Agent details to Update Credit Amount In Agents Table
            string AgentName = lblAgentN1.Text;
            string AgentNo = lblAgentNo1.Text;
            decimal retAmount = decimal.Parse(txtTotAmount.Text);

            //get current return balances
            string supplier = lblSup1.Text;
            decimal currentReturn = 0;

            if (supplier == "NLB")
            {
                currentReturn = agentDal.GetCurrentNlbReturnBalance(AgentName, AgentNo);
            }
            else if(supplier == "DLB")
            {
                currentReturn = agentDal.GetCurrentDlbReturnBalance(AgentName, AgentNo);
            }
            
            bool isSuccess = false;

            using (TransactionScope scope = new TransactionScope())
            {
                //Insert return sales Transaction
                int salesRet_tranID = -1;
                bool StranSuccess = salesRet_TransDal.InsertReturnSales_Transaction(ReturnTranBll, out salesRet_tranID);

                //Update Agent return balance
                decimal totRetBalance = currentReturn + retAmount;
                bool AgRetSuccess = false;
                AgRetSuccess = agentDal.UpdateReturnBalancs(AgentName, AgentNo, supplier, totRetBalance);

                //Use for loop to insert sales return 
                for (int i = 0; i < salesRetDT.Rows.Count; i++)
                {
                    Return_SalesBLL retSaleBll = new Return_SalesBLL();       

                    retSaleBll.SReturn_id = txtSreturnId.Text;
                    retSaleBll.agent_name = salesRetDT.Rows[i][0].ToString();
                    retSaleBll.agent_no = salesRetDT.Rows[i][8].ToString();
                    retSaleBll.salesInv_no = salesRetDT.Rows[i][11].ToString();
                    retSaleBll.ticket_name = salesRetDT.Rows[i][1].ToString();
                    retSaleBll.draw_date = DateTime.Parse(salesRetDT.Rows[i][2].ToString());
                    retSaleBll.draw_no = salesRetDT.Rows[i][3].ToString();
                    retSaleBll.starting_Bcode = salesRetDT.Rows[i][5].ToString();
                    retSaleBll.ending_Bcode = salesRetDT.Rows[i][6].ToString();
                    retSaleBll.quantity = decimal.Parse(salesRetDT.Rows[i][4].ToString());
                    retSaleBll.unit_price = decimal.Parse(salesRetDT.Rows[i][10].ToString());
                    retSaleBll.line_total = decimal.Parse(salesRetDT.Rows[i][7].ToString());
                    retSaleBll.supplier = salesRetDT.Rows[i][9].ToString();
                    retSaleBll.added_by = usr.username;
                    retSaleBll.added_date = DateTime.Now;

                    //Get Ticket Ctegory
                    string tname = salesRetDT.Rows[i][1].ToString();
                    string sup = salesRetDT.Rows[i][9].ToString();
                    string TickCategory = ticketsDAL.GetTicketCategory(tname, sup);

                    bool stkSuccess = false;

                    if (TickCategory == "Draw")
                    {
                        StockBLL stockBll = new StockBLL();

                        stockBll.ticket_name = salesRetDT.Rows[i][1].ToString();
                        stockBll.draw_no = salesRetDT.Rows[i][3].ToString();
                        stockBll.draw_date = DateTime.Parse(salesRetDT.Rows[i][2].ToString());
                        stockBll.quantity = decimal.Parse(salesRetDT.Rows[i][4].ToString());
                        stockBll.supplier = salesRetDT.Rows[i][9].ToString();
                        stockBll.starting_Bcode = salesRetDT.Rows[i][5].ToString();
                        stockBll.ending_Bcode = salesRetDT.Rows[i][6].ToString();

                        stkSuccess = stockDal.InsertStock(stockBll);
                    }
                    else if (TickCategory == "Instant")
                    {
                        Instant_StockBLL insStkBll = new Instant_StockBLL();

                        insStkBll.ticket_name = salesRetDT.Rows[i][1].ToString();
                        insStkBll.supplier = salesRetDT.Rows[i][9].ToString();
                        insStkBll.quantity = decimal.Parse(salesRetDT.Rows[i][4].ToString());

                        stkSuccess = insStockDal.Increase_InsStockQty(insStkBll, insStkBll.ticket_name, insStkBll.quantity);
                    }

                    //Insert sales return into Database
                    bool SalesRetSuccess = salesRetDal.InsertSalesReturns(retSaleBll);

                    isSuccess = StranSuccess && stkSuccess && SalesRetSuccess && AgRetSuccess;                   
                }

                //Update balances in Balance Transaction table
                Balance_TransactionBLL balBll = new Balance_TransactionBLL();
                DataTable balDT = balDal.SelectLastRowBalances();

                balBll.Description = "Agent Sales Return";
                balBll.Cash = decimal.Parse(balDT.Rows[0][2].ToString());
                balBll.Bank = decimal.Parse(balDT.Rows[0][3].ToString());
                balBll.Stock = decimal.Parse(balDT.Rows[0][4].ToString()) + decimal.Parse(txtTotAmount.Text);
                balBll.Win_Nlb = decimal.Parse(balDT.Rows[0][5].ToString());
                balBll.Win_Dlb = decimal.Parse(balDT.Rows[0][6].ToString());
                balBll.Credi_recievables = decimal.Parse(balDT.Rows[0][7].ToString());
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

                if (supplier == "NLB")
                {
                    balBll.Return_PayableNLB = decimal.Parse(balDT.Rows[0][14].ToString()) + decimal.Parse(txtTotAmount.Text);
                    balBll.Return_PayableDLB = decimal.Parse(balDT.Rows[0][15].ToString());
                }
                else if (supplier == "DLB")
                {
                    balBll.Return_PayableDLB = decimal.Parse(balDT.Rows[0][15].ToString()) + decimal.Parse(txtTotAmount.Text);
                    balBll.Return_PayableNLB = decimal.Parse(balDT.Rows[0][14].ToString());
                }

                balBll.added_date = DateTime.Now;

                //getting the user name of LoggedIn user
                string loggedUser = Login.loggedIn;
                userBLL urs = uDal.GetUsername(loggedUser);
                balBll.added_by = urs.username;

                bool isBalanceSettle = balDal.UpdateTransactionBalance(balBll);

                string agent = lblAgentN1.Text;
              
                if (isSuccess == true && agent != "" && isBalanceSettle==true)
                {
                    scope.Complete();
                    MessageBox.Show("Successfully added");

                    //Clear the data grid view and all the text boxes
                    clear();
                    clearAll();                  
                }
                else
                {
                    MessageBox.Show("Faild to add Returns");
                }
            }

        }


        private void txtEnBcode_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtInvNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
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

        private void txtDrNo_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtOrQty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtSupplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtsup1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtSreturnId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
