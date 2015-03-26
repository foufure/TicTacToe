using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NSubstitute;

namespace TicTacToe.Core.Test
{
    [TestFixture]
    public class PresenterTest
    {
        [Test]
        public void DisplayedTextWinnerCIRCLEIsConsistent_WhenGameFinished()
        {
            //Arrange
            Dictionary<String, String> boardStates = new Dictionary<string, string>()
            {
                { "A0", " "},
                { "A1", "X"},
                { "A2", "O"},
                { "B0", "X"},
                { "B1", "O"},
                { "B2", "X"},
                { "C0", "O"},
                { "C1", " "},
                { "C2", " "}
            };

            IView _mockedView = Substitute.For<IView>();
            IModel _mockedModel = Substitute.For<IModel>();
            _mockedModel.loadPersistentData().Returns<Game>(new Game());
            Presenter testee = new Presenter(_mockedView, _mockedModel);
            FieldPlayedEventArgument argument = new FieldPlayedEventArgument();

            //Act
            argument.field = Field.A1;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);
            argument.field = Field.A2;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);
            argument.field = Field.B0;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);
            argument.field = Field.B1;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);
            argument.field = Field.B2;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);
            argument.field = Field.C0;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);

            //Assert
            _mockedView.Received().DisplayGameInformationMessages("Player CROSS plays");
            _mockedView.Received().DisplayGameInformationMessages("Player CIRCLE plays");
            _mockedView.Received().DisplayGameInformationMessages("The winner is: CIRCLE");

            _mockedView.Received().DisplayGameboard(Arg.Is<Dictionary<String,String>>(x => 
                                                                                x["A0"] == boardStates["A0"] &&
                                                                                x["A1"] == boardStates["A1"] &&
                                                                                x["A2"] == boardStates["A2"] &&
                                                                                x["B0"] == boardStates["B0"] &&
                                                                                x["B1"] == boardStates["B1"] &&
                                                                                x["B2"] == boardStates["B2"] &&
                                                                                x["C0"] == boardStates["C0"] &&
                                                                                x["C1"] == boardStates["C1"] &&
                                                                                x["C2"] == boardStates["C2"])
                                                                                );
            _mockedView.Received(1).Quit();
        }

        [Test]
        public void DisplayedTextWinnerCROSSIsConsistent_WhenGameFinished()
        {
            //Arrange
            Dictionary<String, String> boardStates = new Dictionary<string, string>()
            {
                { "A0", "X"},
                { "A1", "O"},
                { "A2", "X"},
                { "B0", "O"},
                { "B1", "X"},
                { "B2", "O"},
                { "C0", "X"},
                { "C1", " "},
                { "C2", " "}
            };

            IView _mockedView = Substitute.For<IView>();
            IModel _mockedModel = Substitute.For<IModel>();
            _mockedModel.loadPersistentData().Returns<Game>(new Game());
            Presenter testee = new Presenter(_mockedView, _mockedModel);
            FieldPlayedEventArgument argument = new FieldPlayedEventArgument();

            //Act
            argument.field = Field.A0;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);
            argument.field = Field.A1;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);
            argument.field = Field.A2;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);
            argument.field = Field.B0;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);
            argument.field = Field.B1;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);
            argument.field = Field.B2;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);
            argument.field = Field.C0;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);

            //Assert
            _mockedView.Received().DisplayGameInformationMessages("The winner is: CROSS");

            _mockedView.Received().DisplayGameboard(Arg.Is<Dictionary<String, String>>(x =>
                                                                                x["A0"] == boardStates["A0"] &&
                                                                                x["A1"] == boardStates["A1"] &&
                                                                                x["A2"] == boardStates["A2"] &&
                                                                                x["B0"] == boardStates["B0"] &&
                                                                                x["B1"] == boardStates["B1"] &&
                                                                                x["B2"] == boardStates["B2"] &&
                                                                                x["C0"] == boardStates["C0"] &&
                                                                                x["C1"] == boardStates["C1"] &&
                                                                                x["C2"] == boardStates["C2"])
                                                                                );
            _mockedView.Received(1).Quit();
        }

        [Test]
        public void DisplayedTextWinnerNOBODYIsConsistent_WhenGameFinished()
        {
            //Arrange
            Dictionary<String, String> boardStates = new Dictionary<string, string>()
            {
                { "A0", "X"},
                { "A1", "X"},
                { "A2", "O"},
                { "B0", "O"},
                { "B1", "X"},
                { "B2", "X"},
                { "C0", "X"},
                { "C1", "O"},
                { "C2", "O"}
            };

            IView _mockedView = Substitute.For<IView>();
            IModel _mockedModel = Substitute.For<IModel>();
            _mockedModel.loadPersistentData().Returns<Game>(new Game());
            Presenter testee = new Presenter(_mockedView, _mockedModel);
            FieldPlayedEventArgument argument = new FieldPlayedEventArgument();

            //Act
            argument.field = Field.B1;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);
            argument.field = Field.A2;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);
            argument.field = Field.A1;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);
            argument.field = Field.C1;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);
            argument.field = Field.A0;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);
            argument.field = Field.C2;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);
            argument.field = Field.C0;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);
            argument.field = Field.B0;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);
            argument.field = Field.B2;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);

            //Assert
            _mockedView.Received().DisplayGameInformationMessages("The winner is: NOBODY");

            _mockedView.Received().DisplayGameboard(Arg.Is<Dictionary<String, String>>(x =>
                                                                                x["A0"] == boardStates["A0"] &&
                                                                                x["A1"] == boardStates["A1"] &&
                                                                                x["A2"] == boardStates["A2"] &&
                                                                                x["B0"] == boardStates["B0"] &&
                                                                                x["B1"] == boardStates["B1"] &&
                                                                                x["B2"] == boardStates["B2"] &&
                                                                                x["C0"] == boardStates["C0"] &&
                                                                                x["C1"] == boardStates["C1"] &&
                                                                                x["C2"] == boardStates["C2"])
                                                                                );
            _mockedView.Received(1).Quit();
        }

        [Test]
        public void DisplayedExceptionText_WhenIllegalMove()
        {
            //Arrange
            IView _mockedView = Substitute.For<IView>();
            IModel _mockedModel = Substitute.For<IModel>();
            _mockedModel.loadPersistentData().Returns<Game>(new Game());
            Presenter testee = new Presenter(_mockedView, _mockedModel);
            FieldPlayedEventArgument argument = new FieldPlayedEventArgument();

            //Act
            argument.field = Field.B1;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);
            argument.field = Field.A2;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);
            argument.field = Field.A2;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);
            argument.field = Field.A1;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);
            argument.field = Field.C1;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);
            argument.field = Field.A0;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);
            argument.field = Field.C2;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);
            argument.field = Field.C0;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);
            argument.field = Field.B0;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);
            argument.field = Field.B2;
            _mockedView.GameboardFieldPlayed += Raise.EventWith<FieldPlayedEventArgument>(argument);
            
            //Assert
            _mockedView.Received().DisplayGameInformationMessages("Illegal Move");
        }
    }
}
