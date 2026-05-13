using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
<<<<<<< Updated upstream
using WindowsFormsApp1.Views;
=======
using WindowsFormsApp1.Models;

>>>>>>> Stashed changes

namespace WindowsFormsApp1
{


    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        [STAThread]
        static void Main()
        {
            Database.SetInitializer(new AppDbInitializer());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
