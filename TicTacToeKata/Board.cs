using System;
namespace TicTacToeKata
{
    public class Board
    {
        public string[][] allrows;
        bool userXTurn = true;

        public Board()
        {
            string[] row1 = new string[3] { ".", ".", "." };
            string[] row2 = new string[3] { ".", ".", "." };
            string[] row3 = new string[3] { ".", ".", "." };

            allrows = new string[][] { row1, row2, row3 };
        }


        public void PrintBoard()
        {
            Console.WriteLine("Here's the current board:");
            foreach (var arrayOfString in allrows)
            {
                Console.WriteLine($"{arrayOfString[0]} {arrayOfString[1]} {arrayOfString[2]}");
            }
        }

        //function that checks if coordinate is free, if free places user letter on the board

        //for the first iteration - just have one player place their letter
    }
}


