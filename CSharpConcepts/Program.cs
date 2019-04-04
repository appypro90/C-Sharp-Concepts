using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcepts
{
    class Program
    {
        static int GetGuess()
        {
            Console.WriteLine("Please guess a number.");
            string userNumber = Console.ReadLine();
            int number = 0;
            Int32.TryParse(userNumber, out number);
            return number;
              
        }
        static void Main(string[] args)
        {
            //this piece of code is for while loop.
            const int ourNumber = 10;
            int guessNumber = GetGuess();

            while (ourNumber != guessNumber)
            {

                if (ourNumber == guessNumber)
                {
                    Console.WriteLine("You guessed right number.");
                }

                else
                {
                    Console.WriteLine("You didn't guess right number.");
                    guessNumber = GetGuess();
                }

            }

            ////this piece of code is for 'for' loop
            for (int i = 10; i > 0; i--)
            {
                if (ourNumber == guessNumber)
                {
                    Console.WriteLine("You guessed right number.");
                    break;
                }

                else if (ourNumber < guessNumber)
                {
                    Console.WriteLine("Its too high. You have {0} guess left.", i - 1);
                    guessNumber = GetGuess();
                }
                else
                {
                    Console.WriteLine("Its too low. You have {0} guess left.", i - 1);
                    guessNumber = GetGuess();
                }
            }

            for (int i = 10; i > 0; i--)
            {
                guessNumber = GetGuess();
                switch (guessNumber)
                {
                    case(ourNumber):
                        Console.WriteLine("You guessed right number.");
                        i = 0;
                        break;
                    case (1):
                        Console.WriteLine("Its too low. You have {0} guess left.", i);
                        break;
                    case (100):
                        Console.WriteLine("Its too high. You have {0} guess left.", i);
                        break;
                    default:
                        Console.WriteLine("You didn't guess right number.", i);
                        if (ourNumber < guessNumber)
                        {
                            Console.WriteLine("Its too high. You have {0} guess left.", i - 1);
                            guessNumber = GetGuess();
                        }
                        else if (ourNumber > guessNumber)
                        {
                            Console.WriteLine("Its too low. You have {0} guess left.", i - 1);
                            guessNumber = GetGuess();
                        }
                        break;
                }
            }


        }
    }
}
