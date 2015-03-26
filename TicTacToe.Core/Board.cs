using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Core
{
    public class Board
    {
        public Dictionary<Field, Status> boardContent;
        private int BOARD_EMPTY = 0;
        private int BOARD_FULL = 9;

        public Board()
        {
            this.boardContent = new Dictionary<Field, Status>();
        }

        public bool isEmpty()
        {
            return (boardContent.Count == BOARD_EMPTY);
        }

        public bool isFull()
        {
            return (boardContent.Count == BOARD_FULL);
        }

        public Status getStatusOfField(Field fieldToBeReadOut)
        {
            try
            {
                return boardContent[fieldToBeReadOut];
            }
            catch(KeyNotFoundException) 
            {
                return Status.Empty;
            }
        }

        public void setStatusOfField(Status playedItem, Field fieldToBeSet)
        {
            boardContent.Add(fieldToBeSet, playedItem);
        }
    }
}
