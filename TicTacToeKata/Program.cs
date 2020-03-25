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

                //processes the user data
                var userInputNumbers = userInputInstance.ProcessUserInput(UserInput);
                //Console.WriteLine($"The userInputNumbers are:{userInputNumbers.Item1} {userInputNumbers.Item2}");
                int firstNumber = userInputNumbers.Item1;
                int secondNumber = userInputNumbers.Item2;

                //creates the coordiantes
                var userCoordinates = userInputInstance.CoordinatesCreator(firstNumber, secondNumber);
                //Console.WriteLine($"The userCoordiantes are:{userCoordinates.Item1} {userCoordinates.Item2} ");
                int firstCoordinate = userCoordinates.Item1;
                int secondCoordinate = userCoordinates.Item2;

                myBoard.MarksAField(firstCoordinate, secondCoordinate, myBoard.playerName);

                myBoard.PrintBoard();
                bool wonRow = myBoard.RowChecker();
                bool wonColumn = myBoard.ColumnChecker();
                bool wonDiagonal = myBoard.DiagonalChecker();

                if (wonRow == true || wonColumn == true|| wonDiagonal==true)
                {
                    Console.WriteLine($"Congrats player {myBoard.playerName} you win!");
                    break;
                }
            }

           

           
        }
    }
}
