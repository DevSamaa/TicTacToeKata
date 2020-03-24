using System;

namespace TicTacToeKata
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");

            var myBoard = new Board();
            myBoard.PrintBoard();
            //myBoard.allrows[0][0] = "X";
            var userInputInstance = new UserInput();
            string UserInput = userInputInstance.GetUserInput();
            var userInputNumbers = userInputInstance.ProcessUserInput(UserInput);
            Console.WriteLine($"{userInputNumbers.Item1} {userInputNumbers.Item2}");

            //TODO get user input and update the board!
        }
    }
}
