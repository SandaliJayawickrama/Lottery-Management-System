using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JProject.BLL
{
    class BalancesBLL
    {
        public int bid { get; set; }
        public decimal cash { get; set; }
        public decimal bank { get; set; }
        public decimal payable_Nlb { get; set; }
        public decimal payable_Dlb { get; set; }
        public decimal recievables { get; set; }
        public decimal stock { get; set; }
    }
}
