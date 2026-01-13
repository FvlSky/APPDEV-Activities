using System;

namespace RockPaperScissors
{
    class Program
    {
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
                    case 1:
                        computerChoice = "ROCK";
                        break;
                    case 2:
                        computerChoice = "PAPER";
                        break;
                    case 3:
                        computerChoice = "SCISSORS";
                        break;
                }

                Console.WriteLine("Computer chose: " + computerChoice);

                if (userChoice == computerChoice)
                {
                    Console.WriteLine("It's a DRAW!");
                }
                else if (userChoice == "ROCK")
                {
                    if (computerChoice == "PAPER")
                        Console.WriteLine("You LOSE! Paper covers Rock.");
                    else
                        Console.WriteLine("You WIN! Rock smashes Scissors.");
                }
                else if (userChoice == "PAPER")
                {
                    if (computerChoice == "SCISSORS")
                        Console.WriteLine("You LOSE! Scissors cut Paper.");
                    else
                        Console.WriteLine("You WIN! Paper covers Rock.");
                }
                else if (userChoice == "SCISSORS")
                {
                    if (computerChoice == "ROCK")
                        Console.WriteLine("You LOSE! Rock smashes Scissors.");
                    else
                        Console.WriteLine("You WIN! Scissors cut Paper.");
                }
                else
                {
                    Console.WriteLine("Invalid entry! Please check your spelling.");
                }

                Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("REVERT THIS! This line is for testing the revert function in git");
                Console.WriteLine("-----------------------------------------------------------------");
                 Console.WriteLine("-----------------------------------------------------------------");
                Console.WriteLine("REVERT THIS! This line is for testing the revert function in git");
                Console.WriteLine("-----------------------------------------------------------------");

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