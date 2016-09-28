using E_Deklaracja.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Deklaracja
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

            FrmMain shell = new FrmMain();
            FormTools.MainView = shell;

            MainViewPresenter mainViewPresenter = new MainViewPresenter(shell);
            mainViewPresenter.ShowView();

            //shell.OnShowView();

            //Application.Run(shell);
        }
    }
}
