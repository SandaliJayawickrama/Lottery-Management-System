using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JProject.BLL
{
    class ReturnSales_TransactionBLL
    {
        public int Sret_TransId { get; set; }
        public string SReturn_id { get; set; }
        public string agent_name { get; set; }
        public string agent_no { get; set; }
        public string supplier { get; set; }
        public DateTime draw_date { get; set; }
        public decimal total_qty { get; set; }
        public decimal total_amount { get; set; }
        public string added_by { get; set; }
        public DateTime added_date { get; set; }
        public DataTable SalesReturnTrans { get; set; }
    }
}
