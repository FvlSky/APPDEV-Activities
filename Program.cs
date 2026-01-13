using System;

namespace RockPaperScissors
{
    class Program
    {
        static int userScore = 0;
        static int computerScore = 0;

        static void PrintScore() 
        {
            Console.WriteLine($"\nYour Score:  {userScore}");
            Console.WriteLine($"Computer's Score:  {computerScore}");
        }

        static void Main(string[] args)
        {
            bool playAgain = true;

            while (playAgain)
            {
                Console.Clear();
                Console.WriteLine("----------------------------------");
                Console.WriteLine("Welcome to Rock, Paper, Scissors!");
                Console.WriteLine("----------------------------------");

                Console.Write("Enter Rock, Paper, or Scissors: ");
                string userChoice = Console.ReadLine().ToUpper();

                Random random = new Random();
                int randomNum = random.Next(1, 4);

                string computerChoice = "";

                switch (randomNum)
                {
                    case 1: computerChoice = "ROCK"; break;
                    case 2: computerChoice = "PAPER"; break;
                    case 3: computerChoice = "SCISSORS"; break;
                }

                Console.WriteLine("Computer chose: " + computerChoice);

                if (userChoice == computerChoice)
                {
                    Console.WriteLine("It's a DRAW!");
                }
                else if (userChoice == "ROCK")
                {
                    if (computerChoice == "PAPER")
                    {
                        Console.WriteLine("You LOSE! Paper covers Rock.");
                        computerScore++; 
                    }
                    else
                    {
                        Console.WriteLine("You WIN! Rock smashes Scissors.");
                        userScore++; 
                    }
                }
                else if (userChoice == "PAPER")
                {
                    if (computerChoice == "SCISSORS")
                    {
                        Console.WriteLine("You LOSE! Scissors cut Paper.");
                        computerScore++;
                    }
                    else
                    {
                        Console.WriteLine("You WIN! Paper covers Rock.");
                        userScore++;
                    }
                }
                else if (userChoice == "SCISSORS")
                {
                    if (computerChoice == "ROCK")
                    {
                        Console.WriteLine("You LOSE! Rock smashes Scissors.");
                        computerScore++;
                    }
                    else
                    {
                        Console.WriteLine("You WIN! Scissors cut Paper.");
                        userScore++;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid entry! Please check your spelling.");
                }

                PrintScore(); 

                Console.WriteLine("\nDo you want to play again? (Y/N):");
                string answer = Console.ReadLine().ToUpper();

                if (answer == "N")
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing!");
        }
    }
}