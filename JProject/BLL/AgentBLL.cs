using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JProject.BLL
{
    class AgentBLL
    {
        public int id { get; set; }
        public string agent_name { get; set; }
        public string agent_no { get; set; }
        public decimal credit_Limit { get; set; }
        public string description { get; set; }
        public string added_by { get; set; }
        public DateTime added_date { get; set; }
    }
}
