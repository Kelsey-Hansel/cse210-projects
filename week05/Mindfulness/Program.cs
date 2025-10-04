using System;

class Program
{
    static void Main(string[] args)
    {
        string userSelection = "";
        while (userSelection != "4")
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            userSelection = Console.ReadLine();
            Console.WriteLine();

            if (userSelection == "1")
            {
                BreathingActivity breathing = new BreathingActivity("Breathing Activity", "This activity will focus on breathing in and out slowly to clear your mind.");
                breathing.Run();
            }
            else if (userSelection == "2")
            {
                ReflectingActivity reflecting = new ReflectingActivity("Reflecting Activity", "This activity will help you to reflect and notice times in your life that you displayed positive traits like strength or resilience.");
                reflecting.Run();
            }
            else if (userSelection == "3")
            {
                ListingActivity listing = new ListingActivity("Listing Activity", "This activity hleps you to reflect and recognize the good things in your life by listing as many things in a certain area as you can think of.");
                listing.Run();
            }
            else
            {
                Console.WriteLine("Thank you!");
            }
        }
    }
}