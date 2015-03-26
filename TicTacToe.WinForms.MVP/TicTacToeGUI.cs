using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe.Core;

namespace TicTacToe.WinForms.MVP
{
    public partial class TicTacToeGUI : Form, IView
    {

        public TicTacToeGUI()
        {
            InitializeComponent();
        }

        public void DisplayGameboard(Dictionary<String, String> boardStates)
        {
            this.TicTacToeGameBoard.Controls.Find("A0", false)[0].Text = boardStates["A0"];
            this.TicTacToeGameBoard.Controls.Find("A1", false)[0].Text = boardStates["A1"];
            this.TicTacToeGameBoard.Controls.Find("A2", false)[0].Text = boardStates["A2"];
            this.TicTacToeGameBoard.Controls.Find("B0", false)[0].Text = boardStates["B0"];
            this.TicTacToeGameBoard.Controls.Find("B1", false)[0].Text = boardStates["B1"];
            this.TicTacToeGameBoard.Controls.Find("B2", false)[0].Text = boardStates["B2"];
            this.TicTacToeGameBoard.Controls.Find("C0", false)[0].Text = boardStates["C0"];
            this.TicTacToeGameBoard.Controls.Find("C1", false)[0].Text = boardStates["C1"];
            this.TicTacToeGameBoard.Controls.Find("C2", false)[0].Text = boardStates["C2"];
        }

        public void DisplayGameInformationMessages(String message)
        {
            this.GameInformation.Text = this.GameInformation.Text + "\r\n" + message;
        }

        public void Quit()
        {
            DisplayGameInformationMessages("Close the window to quit the game!");
        }

        public event EventHandler<FieldPlayedEventArgument> GameboardFieldPlayed;
        public event EventHandler<EventArgs> SaveGame;
        public event EventHandler<EventArgs> RestartGame;
        
        //Fire a generic Event for each clicked BoardGameField
        private void firePlayedFieldEvent(Field field)
        {
            FieldPlayedEventArgument fieldPlayed = new FieldPlayedEventArgument();
            fieldPlayed.field = field;
            GameboardFieldPlayed(this, fieldPlayed); //Fire Event
        }

        private void A2_Click(object sender, EventArgs e)
        {
            firePlayedFieldEvent(Field.A2);
        }

        private void B2_Click(object sender, EventArgs e)
        {
            firePlayedFieldEvent(Field.B2);
        }

        private void C2_Click(object sender, EventArgs e)
        {
            firePlayedFieldEvent(Field.C2);
        }

        private void A1_Click(object sender, EventArgs e)
        {
            firePlayedFieldEvent(Field.A1);
        }

        private void B1_Click(object sender, EventArgs e)
        {
            firePlayedFieldEvent(Field.B1);
        }

        private void C1_Click(object sender, EventArgs e)
        {
            firePlayedFieldEvent(Field.C1);
        }

        private void A0_Click(object sender, EventArgs e)
        {
            firePlayedFieldEvent(Field.A0);
        }

        private void B0_Click(object sender, EventArgs e)
        {
            firePlayedFieldEvent(Field.B0);
        }

        private void C0_Click(object sender, EventArgs e)
        {
            firePlayedFieldEvent(Field.C0);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveGame(this, new EventArgs());
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            RestartGame(this, new EventArgs());
        }
    }
}
