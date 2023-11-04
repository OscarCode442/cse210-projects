using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
    
        int guessNumber;
        int guessCount = 0;

        Console.WriteLine($"What is the magic number? {number} ");
        do
        {
            Console.WriteLine("What is your guess? ");
            string guess = Console.ReadLine();
            guessNumber = int.Parse(guess);
            guessCount++;

            if (number > guessNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (number < guessNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You guessed it in {guessCount} attempts!");
            }
        } while (number != guessNumber);
    }
}
