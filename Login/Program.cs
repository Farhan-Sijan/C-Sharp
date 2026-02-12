using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Application.Run(new Login());
            //Application.Run(new A1Customer());
            //Application.Run(new S2_Emp3());
            //Application.Run(new A1CusInvoice());
            //Application.Run(new A1CusMenu());
            //Application.Run(new A1Admin());
            //Application.Run(new S1_Emp1());
            //Application.Run(new S2_Emp2());
            //Application.Run(new M2Rating());
            Application.Run(new M1CategoryManagement());
            //Application.Run(new S2_Emp4());
            //Application.Run(new A1AdminDasboard());
        }
    }
}
