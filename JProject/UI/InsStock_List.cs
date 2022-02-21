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
    public partial class InsStock_List : Form
    {
        public InsStock_List()
        {
            InitializeComponent();
        }

        Instant_StockDAL insStkDal = new Instant_StockDAL();

        private void InsStock_List_Load(object sender, EventArgs e)
        {
            //Display available inventories in Data Grid View
            DataTable dt = insStkDal.SelectInsStocksList();
            dgvInsStockList.DataSource = dt;
        }

        private void txtSearchInsStock_TextChanged(object sender, EventArgs e)
        {
            //get keyword from Text Box
            string keywords = txtSearchInsStock.Text;
            if (keywords != null)
            {
                //Show User based on keyword
                DataTable dt = insStkDal.SearchInsStock(keywords);
                dgvInsStockList.DataSource = dt;
            }
            else
            {
                //Show all users from the Database
                DataTable dt = insStkDal.SelectInsStocksList();
                dgvInsStockList.DataSource = dt;
            }
        }
    }
}
