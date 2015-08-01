using System;
using System.Windows.Forms;

namespace ContosoUI
{
    static class Program
    {
        public static MainForm MainForm { get; private set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainForm = new MainForm();
            Application.Run(new LoginForm());
        }
    }
}
