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

                
                try
                {
                    //gets user input
                    var userInputInstance = new UserInput();
                    string userInput = userInputInstance.GetUserInput(myBoard.playerName);
                    if (userInput == "q")
                    {
                        break;
                    }

                    //processes the user input, outputs coordinates
                    Coordinate turnCoordinates = userInputInstance.CreateCoordinates(userInput);

                    //uses coordinates and playername to mark the board
                    myBoard.MarkAField(turnCoordinates, myBoard.playerName);

                    myBoard.PrintBoard();

                    //creates instance of Findwinner and runs the function on it
                    var findWinnerInstance = new WinnerFinder(myBoard.allrows);
                    bool weHaveAWinner = findWinnerInstance.WeHaveAWinner(myBoard.playerName);

                    if (weHaveAWinner)
                    {
                        Console.WriteLine($"Congrats player {myBoard.playerName} you win!");
                        break;
                    }

                   
                    if (myBoard.playerName == "X")
                    {
                        myBoard.playerName = "O";
                    }
                    else if (myBoard.playerName == "O")
                    {
                        myBoard.playerName = "X";
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
