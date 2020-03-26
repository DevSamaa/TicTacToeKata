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


