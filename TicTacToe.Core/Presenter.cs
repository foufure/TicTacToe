using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Core
{
    public class Presenter
    {
        private Game gameModel;
        public IView gameView;
        public IModel model;
        private Dictionary<String, String> gameboardPresentation;

        public Presenter(IView view, IModel model)
        {
            this.gameView = view;
            this.model = model;

            gameModel = this.model.loadPersistentData();
            gameboardPresentation = new Dictionary<string, string>();

            view.GameboardFieldPlayed += onGameboardFieldPlayed;
            view.SaveGame += onSaveGame;
            view.RestartGame += onRestartGame;

            view.DisplayGameInformationMessages("Player " + Utils.ConvertStatusToPlayerName(gameModel.Player) + " plays");
            view.DisplayGameboard(gameBoardPresentation());
        }

        public void onGameboardFieldPlayed(object sender, FieldPlayedEventArgument fieldPlayed)
        {
            try
            {
                gameModel.Play(fieldPlayed.field);
                gameView.DisplayGameInformationMessages("Player " + Utils.ConvertStatusToPlayerName(gameModel.Player) + " plays");
            }
            catch (GameFinishedException)
            {
                gameView.DisplayGameInformationMessages("The winner is: " + Utils.ConvertStatusToPlayerName(gameModel.getWinner()));
                gameView.DisplayGameboard(gameBoardPresentation());
                gameView.Quit();
            }
            catch (IllegalMoveException e)
            {
                gameView.DisplayGameInformationMessages(e.Message);
            }
            finally 
            {     
                gameView.DisplayGameboard(gameBoardPresentation());
            }
        }

        public void onSaveGame(object sender, EventArgs e)
        {
            model.deletePersistentData();
            model.saveBoard(gameModel.gameBoard.boardContent);
            model.savePlayer(gameModel.Player);
        }

        public void onRestartGame(object sender, EventArgs e)
        {
            model.deletePersistentData();
            gameModel = new Game();
            gameView.DisplayGameboard(gameBoardPresentation());  
        }

        private Dictionary<String, String> gameBoardPresentation()
        {
            gameboardPresentation["A0"] = Utils.ConvertStatusToGraphicalSymbol(gameModel.gameBoard.getStatusOfField(Field.A0));
            gameboardPresentation["A1"] = Utils.ConvertStatusToGraphicalSymbol(gameModel.gameBoard.getStatusOfField(Field.A1));
            gameboardPresentation["A2"] = Utils.ConvertStatusToGraphicalSymbol(gameModel.gameBoard.getStatusOfField(Field.A2));
            gameboardPresentation["B0"] = Utils.ConvertStatusToGraphicalSymbol(gameModel.gameBoard.getStatusOfField(Field.B0));
            gameboardPresentation["B1"] = Utils.ConvertStatusToGraphicalSymbol(gameModel.gameBoard.getStatusOfField(Field.B1));
            gameboardPresentation["B2"] = Utils.ConvertStatusToGraphicalSymbol(gameModel.gameBoard.getStatusOfField(Field.B2));
            gameboardPresentation["C0"] = Utils.ConvertStatusToGraphicalSymbol(gameModel.gameBoard.getStatusOfField(Field.C0));
            gameboardPresentation["C1"] = Utils.ConvertStatusToGraphicalSymbol(gameModel.gameBoard.getStatusOfField(Field.C1));
            gameboardPresentation["C2"] = Utils.ConvertStatusToGraphicalSymbol(gameModel.gameBoard.getStatusOfField(Field.C2));
            
            return gameboardPresentation;
        }
    }
}
