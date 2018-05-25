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
            //Application.Run(new HockeyPoolMenu());

            Form login = new HockeyPoolLogin();
            switch (login.ShowDialog()) 
            {
                case DialogResult.OK:
                    login.Close();
                    Application.Run(new HockeyPoolMenu());
                    break;
                case DialogResult.Cancel:
                    Application.Exit();
                    break;
                case DialogResult.No:
                    MessageBox.Show("Unsuccessful login attempt.");
                    break;
            }
            
        }
    }
}
