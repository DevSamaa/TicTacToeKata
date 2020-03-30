using System;
namespace TicTacToeKata
{
    public class Player
    {
        public string playerName { get; set; }


        public Player(string incomingPlayerName)
        {
             playerName = incomingPlayerName;
            
        }

        //function that checks if coordinate is free, if free places user letter on the board
        public void MarkAField(Coordinate incomingCoordinate, Board incomingBoard)
        {
            //checks if field is empty
            if (incomingBoard.allrows[incomingCoordinate.row][incomingCoordinate.column] == ".")
            {
                //changes . to X in field
                incomingBoard.allrows[incomingCoordinate.row][incomingCoordinate.column] = playerName;
            }
            else
            {
                throw new Exception("That field is already taken, please pick another one");
            }
        }
    }
}


