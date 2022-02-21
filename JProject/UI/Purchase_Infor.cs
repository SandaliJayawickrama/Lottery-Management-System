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
    public partial class Purchase_Infor : Form
    {
        public Purchase_Infor()
        {
            InitializeComponent();
        }

        Purchase_TransactionDAL PurTransDal = new Purchase_TransactionDAL();
        private void Purchase_Infor_Load(object sender, EventArgs e)
        {
            //Display available inventories in Data Grid View
            DataTable dt = PurTransDal.SelectPurchaseList();
            dgvPurchaseList.DataSource = dt;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //get keyword from Text Box
            string keywords = txtSearch.Text;
            if (keywords != null)
            {
                //Show User based on keyword
                DataTable dt = PurTransDal.SearchPurchases(keywords);
                dgvPurchaseList.DataSource = dt;
            }
            else
            {
                //Show all users from the Database
                DataTable dt = PurTransDal.SelectPurchaseList();
                dgvPurchaseList.DataSource = dt;
            }
        }
    }
}
