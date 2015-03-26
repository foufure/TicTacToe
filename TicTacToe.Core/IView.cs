using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Core
{
    public interface IView
    {
        void DisplayGameboard(Dictionary<String,String> boardStates);
        void DisplayGameInformationMessages(String message);
        void Quit();

        event EventHandler<FieldPlayedEventArgument> GameboardFieldPlayed;
        event EventHandler<EventArgs> SaveGame;
        event EventHandler<EventArgs> RestartGame;
    }
}
