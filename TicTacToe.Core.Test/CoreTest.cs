using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TicTacToe.Core.Test
{
        [TestFixture]
        public class CoreTest
        {
            [Test]
            public void BoardIsEmpty_WhenGameStarts()
            {
                //Arrange

                //Act
                Game testee = new Game();

                //Assert
                Assert.AreEqual(true, testee.gameBoard.isEmpty());
            }

            [Test]
            public void BoardIsNotEmptyAnymore_WhenAPlayerHasPlayed()
            {
                //Arrange
                Game testee = new Game();

                //Act
                testee.Play(Field.A0);

                //Assert
                Assert.AreEqual(false, testee.gameBoard.isEmpty());
            }

            [Test]
            public void BoardContainsACrossInTheLowerLeftCorner_WhenCrossPlayedInFieldAHorizontalAnd0Vertical()
            {
                //Arrange
                Game testee = new Game();

                //Act
                testee.Play(Field.A0);

                //Assert
                Assert.AreEqual(Status.Cross, testee.gameBoard.getStatusOfField(Field.A0));
            }

            [Test]
            public void BoardContainsACircleInTheLowerLeftCorner_WhenCirclePlayedInFieldAHorizontalAnd0Vertical()
            {
                //Arrange
                Game testee = new Game();
                testee.Play(Field.A1);

                //Act
                testee.Play(Field.A0);

                //Assert
                Assert.AreEqual(Status.Circle, testee.gameBoard.getStatusOfField(Field.A0));
            }

            [Test]
            public void BoardContainsACircleInTheCenter_WhenCirclePlayedInFieldBHorizontalAnd1Vertical()
            {
                //Arrange
                Game testee = new Game();
                testee.Play(Field.A1);

                //Act
                testee.Play(Field.B1);

                //Assert
                Assert.AreEqual(Status.Circle, testee.gameBoard.getStatusOfField(Field.B1));
            }

            [Test]
            public void BoardContainsACrossInTheUpperRightCorner_WhenCrossPlayedInFieldCHorizontalAnd2Vertical()
            {
                //Arrange
                Game testee = new Game();

                //Act
                testee.Play(Field.C2);

                //Assert
                Assert.AreEqual(Status.Cross, testee.gameBoard.getStatusOfField(Field.C2));
            }

            [Test]
            public void BoardContainsACrossInTheUpperMiddle_WhenCrossPlayedInFieldBHorizontalAnd2Vertical()
            {
                //Arrange
                Game testee = new Game();

                //Act
                testee.Play(Field.B2);

                //Assert
                Assert.AreEqual(Status.Cross, testee.gameBoard.getStatusOfField(Field.B2));
            }

            [Test]
            public void CrossWins_When3CrossesInRowA()
            {
                //Arrange
                Game testee = new Game();

                //Act
                testee.Play(Field.A0);
                testee.Play(Field.B0);
                testee.Play(Field.A1);
                testee.Play(Field.B1);

                Exception testeeException = Assert.Throws<GameFinishedException>(delegate { testee.Play(Field.A2); });

                //Assert
                Assert.AreEqual(Status.Cross, testee.getWinner());
            }

            [Test]
            public void CircleWins_When3CirclesInRowA()
            {
                //Arrange
                Game testee = new Game();

                //Act
                testee.Play(Field.C0);
                testee.Play(Field.A0);
                testee.Play(Field.C1);
                testee.Play(Field.A1);
                testee.Play(Field.B0);
                Exception testeeException = Assert.Throws<GameFinishedException>(delegate { testee.Play(Field.A2); });

                //Assert
                Assert.AreEqual(Status.Circle, testee.getWinner());
            }

            [Test]
            public void CircleWins_When3CirclesInRowB()
            {
                //Arrange
                Game testee = new Game();

                //Act
                testee.Play(Field.A0);
                testee.Play(Field.B0);
                testee.Play(Field.A1);
                testee.Play(Field.B1);
                testee.Play(Field.C0);

                Exception testeeException = Assert.Throws<GameFinishedException>(delegate { testee.Play(Field.B2); });

                //Assert
                Assert.AreEqual(Status.Circle, testee.getWinner());
            }

            [Test]
            public void CircleWins_When3CirclesInRowC()
            {
                //Arrange
                Game testee = new Game();

                //Act
                testee.Play(Field.A0);
                testee.Play(Field.C0);
                testee.Play(Field.A1);
                testee.Play(Field.C1);
                testee.Play(Field.B0);

                Exception testeeException = Assert.Throws<GameFinishedException>(delegate { testee.Play(Field.C2); });

                //Assert
                Assert.AreEqual(Status.Circle, testee.getWinner());
            }

            [Test]
            public void CircleWins_When3CirclesInLine0()
            {
                //Arrange
                Game testee = new Game();

                //Act
                testee.Play(Field.A1);
                testee.Play(Field.A0);
                testee.Play(Field.B1);
                testee.Play(Field.B0);
                testee.Play(Field.C2);
               
                Exception testeeException = Assert.Throws<GameFinishedException>(delegate { testee.Play(Field.C0); });

                //Assert
                Assert.AreEqual(Status.Circle, testee.getWinner());
            }

            [Test]
            public void CircleWins_When3CirclesInLine1()
            {
                //Arrange
                Game testee = new Game();

                //Act
                testee.Play(Field.A0);
                testee.Play(Field.A1);
                testee.Play(Field.A2);
                testee.Play(Field.B1);
                testee.Play(Field.B0);
               
                Exception testeeException = Assert.Throws<GameFinishedException>(delegate { testee.Play(Field.C1); });

                //Assert
                Assert.AreEqual(Status.Circle, testee.getWinner());
            }

            [Test]
            public void CircleWins_When3CirclesInLine2()
            {
                //Arrange
                Game testee = new Game();

                //Act
                testee.Play(Field.A0);
                testee.Play(Field.A2);
                testee.Play(Field.A1);
                testee.Play(Field.B2);
                testee.Play(Field.C0);

                Exception testeeException = Assert.Throws<GameFinishedException>(delegate { testee.Play(Field.C2); });

                //Assert
                Assert.AreEqual(Status.Circle, testee.getWinner());
            }

            [Test]
            public void NobodyWins_WhenNoCompleteRow()
            {
                //Arrange
                Game testee = new Game();

                //Act
                testee.Play(Field.A0);
                testee.Play(Field.A1);
                testee.Play(Field.A2);

                //Assert
                Assert.AreEqual(Status.Empty, testee.getWinner());
            }

            [Test]
            public void CrossWins_When3CrossInDiagonalLowerUpper()
            {
                //Arrange
                Game testee = new Game();

                //Act
                testee.Play(Field.A0);
                testee.Play(Field.B0);
                testee.Play(Field.B1);
                testee.Play(Field.B2);

                Exception testeeException = Assert.Throws<GameFinishedException>(delegate { testee.Play(Field.C2); });

                //Assert
                Assert.AreEqual(Status.Cross, testee.getWinner());
            }

            [Test]
            public void CrossWins_When3CrossInDiagonalUpperLower()
            {
                //Arrange
                Game testee = new Game();

                //Act
                testee.Play(Field.A2);
                testee.Play(Field.A0);
                testee.Play(Field.B1);
                testee.Play(Field.A1);

                Exception testeeException = Assert.Throws<GameFinishedException>(delegate { testee.Play(Field.C0); });

                //Assert
                Assert.AreEqual(Status.Cross, testee.getWinner());
            }

            [Test]
            public void ExceptionIllegalMoveThrown_WhenTryingToPlayACircleOnANonEmptyField()
            {
                //Arrange
                Game testee = new Game();

                //Act
                testee.Play(Field.B1);
                Exception testeeException = Assert.Throws<IllegalMoveException>(delegate { testee.Play(Field.B1); });
                
                //Assert
                StringAssert.AreEqualIgnoringCase("Illegal Move", testeeException.Message);
                Assert.AreEqual(Status.Cross, testee.gameBoard.getStatusOfField(Field.B1));
            }

            [Test]
            public void BoardIsFull_WhenEverybodyHasPlayedAllTheirTurns()
            {
                //Arrange
                Game testee = new Game();

                //Act
                testee.Play(Field.A0);
                testee.Play(Field.A2);
                testee.Play(Field.A1);   
                testee.Play(Field.B0);
                testee.Play(Field.B1);
                testee.Play(Field.C1);
                testee.Play(Field.B2);
                testee.Play(Field.C2);
                
                Exception testeeException = Assert.Throws<GameFinishedException>(delegate { testee.Play(Field.C0); });

                //Assert
                Assert.IsTrue(testee.gameBoard.isFull());
            }

            [Test]
            public void GameIsFinished_WhenThereIsAWinner()
            {
                //Arrange
                Game testee = new Game();

                //Act
                testee.Play(Field.A0);
                testee.Play(Field.B0);
                testee.Play(Field.A1);
                testee.Play(Field.B1);

                Exception testeeException = Assert.Throws<GameFinishedException>(delegate { testee.Play(Field.A2); });

                //Assert
                Assert.IsTrue(testee.isEndOfGame());
            }

            [Test]
            public void GameIsFinished_WhenThereIsNoWinnerButBoardIsFull()
            {
                //Arrange
                Game testee = new Game();

                //Act
                testee.Play(Field.A0);
                testee.Play(Field.A2);
                testee.Play(Field.A1);
                testee.Play(Field.B0);
                testee.Play(Field.B1);
                testee.Play(Field.C1);
                testee.Play(Field.B2);
                testee.Play(Field.C2);

                Exception testeeException = Assert.Throws<GameFinishedException>(delegate { testee.Play(Field.C0); });

                //Assert
                Assert.IsTrue(testee.isEndOfGame());
            }

            [Test]
            public void GameIsNotFinished_WhenThereIsNoWinnerAndBoardIsNotFull()
            {
                //Arrange
                Game testee = new Game();

                //Act
                testee.Play(Field.A0);
                testee.Play(Field.A2);
                testee.Play(Field.A1); 
                testee.Play(Field.B0);
                testee.Play(Field.B1);
                testee.Play(Field.C1);
                testee.Play(Field.B2);
                //Assert
                Assert.IsFalse(testee.isEndOfGame());
            }
        }
}
