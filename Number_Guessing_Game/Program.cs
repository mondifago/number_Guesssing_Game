namespace Number_Guessing_Game;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Random rng = new Random();
            int randomNumber = rng.Next(0, 20);
            int count = 0;

            while (count < 5)
            {
                count++;
                Console.WriteLine("Guess a number between 0 and 20");
                int userInput = Convert.ToInt32(Console.ReadLine());

                if (randomNumber == userInput)
                {
                    Console.WriteLine("congrats! you win");
                    break;
                }
                if ((randomNumber + 5) <= userInput)
                {
                    Console.WriteLine("too high");
                }
                else if (randomNumber < userInput)
                {
                    Console.WriteLine("High but close");
                }
                else if ((randomNumber - 5) >= userInput)
                {
                    Console.WriteLine("too low");
                }
                else
                {
                    Console.WriteLine("low but close");
                }
                if (count == 5 && randomNumber != userInput)
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

