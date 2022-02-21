using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JProject.BLL
{
    class Purchase_TransactionBLL
    {
        public int pt_id { get; set; }
        public string inv_no { get; set; }
        public string supplier { get; set; }
        public decimal total_quantity { get; set; }
        public decimal grand_total { get; set; }
        public DateTime inv_date { get; set; }
        public DateTime added_date { get; set; }
        public string added_by { get; set; }
        public string category { get; set; }
        public DataTable PurchaseTrans { get; set; }
        public decimal cash { get; set; }
        public decimal bank { get; set; }
        public decimal scan_nlb { get; set; }
        public decimal scan_dlb { get; set; }
        public decimal return_nlb { get; set; }
        public decimal return_dlb { get; set; }
        public decimal credit { get; set; }

    }
}
