using System;
using System.ComponentModel;

namespace LearningCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Rock paper scissors game

            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;

            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";
                
                if(player != "ROCK" && player != "SCISSORS" && player != "PAPER")
                {
                    Console.WriteLine("Enter ROCK, PAPER or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                switch(random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }

                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch(player)
                {
                    case "ROCK":
                        if(computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw.");
                        }
                        else if(computer == "PAPER")
                        {
                            Console.WriteLine("You lose.");
                        }
                        else
                        {
                            Console.WriteLine("You win!");
                        }
                        break;
                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You win!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw.");
                        }
                        else
                        {
                            Console.WriteLine("You lose.");
                        }
                        break;
                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You lose.");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You win!");
                        }
                        else
                        {
                            Console.WriteLine("You lose.");
                        }
                        break;
                }

                Console.WriteLine("Do you want to play again? (Y/N) ");
                answer = Console.ReadLine();

                if(answer == "Y")
                {
                    playAgain = true;
                }
                else if(answer == "N")
                {
                    playAgain = false;
                }
               
            }

            Console.WriteLine("Thank you for playin the ROCK PAPER SCISSORS GAME!");

            Console.ReadKey();
        }
    }
}
