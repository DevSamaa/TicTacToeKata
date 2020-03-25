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
            Console.WriteLine("Here's the current board:");
            foreach (var arrayOfString in allrows)
            {
                Console.WriteLine($"{arrayOfString[0]} {arrayOfString[1]} {arrayOfString[2]}");
            }
        }

        //function that checks if coordinate is free, if free places user letter on the board
        public void MarksAField(int coordinateOne, int coordinateTwo, string playerName)
        {
            //checks if field is empty
            if (allrows[coordinateOne][coordinateTwo]==".")
            {
                //changes . to X in field
                allrows[coordinateOne][coordinateTwo] = playerName;
            }
            //needs an else - what if the field is alreadt X or O? How do you repeat the input steps?
            
        }

        public bool RowChecker()
        {
            for (int row = 0; row < 3; row++)
            {
                if (allrows[row][0] == playerName && allrows[row][1] == playerName && allrows[row][2] == playerName)
                {
                    return true;
                }
                
            }
            return false;
        }

        public bool ColumnChecker()
        {
            for (int column = 0; column < 3; column++)
            {
                if (allrows[0][column]== playerName && allrows[1][column]== playerName && allrows[2][column]== playerName)
                {
                    return true;
                }
            }
            return false;
        }

        public bool DiagonalChecker()
        {
            if (allrows[0][0]== playerName && allrows[1][1]== playerName && allrows[2][2]== playerName)
            {
                return true;
            }
            else if (allrows[0][2] == "X" && allrows[1][1] == "X" && allrows[2][0] == "X")
            {
                return true;

            }

            return false;
        }

    }
}

//myBoard.allrows[0][0] = "X";

