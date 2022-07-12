using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JProject.BLL
{
    class Purchase_OrderBLL
    {
        public int po_id { get; set; }
        public string supplier { get; set; }
        public string po_no { get; set; }
        public DateTime po_date { get; set; }
        public string ticket_Name { get; set; }
        public decimal unit_price { get; set; }
        public DateTime draw_date { get; set; }
        public decimal order_quantity { get; set; }
        public decimal recieved_quantity { get; set; }
        public decimal line_total { get; set; }
        public DateTime added_date { get; set; }
        public string added_by { get; set; }
       
    }
}
