using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JProject.BLL
{
    class Instant_PurchasesBLL
    {
        public int pid { get; set; }
        public string ticket_name { get; set; }
        public string supplier { get; set; }
        public decimal unit_price { get; set; }
        public decimal quantity { get; set; }
        public decimal line_total { get; set; }
        public string inv_no { get; set; }
        public DateTime inv_date { get; set; }
        public DateTime added_date { get; set; }
        public string added_by { get; set; }
    }
}
