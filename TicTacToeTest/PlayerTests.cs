using System;
using System.Collections.Generic;
using TicTacToeKata;
using Xunit;

namespace TicTacToeTest
{
    public class PlayerTests
    {
        public PlayerTests()
        {
        }

        [Fact]
        public void MarkAField_GivenX_ShouldMarkField()
        {
            //arrange
            var instanceOfPlayer = new Player("X");
            var instanceOfCoordinate = new Coordinate(1,1);
            var instanceOfBoard = new Board();

            //action
            //calls the method, and marks ONE field on the Board
            var actualBoard = instanceOfPlayer.MarkAField(instanceOfCoordinate, instanceOfBoard);

            // extracts that ONE field, so that in the next step you can compare that ONE field (NOT ENTIRE BOARD) to the expected outcome.
            var actualField = actualBoard.allrows[instanceOfCoordinate.row][instanceOfCoordinate.column];

            //assert
            Assert.Equal("X", actualField);

        }


        //TODO use MemberData instead
        public static IEnumerable<object[]> GetTestData()
        {
            yield return new object[] { new Coordinate(1, 1), new Player("X"), "X" };
            yield return new object[] { new Coordinate(2, 0), new Player("O"), "O" };
            yield return new object[] { new Coordinate(0, 0), new Player("X"), "X" };
        }

        [Theory]
        [MemberData(nameof(GetTestData))]
      
        public void MarkAField_GivenXorO_ShouldMarkField(Coordinate incomingCoordinate, Player incomingPlayer, string expected)
        {
            //arrange
            var instanceOfBoard = new Board();

            //action
            //calls the method, and marks ONE field on the Board
            var actualBoard = incomingPlayer.MarkAField(incomingCoordinate, instanceOfBoard);

            // extracts that ONE field, so that in the next step you can compare that ONE field (NOT ENTIRE BOARD) to the expected outcome.
            var actualField = actualBoard.allrows[incomingCoordinate.row][incomingCoordinate.column];

            //assert
            Assert.Equal(expected, actualField);

        }

    }
}

