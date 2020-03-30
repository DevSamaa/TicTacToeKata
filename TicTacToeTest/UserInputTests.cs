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

        //put the other UserInputClass Tests in here!
    }
}
