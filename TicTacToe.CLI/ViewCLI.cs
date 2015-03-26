using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Core;

namespace TicTacToe.CLI
{
    public class ViewCLI: IView
    {
        public void DisplayGameboard(Dictionary<String,String> boardStates)
        {
            Console.WriteLine("{0} | {1} | {2}", boardStates["A2"], boardStates["B2"], boardStates["C2"]);
            Console.WriteLine("{0} | {1} | {2}", boardStates["A1"], boardStates["B1"], boardStates["C1"]);
            Console.WriteLine("{0} | {1} | {2}", boardStates["A0"], boardStates["B0"], boardStates["C0"]);
        }

        public void DisplayGameInformationMessages(String message)
        {
            Console.WriteLine(message);
        }

        public void Quit()
        {
            DisplayGameInformationMessages("Press ENTER to quit the game!");
            Console.ReadLine();
            System.Environment.Exit(0);
        }

        public event EventHandler<FieldPlayedEventArgument> GameboardFieldPlayed;
        public event EventHandler<EventArgs> SaveGame;
        public event EventHandler<EventArgs> RestartGame;

        public void firePlayedFieldEvent()
        {
            try
            {
                FieldPlayedEventArgument fieldPlayed = new FieldPlayedEventArgument();
                fieldPlayed.field = (Field)Convert.ToUInt32(Console.ReadLine());
                
                if(fieldPlayed.field > Enum.GetValues(typeof(Field)).Cast<Field>().Max() || fieldPlayed.field == 0)
                {
                    throw new Exception("Illegal Field!");
                }
                else
                {
                    GameboardFieldPlayed(this, fieldPlayed); //Fire Event
                }
            }
            catch (Exception e)
            {
                DisplayGameInformationMessages(e.Message);
            }
        }
    }
}
