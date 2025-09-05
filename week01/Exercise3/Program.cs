using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Random getRandom = new Random();
        int number = getRandom.Next(1, 101);
        int guess = 0;
        do
        {
            Console.Write("What is your guess: ");
            string userInput = Console.ReadLine();
            guess = int.Parse(userInput);

            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != number);
    }
}