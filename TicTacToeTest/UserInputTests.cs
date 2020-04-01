using System;
using TicTacToeKata;
using Xunit;

namespace TicTacToeTest
{
    public class UserInputTests
    {
        [Fact]
        public void SubtractOne_Given1_ShouldBe0()
        {
            //arrange
            int testingNumber = 1;

            //action
            var userInputInstance = new UserInput();
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
            var userInputInstance = new UserInput();
            int result = userInputInstance.SubtractOne(incomingNumber);

            //assert

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(1,1)]
        //[InlineData(4, Exception)]
        public void ValidateValue_GivenNumbers1to3_ShouldReturnNumber(int incomingNumber, int expected)
        {
            var userInputInstance = new UserInput();
            var result = userInputInstance.ValidateValue(incomingNumber);

            Assert.Equal(expected, result);
        }

        //How can I test the exception part?
        //[Theory]
        //[InlineData(4, Exception)]
        //public void ValidateValue_GivenNumbers4AndHigher_ShouldReturnException(int incomingNumber, Exception expected)
        //{
        //    var userInputInstance = new UserInput();
        //    var result = userInputInstance.ValidateValue(incomingNumber);

        //    Assert.Equal(expected, result);
        //}


        [Theory]
        [InlineData("1", 1)]
        [InlineData("2", 2)]
        [InlineData("3", 3)]

        public void CheckIfInt_GivenNumberString_ShouldReturnInt(string incomingNumber, int expected)
        {
            var userInputInstance = new UserInput();
            var result = userInputInstance.CheckIfInt(incomingNumber);

            Assert.Equal(expected, result);
        }
    }
}


