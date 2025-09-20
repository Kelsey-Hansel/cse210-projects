using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("2 Nephi", 4, 16);
        string text = "Behold, my soul delighteth in the things of the Lord; and my heart pondereth continually upon the things which I have seen and heard.";
        Scripture scripture = new Scripture(reference, text);

        while (scripture.IsCompletelyHidden() != true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Press Enter to contiue or type 'quit' to stop.");
            var userInput = Console.ReadLine();

            if (userInput == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
    }
}