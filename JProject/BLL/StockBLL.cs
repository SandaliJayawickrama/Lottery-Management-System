using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JProject.BLL
{
    class StockBLL
    {
        public string ticket_name { get; set; }
        public string starting_Bcode { get; set; }
        public string ending_Bcode { get; set; }
        public string draw_no { get; set; }
        public DateTime draw_date { get; set; }
        public decimal quantity { get; set; }
        public string supplier { get; set; }

    }
}
