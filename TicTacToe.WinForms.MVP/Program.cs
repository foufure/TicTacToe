using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Core;
using TicTacToeDBModel;

namespace TicTacToe.WinForms.MVP
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

            IView view = new TicTacToeGUI();
            view.DisplayGameInformationMessages("Welcome To TicTacToe!");

            IModel model = new TicTacToeModelAsDB();

            Presenter presenter = new Presenter(view, model);
            
            Application.Run((Form)view);
        }
    }
}
