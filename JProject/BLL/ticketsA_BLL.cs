using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JProject.BLL.AdminBLL
{
    class ticketsA_BLL
    {
        public string ticket_code { get; set; }
        public string ticket_name { get; set; }
        public string ticket_type { get; set; }
        public decimal ticket_Uprice { get; set; }
        public decimal ticket_Bprice { get; set; }      
        public string added_by { get; set; }
        public DateTime added_date { get; set; }
        public decimal sales_Uprice { get; set; }
        public string category { get; set; }



    }
}
