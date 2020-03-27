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
        
        public Coordinate ProcessUserInput2(string incomingUserInput)
        {
            ExtractTwoStrings(incomingUserInput);
            string row = ExtractTwoStrings(incomingUserInput).Item1;
            string column = ExtractTwoStrings(incomingUserInput).Item2;

            int rowInt = CheckIfInt(row);
            int columnInt = CheckIfInt(column);

            int validatedRow = ValidateValue(rowInt);
            int validatedColumn = ValidateValue(columnInt);

            int finalRow = SubtractOne(validatedRow);
            int finalColumn = SubtractOne(validatedColumn);

            return new Coordinate(finalRow, finalColumn);

        }

        // 1) extract first and third charcter and turn to string
        public (string, string) ExtractTwoStrings(string incomingUserInput)
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
        private int ValidateValue(int incomingNumber)
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




        //--------------------------
        public Coordinate ProcessUserInput(string incomingUserInput)
        {
            //converts character to string
            var number1 = incomingUserInput[0].ToString();
            var number2 = incomingUserInput[2].ToString();

            //checks if string is a number by parsing it into an int, also returns true or false
            bool is1number = int.TryParse(number1, out int result1);
            bool is2number = int.TryParse(number2, out int result2);

            if (is1number && is2number == true)
            {
                //this is where NumberValidator is called
                bool isValidNumber = ValidateNumbers(result1, result2);
                if (isValidNumber == true)
                {
                    //subtracts one to create coordinates (arrays start at 0, not 1)
                    result1 = result1 - 1;
                    result2 = result2 - 1;
                    return new Coordinate(result1, result2);

                }
                throw new Exception("invalid user input: not a number between 1 and 3");

            }

            throw new Exception("invalid user input: not a number");
        }


        private bool ValidateNumbers(int incomingNumber1, int incomingNumber2)
        {
            //checke whether incomingNumber = 1,2 or 3
            if (incomingNumber1 > 0 && incomingNumber1 < 4
             && incomingNumber2 > 0 && incomingNumber2 < 4)
            {
                return true;
            }
            return false;

        }

    }
}


