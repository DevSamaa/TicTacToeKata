using System;
namespace TicTacToeKata
{
    public class UserInput
    {
       
        //needs to capture user input
        //needs to validate user input - check if numbers 1-3 (then minus 1 them because of the index thing)
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

        //eventually i need to send two integers over to the board class - that's where they are processed further.

        //I will get a string that contains 3 characters. give me positon 0(number1) and position 2(number2).

        public (int,int) ProcessUserInput(string incomingUserInput)
        {
            
            var number1 = incomingUserInput[0].ToString();
            var number2 = incomingUserInput[2].ToString();

            bool is1number = int.TryParse(number1, out int result1);
            bool is2number = int.TryParse(number2, out int result2);

            if (is1number && is2number == true)
            {
                var numbers = (firstNumber: result1, secondNumber: result2);
                return numbers;
            }

            throw new Exception("invalid user input");
        }


    }
}

//myBoard.allrows[0][0] = "X";

