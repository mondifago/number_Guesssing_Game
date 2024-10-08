﻿namespace Number_Guessing_Game;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            const int LOWER_GUESSBOUND = 0;
            const int UPPER_GUESSBOUND = 20;
            const int CLOSE_GUESS_THRESHOLD = 5;
            const int MAX_NUM_OF_TRIES = 5;
            int count = 0;
            Random rng = new Random();
            int randomNumber = rng.Next(LOWER_GUESSBOUND, UPPER_GUESSBOUND);
            
            while (count < MAX_NUM_OF_TRIES)
            {
                count++;
                Console.WriteLine($"Guess a number between {LOWER_GUESSBOUND} and {UPPER_GUESSBOUND}");
                string input = Console.ReadLine();
                int userInput;
                if (!int.TryParse(input, out userInput) || LOWER_GUESSBOUND>userInput || UPPER_GUESSBOUND < userInput || string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Invalid Entry !");
                    continue;
                }
                if (randomNumber == userInput)
                {
                    Console.WriteLine("congrats! you win");
                    break;
                }
                if ((randomNumber + CLOSE_GUESS_THRESHOLD) <= userInput)
                {
                    Console.WriteLine("too high");
                    continue;
                }
                if (randomNumber < userInput)
                {
                    Console.WriteLine("High but close");
                    continue;
                }
                if ((randomNumber - CLOSE_GUESS_THRESHOLD) >= userInput)
                {
                    Console.WriteLine("too low");
                    continue;
                }
                else 
                {
                    Console.WriteLine("low but close");
                }
                if  (count == MAX_NUM_OF_TRIES && randomNumber != userInput)
                {
                    Console.WriteLine("Number of tries Exceeded. You Lose!");
                }
            }
            
            Console.WriteLine("Press Enter to play again or any other key to exit.");
            if (Console.ReadKey().Key != ConsoleKey.Enter)
            {
                break;
            }
            Console.WriteLine("\n");
        }
    }
}

