using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JProject.BLL
{
    class Sales_TransactionBLL
    {
        public int st_id { get; set; }
        public string inv_no { get; set; }
        public string agent_name { get; set; }
        public string agent_no { get; set; }
        public decimal total_qty { get; set; }
        public decimal total_billAmount { get; set; }
        public decimal cash { get; set; }
        public decimal winings_nlb { get; set; }
        public decimal winings_dlb { get; set; }
        public decimal return_nlb { get; set; }
        public decimal return_dlb { get; set; }
        public decimal credits { get; set; }
        public DateTime added_date { get; set; }
        public string added_by { get; set; }
        public decimal free_nlb { get; set; }
        public decimal free_dlb { get; set; }
        public DataTable SalesTrans { get; set; }
    }
}
