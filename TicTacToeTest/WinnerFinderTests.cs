using System;
using Xunit;
using TicTacToeKata;

namespace TicTacToeTest
{
    public class WinnerFinderTests
    {
        [Fact]
        public void CheckRows_GivenFullRow_ShouldReturnTrue_V1()
        {
            //arrange
            //playerName to be checked
            string playerName = "X";

            //new instance of board with allrows property
            var instanceOfBoard = new Board();
            string[][] instanceOfAllrows = instanceOfBoard.allrows;

            //marking row 0 with all X's(playerName)
            instanceOfAllrows[0][0] = playerName;
            instanceOfAllrows[0][1] = playerName;
            instanceOfAllrows[0][2] = playerName;

            //new instance of the WinnerFinder function
            var instanceOfWinnerFinder = new WinnerFinder(instanceOfAllrows);

            //action
            bool rowHasWinner = instanceOfWinnerFinder.CheckRows(playerName);

            //assert
            Assert.Equal(true, rowHasWinner);
        }

        [Fact]
       public void CheckRows_GivenFullRow_ShouldReturnTrue_V2()
        {
            //arrange
            //playerName to be checked
            string playerName = "X";

            //new instance of board with allrows property

            string[] row1 = new string[3] { "X", "X", "X" };
            string[] row2 = new string[3] { ".", ".", "." };
            string[] row3 = new string[3] { ".", ".", "." };

            string[][]allrows = new string[][] { row1, row2, row3 };


            //new instance of the WinnerFinder function
            var instanceOfWinnerFinder = new WinnerFinder(allrows);

            //action
            bool rowHasWinner = instanceOfWinnerFinder.CheckRows(playerName);

            //assert
            Assert.Equal(true, rowHasWinner);
        }

        [Fact]
        public void CheckColumns_GivenFullColumn_ShouldReturnTrue()
        {
            //arrange
            //playerName to be checked
            string playerName = "X";

            //new instance of board with allrows property

            string[] row1 = new string[3] { ".", "X", "." };
            string[] row2 = new string[3] { ".", "X", "." };
            string[] row3 = new string[3] { ".", "X", "." };

            string[][] allrows = new string[][] { new string[3] { ".", "X", "." }, row2, row3 };


            //new instance of the WinnerFinder function
            var instanceOfWinnerFinder = new WinnerFinder(allrows);

            //action
            bool columnHasWinner = instanceOfWinnerFinder.CheckColumns(playerName);

            //assert
            Assert.Equal(true, columnHasWinner);
        }

        [Theory]
        [InlineData( new string[3] { ".", "X", "." },
                     new string[3] { ".", "X", "." },
                     new string[3] { ".", "X", "." },true)]

        [InlineData( new string[3] { ".", "O", "." },
                     new string[3] { ".", "X", "." },
                     new string[3] { ".", "X", "." },false)]

        [InlineData( new string[3] { ".", "O", "X" },
                     new string[3] { ".", "O", "X" },
                     new string[3] { "O", ".", "X" }, true)]

        public void CheckColumns_GivenFullColumn_ShouldReturnTrue_Inline(string[]row1, string[]row2, string[]row3, bool expected)
        {
            //arrange
            string playerName = "X";
            string[][] allrows = new string[][] { row1, row2, row3 };
            var instanceOfWinnerFinder = new WinnerFinder(allrows);

            //action
            bool columnHasWinner = instanceOfWinnerFinder.CheckColumns(playerName);

            //assert
            Assert.Equal(expected, columnHasWinner);
        }


        [Theory]
        [InlineData(new string[3] { "X", "O", "." },
                    new string[3] { ".", "X", "." },
                    new string[3] { ".", "O", "X" }, true)]

        [InlineData(new string[3] { "X", "O", "." },
                    new string[3] { "X", ".", "." },
                    new string[3] { ".", "O", "X" }, false)]
        public void CheckDiagonals_GivenFullDiagonal_ShouldReturnTrue(string[] row1, string[] row2, string[] row3, bool expected)
        {
            //arrange
            string playerName = "X";
            string[][] allrows = new string[][] { row1, row2, row3 };
            var instanceOfWinnerFinder = new WinnerFinder(allrows);

            //action
            bool diagonalHasWinner = instanceOfWinnerFinder.CheckDiagonals(playerName);

            //assert
            Assert.Equal(expected, diagonalHasWinner);
        }
    }
}



