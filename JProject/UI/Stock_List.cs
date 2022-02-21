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
    public partial class Stock_List : Form
    {
        public Stock_List()
        {
            InitializeComponent();
        }

        StockDAL stock = new StockDAL();
        private void Stock_List_Load(object sender, EventArgs e)
        {
            //Display available inventories in Data Grid View
            DataTable dt = stock.SelectStockList();
            dgvStockList.DataSource = dt;
        }

        private void txtSearchStock_TextChanged(object sender, EventArgs e)
        {
            //get keyword from Text Box
            string keywords = txtSearchStock.Text;
            if (keywords != null)
            {
                //Show User based on keyword
                DataTable dt = stock.SearchStock(keywords);
                dgvStockList.DataSource = dt;
            }
            else
            {
                //Show all users from the Database
                DataTable dt = stock.SelectStockList();
                dgvStockList.DataSource = dt;
            }
        }
    }
}
