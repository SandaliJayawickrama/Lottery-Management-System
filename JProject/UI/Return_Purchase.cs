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
    public partial class Return_Purchase : Form
    {
        public Return_Purchase()
        {
            InitializeComponent();
        }

        StockDAL Sdal = new StockDAL();
        TicketsDAL tickets = new TicketsDAL();
        DataTable returnsDT = new DataTable();
        userDAL Udal = new userDAL();
        ReturnsDAL RetDal = new ReturnsDAL();
        Return_TransactionDAL retTranDal = new Return_TransactionDAL();

        private void Return_Purchase_Load(object sender, EventArgs e)
        {
            returnsDT.Columns.Add("Ticket_name");
            returnsDT.Columns.Add("Starting Bcode");
            returnsDT.Columns.Add("Quantity");
            returnsDT.Columns.Add("Ending Bcode");
            returnsDT.Columns.Add("Line Total");
            returnsDT.Columns.Add("Draw no");
            returnsDT.Columns.Add("Draw date");
            returnsDT.Columns.Add("Supplier");
        }

        private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            string supplier = cmbSupplier.Text;
            if (supplier != "")
            {
                DataTable dt = Sdal.SelectTodayStock(supplier);
                dgvStock.DataSource = dt;
            }
        }

        private void dgvStock_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Get the index of particular row
            int rowIndex = e.RowIndex;

            //Set values
            txtTickName.Text = dgvStock.Rows[rowIndex].Cells[1].Value.ToString();
            txtStBcode.Text = dgvStock.Rows[rowIndex].Cells[2].Value.ToString();
            txtEdBcode.Text = dgvStock.Rows[rowIndex].Cells[3].Value.ToString();
            txtDrno.Text = dgvStock.Rows[rowIndex].Cells[4].Value.ToString();
            txtQty.Text = dgvStock.Rows[rowIndex].Cells[6].Value.ToString();
            txtSup.Text = dgvStock.Rows[rowIndex].Cells[7].Value.ToString();
            txtDrDate.Text = dgvStock.Rows[rowIndex].Cells[5].Value.ToString();
            /*DateTime DrDate = new DateTime();
            string date = dgvStock.Rows[rowIndex].Cells[5].Value.ToString();
            DrDate = DateTime.Parse(date);
            txtDrDate.Text = DrDate.ToString("dd-MM-yyyy");*/

            //Get Unit Price
            string Tname = txtTickName.Text.ToString();
            string supplier = txtSup.Text.ToString();
            decimal Uprice = tickets.GetUnitPrice(Tname, supplier);

            //Calculate Line Total
            decimal qty = decimal.Parse(txtQty.Text);
            decimal lineTotal = qty * Uprice;

            txtLineTotal.Text = lineTotal.ToString();
        }

     
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tName = txtTickName.Text;
            string supplier = txtSup.Text;
            string drNo = txtDrno.Text;
            string drDate = txtDrDate.Text.ToString();
            string StBcode = txtStBcode.Text;
            string EdBcode = txtEdBcode.Text;
            decimal Qty = decimal.Parse(txtQty.Text);
            decimal line_tot = decimal.Parse(txtLineTotal.Text);

            //calculate total Quantity
            decimal totQty = decimal.Parse(txtTotalQty.Text);
            totQty = totQty + Qty;

            //calculate grand total amount
            decimal grandTotal = decimal.Parse(txtGndTotal.Text);
            grandTotal = grandTotal + line_tot;

            //Add returns to the Return data Grid view
            returnsDT.Rows.Add(tName, StBcode, Qty, EdBcode, line_tot, drNo, drDate, supplier);

            //Show data in Return DataGridView
            dgvReturn.DataSource = returnsDT;
            clear();
            txtGndTotal.Text = grandTotal.ToString();
            txtTotalQty.Text = totQty.ToString();

            //Remove data from Stock DataGridView
            dgvStock.Rows.Remove(dgvStock.CurrentRow);
        }

        private void clear()
        {
            txtTickName.Text = "";
            txtSup.Text = "";
            txtDrno.Text = "";
            txtDrDate.Text = "";
            txtStBcode.Text = "0";
            txtEdBcode.Text = "";
            txtQty.Text = "0";
            txtLineTotal.Text = "0";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Return_TransactionBLL RetTranBll = new Return_TransactionBLL();

            //Get the value from PurchaseFrm
            RetTranBll.supplier = cmbSupplier.Text;
            RetTranBll.tot_quantity = decimal.Parse(txtTotalQty.Text);
            RetTranBll.tot_amount = decimal.Parse(txtGndTotal.Text);
            RetTranBll.agent_name = txtAgent.Text;
            RetTranBll.added_date = DateTime.Now;

            //get the username of logged in user
            string username = Login.loggedIn;
            userBLL usr = Udal.GetUsername(username);

            RetTranBll.added_by = usr.username;
            RetTranBll.ReturnTran = returnsDT;

            bool isSuccess = false;

            //actual code to insert Returns and Return_Transactions
            using (TransactionScope scope = new TransactionScope())
            {
                int return_tranID = -1;

                //Insert Return_Transactions into Database
                bool RT = retTranDal.InsertReturnTransaction(RetTranBll, out return_tranID);

                //Use for loop to insert Returns
                for(int i=0; i<returnsDT.Rows.Count; i++)
                {
                    //Get all the Returns
                    ReturnsBLL returnBll = new ReturnsBLL();

                    returnBll.ticket_name = returnsDT.Rows[i][0].ToString();
                    returnBll.supplier = returnsDT.Rows[i][7].ToString();
                    returnBll.draw_no = returnsDT.Rows[i][5].ToString();
                    returnBll.draw_date = DateTime.Parse(returnsDT.Rows[i][6].ToString());
                    returnBll.starting_Bcode = returnsDT.Rows[i][1].ToString();
                    returnBll.ending_Bcode = returnsDT.Rows[i][3].ToString();
                    returnBll.quantity = decimal.Parse(returnsDT.Rows[i][2].ToString());
                    returnBll.line_total = decimal.Parse(returnsDT.Rows[i][4].ToString());
                    returnBll.agent_name = txtAgent.Text;
                    returnBll.added_by = usr.username;
                    returnBll.added_date = DateTime.Now;

                    //Delete Returns from Stock
                    StockBLL stkBll = new StockBLL();

                    stkBll.ticket_name = returnsDT.Rows[i][0].ToString();
                    stkBll.starting_Bcode = returnsDT.Rows[i][1].ToString();
                    stkBll.ending_Bcode = returnsDT.Rows[i][3].ToString();
                    stkBll.draw_no = returnsDT.Rows[i][5].ToString();
                    stkBll.draw_date = DateTime.Parse(returnsDT.Rows[i][6].ToString());
                    stkBll.quantity = decimal.Parse(returnsDT.Rows[i][2].ToString());
                    stkBll.supplier = returnsDT.Rows[i][7].ToString();

                    bool stkSuccess = false;
                    stkSuccess = Sdal.DeleteStock(stkBll.ticket_name, stkBll.starting_Bcode);

                    //Insert Returns into Database
                    bool R = RetDal.InsertReturn(returnBll);
                    isSuccess = RT && R && stkSuccess;
                }

                if (isSuccess == true)
                {
                    //Return Complete
                    scope.Complete();
                    MessageBox.Show("Returned Successfull");

                    dgvReturn.DataSource = null;
                    dgvReturn.Rows.Clear();
                    dgvReturn.Refresh();

                    //Clear the data grid view and all the txt boxes
                    cmbSupplier.Text = "";
                    txtTotalQty.Text = "0";
                    txtGndTotal.Text = "0";
                }
                else
                {
                    //Return fail
                    MessageBox.Show("Failed to return..!");
                }
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

        private void txtSup_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void txtDrno_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtStBcode_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtLineTotal_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtAgent_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) || Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }


    }
}
