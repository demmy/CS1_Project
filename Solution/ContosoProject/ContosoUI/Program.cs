using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContosoUI
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
            Application.Run(new ClientSearchForm.ClientSearchForm());
            Application.Run(new UserSearchForm.UserSearchForm());
            Application.Run(new ProductSearchForm.ProductSearchForm());
            Application.Run(new OrderSearchForm.OrderSearchForm());

        }
    }
}
