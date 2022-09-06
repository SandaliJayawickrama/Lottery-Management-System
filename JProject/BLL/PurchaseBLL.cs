using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JProject.BLL
{
    class PurchaseBLL
    {
        public int pid { get; set; }
        public string supplier { get; set; }
        public string po_no { get; set; }
        public DateTime po_date { get; set; }
        public string ticket_Name { get; set; }
        public decimal unit_price { get; set; }
        public string draw_no { get; set; }
        public DateTime draw_date { get; set; }
        public string starting_Bcode { get; set; }
        public string ending_Bcode { get; set; }
        public decimal order_qty { get; set; }
        public decimal recieved_qty { get; set; }
        public decimal line_total { get; set; }
        public DateTime added_date { get; set; }
        public string added_by { get; set; }
  
        //public string draw_No { get; set; }
    
    }
}
