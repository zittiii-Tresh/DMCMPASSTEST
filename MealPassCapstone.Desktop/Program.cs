using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.UserSkins;
using MealPassCapstone.Desktop.Forms;

namespace MealPassCapstone.Desktop
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
            Application.Run(new LoginForm());
        }
    }
}
