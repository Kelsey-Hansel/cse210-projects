using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        } while (userNumber != 0);

        Console.WriteLine($"{numbers.Count}");

        float sum = 0.0f;
        int largestNumber = 0;
        float average;

        for (int i = 0; i < numbers.Count; i++)
        {
            sum = sum + numbers[i];
            if (numbers[i] > largestNumber)
            {
                largestNumber = numbers[i];
            }
        }

        average = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}