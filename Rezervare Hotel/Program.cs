using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rezervare_Hotel
{
    internal static class Program
    {
        private static MenuStrip menuStrip1;
        private static ToolStripMenuItem fileMenuItem;
        private static ToolStripMenuItem exitMenuItem;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());


        }
    }
}
