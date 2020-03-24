using System;

namespace TicTacToeKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");

            //instantiates the board
            var myBoard = new Board();
            myBoard.PrintBoard();

            //gets user input
            var userInputInstance = new UserInput();
            string UserInput = userInputInstance.GetUserInput();

            //processes the user data
            var userInputNumbers = userInputInstance.ProcessUserInput(UserInput);
            Console.WriteLine($"The userInputNumbers are:{userInputNumbers.Item1} {userInputNumbers.Item2}");
            int firstNumber = userInputNumbers.Item1;
            int secondNumber = userInputNumbers.Item2;

            //creates the coordiantes
            var userCoordinates = userInputInstance.CoordinatesCreator(firstNumber, secondNumber);
            Console.WriteLine($"The userCoordiantes are:{userCoordinates.Item1} {userCoordinates.Item2} ");
            int firstCoordinate = userCoordinates.Item1;
            int secondCoordinate = userCoordinates.Item2;

            //myBoard.allrows[userCoordinates.Item1][userCoordinates.Item2] = "X";
            //myBoard.allrows[0][0] = "X";
            myBoard.MarksAField(firstCoordinate, secondCoordinate);

            myBoard.PrintBoard();

            //TODO get user input and update the board!
        }
    }
}
