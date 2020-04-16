using System;
namespace TicTacToeKata
{
    public class Coordinate
    {
        public int row{ get; set; }
        public int column{ get; set; }

        public Coordinate (int incomingRow, int incomingColumn)
        {
            row = incomingRow;
            column = incomingColumn;
        }
    }
}


