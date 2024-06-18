using System;
using System.ComponentModel;

namespace LearningCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Number guessing game

            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 10;
            int guess;
            int guesses;
            int number;
            String response;

            while ( playAgain)
            {
                guess = 0;
                guesses = 0;
                number = random.Next(min, max + 1);
                response = "";

                while ( guess != number )
                {
                    Console.WriteLine("Guess a number between " + min + "-" + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if(guess > number)
                    {
                        Console.WriteLine(guess + " is too high.");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is too low.");
                    }
                    guesses++;
                }
                Console.WriteLine("Guess: " + guess);
                Console.WriteLine("Congratulations! You win.");
                Console.WriteLine("Guesses: " + guesses);

                Console.WriteLine("Do you want to play again (Y/N)?: ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if(response == "Y")
                {
                    playAgain = true;
                }
                else if(response == "N")
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thank you for playing the guessing game.");

            Console.ReadKey();
        }
    }
}
