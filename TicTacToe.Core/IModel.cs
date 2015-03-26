using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Core
{
    public interface IModel
    {
        void deletePersistentData();
        Game loadPersistentData();
        void saveBoard(Dictionary<Field,Status> board);
        void savePlayer(Status player);
    }
}
