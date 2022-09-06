using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JProject.BLL
{
    class Return_SalesBLL
    {
        public int Sret_id { get; set; }
        public string SReturn_id { get; set; }
        public string agent_name { get; set; }
        public string agent_no { get; set; }
        public string salesInv_no { get; set; }
        public string ticket_name { get; set; }
        public DateTime draw_date { get; set; }
        public string draw_no { get; set; }
        public string starting_Bcode { get; set; }
        public string ending_Bcode { get; set; }
        public decimal quantity { get; set; }
        public decimal unit_price { get; set; }
        public decimal line_total { get; set; }
        public string supplier { get; set; }
        public string added_by { get; set; }
        public DateTime added_date { get; set; }       
    }
}
