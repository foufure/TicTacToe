using System;
using TechTalk.SpecFlow;
using TicTacToe.Core;
using NUnit.Framework;

namespace TicTacToe.BDD.Specflow
{
    [Binding]
    public class TicTacToeSteps
    {
        private Game testee;

        [Given(@"I have started a game")]
        public void GivenIHaveStartedAGame()
        {
            testee = new Game();
        }
        
        [Given(@"I have entered a ""(.*)"" at position ""(.*)""")]
        public void GivenIHaveEnteredAAtPosition(string p0, string p1)
        {
            ScenarioContext.Current.Pending();

            Field field = Field.A0;

         

            switch (p0)
            { 
                case "A0":
                    field = Field.A0;
                    break;
                case "A1":
                    field = Field.A1;
                    break;
                case "A2":
                    field = Field.A2;
                    break;
                case "B0":
                    field = Field.B0;
                    break;
                case "B1":
                    field = Field.B1;
                    break;
                case "B2":
                    field = Field.B2;
                    break;
                case "C0":
                    field = Field.C0;
                    break;
                case "C1":
                    field = Field.C1;
                    break;
                case "C2":
                    field = Field.C2;
                    break;
                default:
                    break;
            }

            testee.Play(field);
        }
        
        [When(@"I enter a ""(.*)"" at position ""(.*)""")]
        public void WhenIEnterAAtPosition(string p0, string p1)
        {
            ScenarioContext.Current.Pending();

            Field field = Field.A0;

          

            switch (p0)
            {
                case "A0":
                    field = Field.A0;
                    break;
                case "A1":
                    field = Field.A1;
                    break;
                case "A2":
                    field = Field.A2;
                    break;
                case "B0":
                    field = Field.B0;
                    break;
                case "B1":
                    field = Field.B1;
                    break;
                case "B2":
                    field = Field.B2;
                    break;
                case "C0":
                    field = Field.C0;
                    break;
                case "C1":
                    field = Field.C1;
                    break;
                case "C2":
                    field = Field.C2;
                    break;
                default:
                    break;
            }

            testee.Play(field);
        }
        
        [Then(@"the ""(.*)"" is the winner")]
        public void ThenTheIsTheWinner(string p0)
        {
            ScenarioContext.Current.Pending();

            Status player = Status.Empty;

            if (p0 == "X")
            {
                player = Status.Cross;
            }
            else
            {
                player = Status.Circle;
            }

            Assert.AreEqual(player, testee.getWinner());
        }
    }
}
