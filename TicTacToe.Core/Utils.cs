using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Core
{
    public class Utils
    {
        static public string ConvertStatusToGraphicalSymbol(Status statusToBeConverted)
        {
            if (statusToBeConverted == Status.Cross)
            {
                return "X";
            }

            if (statusToBeConverted == Status.Circle)
            {
                return "O";
            }

            return " ";
        }

        static public string ConvertStatusToPlayerName(Status statusToBeConverted)
        {
            if (statusToBeConverted == Status.Cross)
            {
                return "CROSS";
            }

            if (statusToBeConverted == Status.Circle)
            {
                return "CIRCLE";
            }

            return "NOBODY";
        }

    }
}
