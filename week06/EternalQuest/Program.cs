using System;

class Program
{
    static void Main(string[] args)
    {
        string userSelection = "0";

        while (userSelection != "6")
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("     1. Create New Goal");
            Console.WriteLine("     2. List Goals");
            Console.WriteLine("     3. Save Goals");
            Console.WriteLine("     4. Load Goals");
            Console.WriteLine("     5. Record Event");
            Console.WriteLine("     6. Quit");
            Console.Write("Select a choice from the menu: ");
            userSelection = Console.ReadLine();

            if (userSelection == "1")
            {
                Console.WriteLine("1");
            }
            else if (userSelection == "2")
            {
                Console.WriteLine("2");
            }
            else if (userSelection == "3")
            {
                Console.WriteLine("3");
            }
            else if (userSelection == "4")
            {
                Console.WriteLine("4");
            }
            else if (userSelection == "5")
            {
                Console.WriteLine("5");
            }
            else if (userSelection == "6")
            {
                Console.WriteLine("6");
            }
        }
    }
}