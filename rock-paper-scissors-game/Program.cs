using System;

namespace rock_paper_scissors_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World! Welcome to my rock, paper scissors game!");

            string[] computer = { "rock", "paper", "scissors"};

            bool isRunning = true;

            int computerWins = 0;
            
            int userWins = 0;

            while (isRunning == true && userWins != 3 && computerWins != 3)
            {
                Console.WriteLine("\nEnter rock, paper or scissors:");

                string userInput = Console.ReadLine().ToLower();

                Random randomOutput = new Random();

                int computerResponseIndex = randomOutput.Next(0, computer.Length);

                string computerResponse = (computer[computerResponseIndex]);

                if (!(userInput == "rock" || userInput == "paper" || userInput == "scissors"))
                {
                    Console.WriteLine("Error! Please enter rock, paper or scissors");
                    Console.WriteLine("******************************");
                }
                else if (string.Equals(userInput, computerResponse))
                {
                    Console.WriteLine("******************************");
                    Console.WriteLine($"User Wins: {userWins}, Computer Wins: {computerWins}\n");
                    Console.WriteLine($"User: {userInput} , Computer {computerResponse}");
                    Console.WriteLine("It's a draw! No points awarded!");
                    Console.WriteLine("******************************\n");
                }
                else if (userInput == "rock" && computerResponse == "scissors")
                {
                    userWins++;
                    Console.WriteLine("******************************");
                    Console.WriteLine($"User Wins: {userWins}, Computer Wins: {computerWins}\n");
                    Console.WriteLine($"User: {userInput} , Computer {computerResponse}");
                    Console.WriteLine("User wins a point!");
                    Console.WriteLine("******************************\n");
                }
                else if (userInput == "paper" && computerResponse == "rock")
                {
                    userWins++;
                    Console.WriteLine("******************************");
                    Console.WriteLine($"User Wins: {userWins}, Computer Wins: {computerWins}\n");
                    Console.WriteLine($"User: {userInput}, Computer {computerResponse}");
                    Console.WriteLine("User wins a point!");
                    Console.WriteLine("******************************\n");
                }
                else if (userInput == "scissors" && computerResponse == "paper")
                {
                    userWins++;
                    Console.WriteLine("******************************");
                    Console.WriteLine($"User Wins: {userWins}, Computer Wins: {computerWins}\n");
                    Console.WriteLine($"User: {userInput}, Computer {computerResponse}");
                    Console.WriteLine("User wins a point!");
                    Console.WriteLine("******************************\n");
                }
                else
                {
                    computerWins++;
                    Console.WriteLine("******************************");
                    Console.WriteLine($"User Wins: {userWins}, Computer Wins: {computerWins}\n");
                    Console.WriteLine($"User: {userInput}, Computer {computerResponse}");
                    Console.WriteLine("Computer wins a point!");
                    Console.WriteLine("******************************\n");
                }
            }

            if (userWins == 3)
            {
                Console.WriteLine("Congratulations! User has won the game!");
            }
            else
            {
                Console.WriteLine("Sorry! Computer has won the game!");
            }

            Console.ReadLine();
        }
    }
}
