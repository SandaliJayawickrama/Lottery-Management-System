using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JProject.BLL
{
    class Cash_DepositBLL
    {
        public int id { get; set; }
        public string description { get; set; }
        public decimal amount { get; set; }
        public DateTime added_date { get; set; }
        public string added_by { get; set; }
    }
}
