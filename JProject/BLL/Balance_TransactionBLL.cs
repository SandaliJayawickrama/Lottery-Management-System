using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JProject.BLL
{
    class Balance_TransactionBLL
    {
        public string Description { get; set; }
        public decimal Cash { get; set; }
        public decimal Bank { get; set; }
        public decimal Stock { get; set; }
        public decimal Win_Nlb { get; set; }
        public decimal Win_Dlb { get; set; }
        public decimal Credi_recievables { get; set; }
        public decimal Stock_recievablesNLB { get; set; }
        public decimal Stock_recievablesDLB { get; set; }
        public decimal Return_recievablesNLB { get; set; }
        public decimal Return_recievablesDLB { get; set; }
        public decimal Credit_PayableNLB { get; set; }
        public decimal Credit_PayableDLB { get; set; }
        public decimal Return_PayableNLB { get; set; }
        public decimal Return_PayableDLB { get; set; }
        public decimal Capital { get; set; }
        public decimal Income { get; set; }
        public decimal Expenses { get; set; }
        public string added_by { get; set; }
        public DateTime added_date { get; set; }
        public decimal emai_Nlb { get; set; }
        public decimal emai_Dlb { get; set; }
        public decimal freeIssue_receivableNLB { get; set; }
        public decimal freeIssue_receivableDLB { get; set; }
        public decimal other_discountGiving { get; set; }
    }
}
