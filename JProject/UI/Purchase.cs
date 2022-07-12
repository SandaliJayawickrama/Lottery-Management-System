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
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }

        DataTable purchaseDT = new DataTable();
        PO_TransactionDAL PoTransDal = new PO_TransactionDAL();
        Purchase_OrderDAL PoDal = new Purchase_OrderDAL();

        private void Purchase_Load(object sender, EventArgs e)
        {
            //Specify columns for Purchase DataTable
            purchaseDT.Columns.Add("PO No");
            purchaseDT.Columns.Add("PO Date");
            purchaseDT.Columns.Add("Ticket Name");
            purchaseDT.Columns.Add("Order Qty");
            purchaseDT.Columns.Add("Draw Date");
            purchaseDT.Columns.Add("Supplier");
            purchaseDT.Columns.Add("Unit Price");

            purchaseDT.Columns.Add("Draw No");
            purchaseDT.Columns.Add("Recieved Qty");
            purchaseDT.Columns.Add("Starting Bcode");
            purchaseDT.Columns.Add("Ending Bcode");
            purchaseDT.Columns.Add("Line Total");
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

            //Set the values on textboxes, based on t object
            txtPoNo.Text = pt.po_no;
            txtPoDate.Text = pt.po_date.ToString("yyyy-MM-dd");
            txtSupplier1.Text = pt.supplier;
            txtCategory.Text = pt.category;
        }

        private void txtPoNo_TextChanged(object sender, EventArgs e)
        {
            string PoNo = txtPoNo.Text;

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
    }
}
