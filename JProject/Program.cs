using JProject.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new InsStock_List());
            Application.Run(new Login());
            //Application.Run(new Purchase_Order());
            //Application.Run(new Return_Purchase());
            //Application.Run(new AdminDashboard());
            //Application.Run(new Return_Purchase());
        }
    }
}
