using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TicTacToe.Core;

namespace TicTacToe.Core.Test
{
    [TestFixture]
    public class UtilsTest
    {
        [Test]
        public void ConvertsStatusCross_ToStringX()
        {
            //Arrange
            Status statusToBeConverted = Status.Cross;
            string testee = " ";

            //Act
            testee = Utils.ConvertStatusToGraphicalSymbol(statusToBeConverted);
            
            //Assert
            StringAssert.AreEqualIgnoringCase("X", testee);   
        }

        [Test]
        public void ConvertsStatusCircle_ToStringO()
        {
            //Arrange
            Status statusToBeConverted = Status.Circle;
            string testee = " ";

            //Act
            testee = Utils.ConvertStatusToGraphicalSymbol(statusToBeConverted);

            //Assert
            StringAssert.AreEqualIgnoringCase("O", testee);
        }

        [Test]
        public void ConvertsStatusEmpty_ToStringEmpty()
        {
            //Arrange
            Status statusToBeConverted = Status.Empty;
            string testee = " ";

            //Act
            testee = Utils.ConvertStatusToGraphicalSymbol(statusToBeConverted);

            //Assert
            StringAssert.AreEqualIgnoringCase(" ", testee);
        }

        [Test]
        public void ConvertsStatusCross_ToTextCROSS()
        {
            //Arrange
            Status statusToBeConverted = Status.Cross;
            string testee = " ";

            //Act
            testee = Utils.ConvertStatusToPlayerName(statusToBeConverted);

            //Assert
            StringAssert.AreEqualIgnoringCase("CROSS", testee);
        }

        [Test]
        public void ConvertsStatusCircle_ToTextCIRCLE()
        {
            //Arrange
            Status statusToBeConverted = Status.Circle;
            string testee = " ";

            //Act
            testee = Utils.ConvertStatusToPlayerName(statusToBeConverted);

            //Assert
            StringAssert.AreEqualIgnoringCase("CIRCLE", testee);
        }

        [Test]
        public void ConvertsStatusEmpty_ToTextNOBODY()
        {
            //Arrange
            Status statusToBeConverted = Status.Empty;
            string testee = " ";

            //Act
            testee = Utils.ConvertStatusToPlayerName(statusToBeConverted);

            //Assert
            StringAssert.AreEqualIgnoringCase("NOBODY", testee);
        }

    }
}
