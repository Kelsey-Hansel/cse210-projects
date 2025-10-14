public class GoalManager
{
    private List<Goal> __goals = new List<Goal>();
    private int _score = 0;

    public GoalManager()
    {

    }

    public void Start()
    {
        string userSelection = "0";

        while (userSelection != "6")
        {
            DisplayPlayerInfo();

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
                CreateGoal();
            }
            else if (userSelection == "2")
            {
                ListGoalDetails();
            }
            else if (userSelection == "3")
            {
                SaveGoals();
            }
            else if (userSelection == "4")
            {
                LoadGoals();
            }
            else if (userSelection == "5")
            {
                RecordEvent();
            }
            else if (userSelection == "6")
            {
                Console.WriteLine("Thank you for playing!");
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_score} points");
        Console.WriteLine();
    }
    public void ListGoalNames()
    {
        for (int i = 0; i < _goals.count; i++)
        {
            
        }
    }
    public void ListGoalDetails()
    {
        Goal goal = new Goal();
        
    }
    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("     1. Simple Goal");
        Console.WriteLine("     2. Eternal Goal");
        Console.WriteLine("     3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string goalType = Console.ReadLine();
        if (goalType == "1")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of your goal? ");
            string description = Console.ReadLine();

            Console.Write("How many points will be associated with this goal? ");
            string points = Console.ReadLine();

            SimpleGoal goal = new SimpleGoal(name, description, points);
            _goals.add(goal);
        }
        else if (goalType == "2")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of your goal? ");
            string description = Console.ReadLine();

            Console.Write("How many points will be associated with this goal? ");
            string points = Console.ReadLine();

            EternalGoal goal = new EternalGoal(name, description, points);
            _goals.add(goal);

        }
        else if (goalType == "3")
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of your goal? ");
            string description = Console.ReadLine();

            Console.Write("How many points will be associated with this goal? ");
            string points = Console.ReadLine();

            Console.Write("How many times does this goal need to be completed for a bonus? ");
            string target = Console.ReadLine();

            Console.Write("How many points will be rewarded as a bonus for completing this goal? ");
            string bonus = Console.ReadLine();

            ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.add(goal);
            
        }
        else
        {
            Console.WriteLine("Try again.");
        }
    }
    public void RecordEvent()
    {
        
    }
    public void SaveGoals()
    {

    }
    public void LoadGoals()
    {

    }
}