using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Core;

namespace TicTacToe.CLI
{
    public class ModelCLI: IModel
    {
        public void deletePersistentData()
        {
            ;
        }

        public Game loadPersistentData()
        {
            return new Game();
        }

        public void saveBoard(Dictionary<Field, Status> board)
        {
            ;
        }

        public void savePlayer(Status player)
        {
            ;
        }
    }
}
