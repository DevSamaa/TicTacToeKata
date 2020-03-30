using System;
namespace TicTacToeKata
{
    public class Board
    {
        public string[][] allrows;

        public string playerName { get; set; }

        public Board()
        {
            string[] row1 = new string[3] { ".", ".", "." };
            string[] row2 = new string[3] { ".", ".", "." };
            string[] row3 = new string[3] { ".", ".", "." };

            allrows = new string[][] { row1, row2, row3 };
        }


        public void PrintBoard()
        {
            Console.WriteLine();
            Console.WriteLine("Here's the current board:");
            foreach (var arrayOfString in allrows)
            {
                Console.WriteLine($"{arrayOfString[0]} {arrayOfString[1]} {arrayOfString[2]}");
            }
            Console.WriteLine();
        }

        //function that checks if coordinate is free, if free places user letter on the board
        public void MarkAField(Coordinate incomingCoordinate, string incomingPlayerName)
        {
            //checks if field is empty
            if (allrows[incomingCoordinate.row][incomingCoordinate.column]==".")
            {
                //changes . to X in field
                allrows[incomingCoordinate.row][incomingCoordinate.column] = incomingPlayerName;
            }
            else
            {
                throw new Exception("That field is already taken, please pick another one");
            }
        }

        

    }
}


