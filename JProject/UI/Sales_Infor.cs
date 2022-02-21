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
    public partial class Sales_Infor : Form
    {
        public Sales_Infor()
        {
            InitializeComponent();
        }

        Sales_TransactionDAL salesTrDal = new Sales_TransactionDAL();
        private void Sales_Infor_Load(object sender, EventArgs e)
        {
            //Display available inventories in Data Grid View
            DataTable dt = salesTrDal.SelectSalesList();
            dgvSalesList.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //get keyword from Text Box
            string keywords = txtSearch.Text;
            if (keywords != null)
            {
                //Show User based on keyword
                DataTable dt = salesTrDal.SearchSales(keywords);
                dgvSalesList.DataSource = dt;
            }
            else
            {
                //Show all users from the Database
                DataTable dt = salesTrDal.SelectSalesList();
                dgvSalesList.DataSource = dt;
            }
        }
    }
}
