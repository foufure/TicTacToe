using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Core
{
    public class IllegalMoveException: Exception
    {
        public IllegalMoveException(String message)
                : base(message)
        { 
        
        }
    }

    public class GameFinishedException : Exception
    {
        public GameFinishedException()
        {

        }
    }
}
