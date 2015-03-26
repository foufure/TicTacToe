using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Core
{
    public class Game
    {
        public Board gameBoard { get; private set;}
        public Status Player {get; set;}

        private List<List<Field>> winningCombinations;

        public Game()
        {
            gameBoard = new Board();
            this.Player = Status.Cross;

            winningCombinations = new List<List<Field>>
            {
                new List<Field> { Field.A0, Field.A1, Field.A2},
                new List<Field> { Field.B0, Field.B1, Field.B2},
                new List<Field> { Field.C0, Field.C1, Field.C2},
                new List<Field> { Field.A0, Field.B0, Field.C0},
                new List<Field> { Field.A1, Field.B1, Field.C1},
                new List<Field> { Field.A2, Field.B2, Field.C2},
                new List<Field> { Field.A0, Field.B1, Field.C2},
                new List<Field> { Field.A2, Field.B1, Field.C0},
            };
        }

        public void Play(Field fieldToPlay)
        {
            if (isLegalMove(fieldToPlay))
            {
                gameBoard.setStatusOfField(Player, fieldToPlay);
                nextPlayer();
            }
            else 
            {
                throw new IllegalMoveException("Illegal Move");
            }

            if (isEndOfGame())
            {
                throw new GameFinishedException();
            }
        }

        private bool isLegalMove(Field fieldToPlay)
        {
            if (gameBoard.getStatusOfField(fieldToPlay) == Status.Empty && !isEndOfGame())
            {
                return true;
            }

            return false;
        }

        private void nextPlayer()
        {
                if (Player == Status.Cross)
                {
                    Player = Status.Circle;
                }
                else
                {
                    Player = Status.Cross;
                }
        }

        public Status getWinner()
        {
            Status gameWinner = Status.Empty;

            var fieldsFilledWithCross = gameBoard.boardContent.Where(x => x.Value.Equals(Status.Cross)).Select(x => x.Key);
            var fieldsFilledWithCircle = gameBoard.boardContent.Where(x => x.Value.Equals(Status.Circle)).Select(x => x.Key);

            foreach (List<Field> winningCombination in winningCombinations)
            {
                // If winning combination is contained in list of fields filled with a cross or circle, then there is a winner
                if (!winningCombination.Except(fieldsFilledWithCross).Any())
                {
                    return Status.Cross;
                }

                if (!winningCombination.Except(fieldsFilledWithCircle).Any())
                {
                    return Status.Circle;
                }
            }

            return gameWinner;
        }

        public bool isEndOfGame()
        {
            if ((getWinner() != Status.Empty) || gameBoard.isFull())
            {
                return true;
            }

            return false;
        }
    }
}
