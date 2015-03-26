using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Core;

namespace TicTacToeDBModel
{
    public class TicTacToeModelAsDB: IModel
    {
        private TicTacToeModelContainer model;

        public TicTacToeModelAsDB()
        {
            model = new TicTacToeModelContainer();
        }
        
        public void deletePersistentData()
        {
            model.GameBoardSet.RemoveRange(model.GameBoardSet.ToList());
            model.PlayerSet.RemoveRange(model.PlayerSet.ToList());
            model.SaveChanges();
        }

        public Game loadPersistentData()
        {
            Game gameModel = new Game();
            List<GameBoard> gameBoardList = model.GameBoardSet.ToList<GameBoard>();

            foreach (GameBoard gameBoard in gameBoardList)
            {
                gameModel.gameBoard.boardContent.Add((Field)gameBoard.Field, (Status)gameBoard.FieldStatus);
            }

            Player player = model.PlayerSet.ToList<Player>().FirstOrDefault();

            if (player == null)
            {
                gameModel.Player = Status.Cross;
            }
            else
            {
                gameModel.Player = (Status)player.CurrentPlayer;
            }

            return gameModel;
        }

        public void saveBoard(Dictionary<Field, Status> board)
        {
            foreach (KeyValuePair<Field, Status> boardField in board)
            {
                GameBoard gameBoard = new GameBoard();
                gameBoard.Field = (Int32)boardField.Key;
                gameBoard.FieldStatus = (Int32)boardField.Value;
                model.GameBoardSet.Add(gameBoard);
            }

            model.SaveChanges();
        }

        public void savePlayer(Status player)
        {
            Player playerDB = new Player();
            playerDB.CurrentPlayer = (Int32)player;
            model.PlayerSet.Add(playerDB);
            model.SaveChanges();
        }
    }
}
