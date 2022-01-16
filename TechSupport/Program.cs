using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.View;

namespace TechSupport
{
    static class Program
    {   
        public static bool LoginSuccess;
        public static LoginForm newLogin;
        public static MainForm newMainForm;
        public static bool LogOut;
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
