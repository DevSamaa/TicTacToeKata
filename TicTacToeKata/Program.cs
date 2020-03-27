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
            myBoard.playerName = "O";


            while (true)
            {
                //TODO make a class for this
                if (myBoard.playerName == "X")
                {
                    myBoard.playerName = "O";
                }
                else if (myBoard.playerName == "O")
                {
                    myBoard.playerName = "X";
                }

                //gets user input
                var userInputInstance = new UserInput();
                string UserInput = userInputInstance.GetUserInput(myBoard.playerName);
                if (UserInput == "q")
                {
                    break;
                }

                //processes the user input, outputs coordinates
                Coordinate turnCoordinates = userInputInstance.ProcessUserInput2(UserInput, myBoard.playerName);

                //uses coordinates and playername to mark the board
                myBoard.MarkAField(turnCoordinates,myBoard.playerName);

                myBoard.PrintBoard();

                //creates instance of Findwinner and runs the function on it
                var findWinnerInstance = new WinnerFinder(myBoard.allrows);
                bool weHaveAWinner = findWinnerInstance.WeHaveAWinner(myBoard.playerName);

                if (weHaveAWinner)
                {
                    Console.WriteLine($"Congrats player {myBoard.playerName} you win!");
                    break;
                }
                
            }

           

           
        }
    }
}
