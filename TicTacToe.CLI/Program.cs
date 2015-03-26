using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Core;

namespace TicTacToe.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            IView view = new ViewCLI();
            
            view.DisplayGameInformationMessages("Welcome To TicTacToe!");
            view.DisplayGameInformationMessages("Rules: Press on the number of the field to play");
            view.DisplayGameInformationMessages("3 | 6 | 9");
            view.DisplayGameInformationMessages("2 | 5 | 8");
            view.DisplayGameInformationMessages("1 | 4 | 7");

            IModel model = new ModelCLI();

            Presenter TicTacToeGame = new Presenter(view, model);

            while (true)
            {
                ((ViewCLI)view).firePlayedFieldEvent();
            }

        }
    }
}
