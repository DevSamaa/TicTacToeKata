using System;
namespace TicTacToeKata
{
    public class UserInput
    {
       
        //needs to check if user input = q - if so, exit the game
        public UserInput()
        {
        }


        public string GetUserInput()
        {
            Console.WriteLine("(Player 1) enter a coord x,y to place your X or enter 'q' to give up:");
            string userInput = Console.ReadLine();
            return userInput;
            //Console.WriteLine($"this is what the user typed:{userInput}");
        }


        //I will get a string that contains 3 characters. give me positon 0(number1) and position 2(number2).
        public (int,int) ProcessUserInput(string incomingUserInput)
        {
            //converts character to string
            var number1 = incomingUserInput[0].ToString();
            var number2 = incomingUserInput[2].ToString();

            //checks if string is a number by parsing it into an int, also returns true or false
            bool is1number = int.TryParse(number1, out int result1);
            bool is2number = int.TryParse(number2, out int result2);

            if (is1number && is2number == true )
            {
                //this is where NumberValidator is called
                bool isValidNumber = NumberValidator(result1, result2);
                if (isValidNumber == true)
                {

                    var numbers = (firstNumber: result1, secondNumber: result2);
                    //returns two coordiantes
                    return numbers;
                }
                throw new Exception("invalid user input: not a number between 1 and 3");

            }

            throw new Exception("invalid user input: not a number");
        }

        private bool NumberValidator(int incomingNumber1, int incomingNumber2)
        {
            //checke whether incomingNumber = 1,2 or 3
            if (incomingNumber1>0 && incomingNumber1< 4
             && incomingNumber2 >0 && incomingNumber2 < 4)
            {
                return true;
            }
            return false;
            
        }


        public (int,int) CoordinatesCreator(int incomingNumber1, int incomingNumber2)
        {
            //subtract 1 from each number
            incomingNumber1 = incomingNumber1 - 1;
            incomingNumber2 = incomingNumber2 - 1;
            return (incomingNumber1, incomingNumber2);

        }

    }
}


