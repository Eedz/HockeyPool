using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HockeyPool
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

#if RELEASE
            HockeyPoolLogin login = new HockeyPoolLogin();
            switch (login.ShowDialog()) 
            {
                case DialogResult.OK:
                    login.Close();
                    
                    
                    Application.Run(new HockeyPoolMenu(login.Username));
                    break;
                case DialogResult.Cancel:
                    Application.Exit();
                    break;
                case DialogResult.No:
                    MessageBox.Show("Unsuccessful login attempt.");
                    break;
            }
#else
            Application.Run(new HockeyPoolMenu("Eddie"));
#endif
        }
    }
}
