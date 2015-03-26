using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicTacToe.Core;


namespace TicTacToe.Web.ViewsWrappers
{
    public class ViewPresenter : TicTacToe.Core.IView
    {
        public Dictionary<String, String> displayBoardGameForViewBag;
        public String displayGameInformationMessagesForViewBag;
        public String displayQuitGameMessageForViewBag;

        public void DisplayGameboard(Dictionary<String, String> boardStates)
        {
            displayBoardGameForViewBag = new Dictionary<string,string>(boardStates);
        }

        public void DisplayGameInformationMessages(String message)
        {
            displayGameInformationMessagesForViewBag = displayGameInformationMessagesForViewBag + "<p>" + message + "</p>";
        }

        public void Quit()
        {
            displayQuitGameMessageForViewBag = "Close the browser to quit the game";
        }

        public event EventHandler<FieldPlayedEventArgument> GameboardFieldPlayed;
        public event EventHandler<EventArgs> SaveGame;
        public event EventHandler<EventArgs> RestartGame;
    }
}