using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Journal Program!");

        Journal userJournal = new Journal();
        Entry userEntry = new Entry();
        PromptGenerator newPrompt = new PromptGenerator();
        DateTime entryDate = DateTime.Today;


        string userChoice = "0";
        while (userChoice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                string prompt = newPrompt.GetRandomPrompt();
                userEntry._promptText = prompt;
                Console.WriteLine(prompt);
                Console.Write("> ");
                userEntry._entryText = Console.ReadLine();
                userEntry._date = entryDate.ToShortDateString();
                userJournal.AddEntry(userEntry);
            }
            else if (userChoice == "2")
            {
                userJournal.DisplayAll();
            }
            else if (userChoice == "3")
            {
                Console.Write("Please enter filename: ");
                string file = Console.ReadLine();
                userJournal.LoadFromFile(file);
            }
            else if (userChoice == "4")
            {
                Console.Write("Please enter filename: ");
                string file = Console.ReadLine();
                userJournal.SaveToFile(file);
            }
            else if (userChoice == "5")
            {
                break;
            }
            else
            {
                userChoice = "0";
            }
        }
    }
}