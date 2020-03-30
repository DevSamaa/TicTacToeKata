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

            //create two players
            var playerO = new Player("O");
            var playerX = new Player("X");

            //This is called a reference, it holds everything that playero or playerX has.
            Player currentPlayer = playerO;

            while (true)
            {

                
                try
                {
                    //gets user input
                    var userInputInstance = new UserInput();
                    string userInput = userInputInstance.GetUserInput(currentPlayer.playerName);
                    if (userInput == "q")
                    {
                        break;
                    }

                    //processes the user input, outputs coordinates
                    Coordinate turnCoordinates = userInputInstance.CreateCoordinates(userInput);

                    //uses coordinates and playername to mark the board
                    currentPlayer.MarkAField(turnCoordinates, myBoard);

                    myBoard.PrintBoard();

                    //creates instance of Findwinner and runs the function on it
                    var findWinnerInstance = new WinnerFinder(myBoard.allrows);
                    bool weHaveAWinner = findWinnerInstance.WeHaveAWinner(currentPlayer.playerName);

                    if (weHaveAWinner)
                    {
                        Console.WriteLine($"Congrats player {currentPlayer.playerName} you win!");
                        break;
                    }

                   
                    if (currentPlayer == playerX)
                    {
                        currentPlayer = playerO;
                    }
                    else if (currentPlayer == playerO)
                    {
                        currentPlayer = playerX;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }
                
            }

           

           
        }
    }
}
