using System;
namespace TicTacToeKata
{
    public class WinnerFinder
    {
        string[][] allrows;

        public WinnerFinder(string[][] incomingAllrows)
        {
            allrows = incomingAllrows;
        }

        public bool WeHaveAWinner(string incomingPlayerName)
        {
            bool wonRow = CheckRows(incomingPlayerName);
            bool wonColumn = CheckColumns(incomingPlayerName);
            bool wonDiagonal = CheckDiagonals(incomingPlayerName);

            if (wonRow == true || wonColumn == true || wonDiagonal == true)
            {

                return true;
            }
            return false;
        }

        public bool CheckRows(string playerName)
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

        public bool CheckColumns(string playerName)
        {
            for (int column = 0; column < 3; column++)
            {
                if (allrows[0][column] == playerName && allrows[1][column] == playerName && allrows[2][column] == playerName)
                {
                    return true;
                }
            }
            return false;
        }

        public bool CheckDiagonals(string playerName)
        {
            if (allrows[0][0] == playerName && allrows[1][1] == playerName && allrows[2][2] == playerName)
            {
                return true;
            }
            else if (allrows[0][2] == playerName && allrows[1][1] == playerName && allrows[2][0] ==playerName)
            {
                return true;

            }

            return false;
        }


    }
}
