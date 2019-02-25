using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo to get info
            GreetUser(); //Get user info


            //Loop
            while (true)
            {


                // Init correct number
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                // Init guess var
                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();
                    guess = Convert.ToInt32(input);
                    //Make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        PrintLetterError();                       
                    }
                    else if (guess < 1 || guess > 10)
                    {
                        PrintNumberError();
                    }
                    else
                    {


                        // Cast to int and put in guess
                        guess = Int32.Parse(input);

                        // match guess to correct number
                        if (guess != correctNumber)
                        {
                            IncorrectNumber();
                        }
                        else if (guess == correctNumber)
                        {
                            CorrectNumber();

                        }
                    }
                }
                Console.WriteLine("Play again? [Y/N]");
                string answer = Console.ReadLine().ToUpper();
                Console.ReadLine();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Steve";

            // Change text colour
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Change colour back
            Console.ResetColor();
        }

        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello {0}, let's play a game...", name);
        }

        static void PrintLetterError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter an a number");
            Console.ResetColor();
        }

        static void PrintNumberError()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter a number between 1 and 10");
            Console.ResetColor();
        }

        static void IncorrectNumber()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Nope! Try again");
            Console.ResetColor();
        }

        static void CorrectNumber()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Yeah! well done the correct answer is {0}!", correctNumber);
            Console.ResetColor();
        }
    }
}