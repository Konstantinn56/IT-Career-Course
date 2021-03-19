using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Paper_Scissors
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] allChoices = { "rock", "paper", "scissors" };
            bool playAgain = true;
            while (playAgain)
            {
                List<int> playerAndComputerPoints = new List<int>() { 0, 0 };
                PrintGameTitle();

                while (playerAndComputerPoints[0] < 3 || playerAndComputerPoints[1] < 3)
                {
                    
                    Console.Write("Pick rock, paper or scissors:");
                    string playerChoice = Console.ReadLine().ToLower();
                    string computerChoice = GetComputerChoice(allChoices);

                    switch (playerChoice)
                    {
                        case "rock":
                            if (computerChoice.Equals("rock"))
                            {
                                playerAndComputerPoints[0] += 1;
                                playerAndComputerPoints[1] += 1;
                                PrintComputerChoice("rock");
                                Console.WriteLine("Draw!");
                                PrintStats(playerAndComputerPoints);
                            }
                            
                            else if (computerChoice.Equals("paper"))
                            {
                                playerAndComputerPoints[1] += 1;
                                PrintComputerChoice("paper");
                                PrintTheWinner("Computer");
                                PrintStats(playerAndComputerPoints);
                            }

                            else if (computerChoice.Equals("scissors"))
                            {
                                playerAndComputerPoints[0] += 1;
                                PrintComputerChoice("scissors");
                                PrintTheWinner("You");
                                PrintStats(playerAndComputerPoints);
                            }
                            break;

                        case "paper":
                            if (computerChoice.Equals("rock"))
                            {
                                playerAndComputerPoints[0] += 1;
                                PrintComputerChoice("rock");
                                PrintTheWinner("You");
                                PrintStats(playerAndComputerPoints);
                            }
                            else if (computerChoice.Equals("paper"))
                            {
                                playerAndComputerPoints[0] += 1;
                                playerAndComputerPoints[1] += 1;
                                PrintComputerChoice("paper");
                                Console.WriteLine("Draw!");
                                PrintStats(playerAndComputerPoints);
                            }
                            else if (computerChoice.Equals("scissors"))
                            {
                                playerAndComputerPoints[1] += 1;
                                PrintComputerChoice("scissors");
                                PrintTheWinner("Computer");
                                PrintStats(playerAndComputerPoints);
                            }
                            break;

                        case "scissors":
                            if (computerChoice.Equals("rock"))
                            {
                                playerAndComputerPoints[1] += 1;
                                PrintComputerChoice("rock");
                                PrintTheWinner("Computer");
                                PrintStats(playerAndComputerPoints);
                            }
                            else if (computerChoice.Equals("paper"))
                            {
                                playerAndComputerPoints[0] += 1;
                                PrintComputerChoice("paper");
                                PrintTheWinner("Player");
                                PrintStats(playerAndComputerPoints);
                            }
                            else if (computerChoice.Equals("scissors"))
                            {
                                playerAndComputerPoints[0] += 1;
                                playerAndComputerPoints[1] += 1;
                                PrintComputerChoice("scissors");
                                Console.WriteLine("Draw!");
                            }
                            break;
                        default:
                            Console.WriteLine("Wrong Input!");
                            break;
                    }
                    if (playerAndComputerPoints[0] == 3 && playerAndComputerPoints[1] == 3)
                    {

                    }
                    else if (playerAndComputerPoints[0] == 3 || playerAndComputerPoints[1] == 3)
                    {
                        break;
                    }
                }

                PrintEndOfTheGame(playerAndComputerPoints);

                while (true)
                {
                    Console.Write("Do you want to play again(y/n): ");
                    string playAgainn = Console.ReadLine();
                    if (playAgainn.Equals("y"))
                    {
                        playAgain = true;
                        break;
                    }
                    else if (playAgainn.Equals("n"))
                    {
                        playAgain = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input!");
                    }
                }
                
            }
            PrintEndGame();
        }
        static void PrintEndGame()
        {
            Console.WriteLine("Thanks for playing!");
            Console.WriteLine("by:Konstantin");
        }
        static void PrintEndOfTheGame(List<int> playerAndComputerPoints)
        {
            PrintAndCompareStatsOfTheGame(playerAndComputerPoints);
            Console.WriteLine("-------------------------");
        }
        static void PrintAndCompareStatsOfTheGame(List<int> playerAndComputerPoints)
        {
            if(playerAndComputerPoints[0] > playerAndComputerPoints[1])
            {
                Console.WriteLine("You are the Winner!!!");
                Console.WriteLine($"Stats:{string.Join(":", playerAndComputerPoints)}");
            }
            else
            {
                Console.WriteLine("You lose, Computer is the Winner!");
                Console.WriteLine($"Stats:{string.Join(":",playerAndComputerPoints)}");
            }
        }
        static void PrintStats(List<int> stats)
        {
            Console.WriteLine($"Stats: You {stats[0]}, computer {stats[1]}");
        }
        static void PrintTheWinner(string winner)
        {
            Console.WriteLine($"{winner} win!");
        }
        static void PrintComputerChoice(string choice)
        {
            Console.WriteLine($"Computer choise: {choice}");
        }
        static string GetComputerChoice(string[] allChoices)
        {
            var random = new Random();
            int indexOfChoice = random.Next(allChoices.Length);
            return allChoices[indexOfChoice];
        }
        static void PrintGameTitle()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Rock Paper Scissors Game!");
            Console.WriteLine("-------------------------");
        }
    }
}
