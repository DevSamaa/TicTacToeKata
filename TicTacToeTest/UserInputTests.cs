using System;
using System.Collections.Generic;
using TicTacToeKata;
using Xunit;

namespace TicTacToeTest
{
    public class UserInputTests
    {
        public UserInput userInputInstance;

        public UserInputTests()
        {
            userInputInstance = new UserInput();
        }

        [Fact]
        public void SubtractOne_Given1_ShouldBe0()
        {
            //arrange
            int testingNumber = 1;

            //action
            int result = userInputInstance.SubtractOne(testingNumber);

            //assert
            Assert.Equal(0, result);
        }

        //arrange
        [Theory]
        [InlineData(1,0)]
        [InlineData(2,1)]
        [InlineData(3,2)]
        public void SubtractOne_GivenANumber_ShouldReturnCorrectly(int incomingNumber, int expected)
        {
            //action
            int result = userInputInstance.SubtractOne(incomingNumber);

            //assert

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1,1)]
        [InlineData(2,2)]
        [InlineData(3,3)]
        public void ValidateValue_GivenNumbers1to3_ShouldReturnNumber(int incomingNumber, int expected)
        {
            var result = userInputInstance.ValidateValue(incomingNumber);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void ValidateValue_Given4_ShouldThrowException()
        {

            var exception = Assert.Throws<Exception>(() => userInputInstance.ValidateValue(4));

            Assert.Equal("invalid user input: not a number between 1 and 3", exception.Message);
        }


        [Theory]
        [InlineData(4)]
        [InlineData(42)]
        [InlineData(4977666)]
        [InlineData(0)]
        [InlineData(-6)]


        public void ValidateValue_GivenIninvalidNumbers_ShouldThrowException(int incomingNumber)
        {

            var exception = Assert.Throws<Exception>(() => userInputInstance.ValidateValue(incomingNumber));

            Assert.Equal("invalid user input: not a number between 1 and 3", exception.Message);
        }



        [Theory]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        [InlineData("3", 3)]

        public void CheckIfInt_GivenNumberString_ShouldReturnInt(string incomingNumber, int expected)
        {
            var result = userInputInstance.CheckIfInt(incomingNumber);

            Assert.Equal(expected, result);
        }


        // Testing the Create Coordinates method with Inline Data ------------------------------------------------------------

        [Theory]
        [InlineData("2,2", 1,1)]
        [InlineData("3,1", 2,0)]
        [InlineData("1,1", 0,0)]
        public void CreateCoordinates_GivenNumberStrings_ShouldReturnCoordinates(string incomingString, int row, int column)
        {
            var result = userInputInstance.CreateCoordinates(incomingString);
            var expectedCoordinate = new Coordinate(row, column);

            Assert.Equal(expectedCoordinate.row, result.row);
            Assert.Equal(expectedCoordinate.column, result.column);
           
        }


        // The same test as above, but with Member Data---------------------------------------------------------------------

        public static IEnumerable<object[]> GetCoordinates()
        {
            yield return new object[] { "2,2", 1, 1 };
            yield return new object[] { "3,1", 2, 0 };
            yield return new object[] { "1,1", 0, 0 };
        }

        [Theory]
      
        [MemberData(nameof(GetCoordinates))]
        public void CreateCoordinates_GivenNumberStringsFromMemberData_ShouldReturnCoordinates(string incomingString, int row, int column)
        {
            var result = userInputInstance.CreateCoordinates(incomingString);
            var expectedCoordinate = new Coordinate(row, column);

            Assert.Equal(expectedCoordinate.row, result.row);
            Assert.Equal(expectedCoordinate.column, result.column);
        }


        // Another version with Member Data, these tests fail, because it's comparing the memory address (also known as instances) of the two object rather than the actual value-----------------------------------------------------
        //in the future you can try to do this again with a different library (fluent assertion)

        public static IEnumerable<object[]> GetCoordinates2()
        {
            yield return new object[] { "2,2", new Coordinate(1,1) };
            yield return new object[] { "3,1", new Coordinate(2,0) };
            yield return new object[] { "1,1", new Coordinate(0,0) };
        }

        [Theory]

        [MemberData(nameof(GetCoordinates2))]
        public void CreateCoordinates_GivenNumberStringsFromMemberData2_ShouldReturnCoordinates(string incomingString, Coordinate expectedCoordinate)
        {
            var result = userInputInstance.CreateCoordinates(incomingString);

            //Assert.Equal(expectedCoordinate.row, result.row);
            //Assert.Equal(expectedCoordinate.column, result.column);
            Assert.True(expectedCoordinate.Equals(result));
        }

    }
}



