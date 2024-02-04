namespace Number_Guessing_Game;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            const int LOWER_GUESSBOUND = 0;
            const int UPPER_GUESSBOUND = 20;
            const int CLOSE_GUESS_THRESHOLD = 5;
            const int UPPER_COUNTBOUND = 5;
            int count = 0;
            Random rng = new Random();
            int randomNumber = rng.Next(LOWER_GUESSBOUND, UPPER_GUESSBOUND);
            
            while (count < UPPER_COUNTBOUND)
            {
                count++;
                Console.WriteLine("Guess a number between 0 and 20");
                int userInput = Convert.ToInt32(Console.ReadLine());

                if (randomNumber == userInput)
                {
                    Console.WriteLine("congrats! you win");
                    break;
                }
                if ((randomNumber + CLOSE_GUESS_THRESHOLD) <= userInput)
                {
                    Console.WriteLine("too high");
                }
                else if (randomNumber < userInput)
                {
                    Console.WriteLine("High but close");
                }
                else if ((randomNumber - CLOSE_GUESS_THRESHOLD) >= userInput)
                {
                    Console.WriteLine("too low");
                }
                else
                {
                    Console.WriteLine("low but close");
                }
                if (count == UPPER_COUNTBOUND && randomNumber != userInput)
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

