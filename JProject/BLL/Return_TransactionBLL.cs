using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JProject.BLL
{
    class Return_TransactionBLL
    {
        public int rt_id { get; set; }
        public string supplier { get; set; }
        public decimal tot_quantity { get; set; }
        public decimal tot_amount { get; set; }
        public string agent_name { get; set; }
        public string added_by { get; set; }
        public DateTime added_date { get; set; }
        public DataTable ReturnTran { get; set; }
    }
}
