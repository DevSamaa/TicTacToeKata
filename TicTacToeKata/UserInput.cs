using System;
namespace TicTacToeKata
{
    public class UserInput
    {
        public UserInput()
        {
        }

        public string GetUserInput(string incomingUserName)
        {
            Console.WriteLine($"{incomingUserName} enter a coord x,y to place your {incomingUserName} or enter 'q' to give up:");
            string userInput = Console.ReadLine();
            return userInput;
        }
        
        public Coordinate CreateCoordinates(string incomingUserInput)
        {
            var userInputStrings = ExtractTwoStrings(incomingUserInput);

            string row = userInputStrings.Item1;
            string column = userInputStrings.Item2;

            int finalRow = ProcessUserInput(row);
            int finalColumn = ProcessUserInput(column);

            return new Coordinate(finalRow, finalColumn);

        }

        private int ProcessUserInput(string incomingString)
        {
            int checkedInt = CheckIfInt(incomingString);
            int validatedInt = ValidateValue(checkedInt);
            int zeroIndexed = SubtractOne(validatedInt);
            return zeroIndexed;
        }

        // 1) extract first and third charcter and turn to string
        private (string, string) ExtractTwoStrings(string incomingUserInput)
        {
            string row = incomingUserInput[0].ToString();
            string column = incomingUserInput[2].ToString();
            return (row, column);
        }


        // 2) check if string is integer 
        public int CheckIfInt(string incomingUserInput)
        {
            bool InputIsNumber = int.TryParse(incomingUserInput, out int result);
            if (InputIsNumber)
            {
                return result;
            }
            throw new Exception("invalid user input: not a number");


        }

        // 3) check if integer is between 1 and 3
        public int ValidateValue(int incomingNumber)
        {
            if (incomingNumber > 0 && incomingNumber < 4)
            {
                return incomingNumber;
            }
            throw new Exception("invalid user input: not a number between 1 and 3");

        }


        // 4) subtract 1 from number to turn it into coordinate
        public int SubtractOne (int incomingNumber)
        {
            incomingNumber = incomingNumber - 1;
            return incomingNumber;
        }



    }
}


