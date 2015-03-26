using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Core
{
    public class FieldPlayedEventArgument: EventArgs
    {
        public Field field { get; set; }
    }
}
