using System;
namespace TicTacToeKata
{
    public class Player
    {
        public string playerName { get; set; }

        string[][] allrows;

        public Player(string incomingPlayerName, string[][] incomingAllRows)
        {
             playerName = incomingPlayerName;
             allrows = incomingAllRows;
        }

        //function that checks if coordinate is free, if free places user letter on the board
        public void MarkAField(Coordinate incomingCoordinate, string incomingPlayerName)
        {
            //checks if field is empty
            if (allrows[incomingCoordinate.row][incomingCoordinate.column] == ".")
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


