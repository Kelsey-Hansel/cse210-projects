using System;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
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
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            Console.WriteLine($"{i + 1}. {goal.GetName()}");
        }
    }
    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            Console.WriteLine($"{i + 1}. {goal.GetDetailsString()}");
        }

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
            _goals.Add(goal);
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
            _goals.Add(goal);

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
            string targetText = Console.ReadLine();
            int target = int.Parse(targetText);

            Console.Write("How many points will be rewarded as a bonus for completing this goal? ");
            string bonusText = Console.ReadLine();
            int bonus = int.Parse(bonusText);

            ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus, 0);
            _goals.Add(goal);

        }
        else
        {
            Console.WriteLine("Try again.");
        }
    }
    public void RecordEvent()
    {
        ListGoalNames();
        Console.Write("Which goal did you accomplish? ");
        string goalChoice = Console.ReadLine();
        int goalIndex = int.Parse(goalChoice) - 1;
        Goal goal = _goals[goalIndex];
        goal.RecordEvent();
        bool isComplete = goal.IsComplete();
        if (isComplete == true)
        {
            int points = int.Parse(goal.GetPoints());
            _score += points;
            if (goal is ChecklistGoal)
            {
                ChecklistGoal checklistGoal = (ChecklistGoal)goal;
                if (checklistGoal.IsComplete())
                {
                    Console.WriteLine($"Congratulations! You have earned {points} points!");
                    _score += checklistGoal.GetBonus();
                    Console.WriteLine($"Congratulations! You have earned a bonus of {checklistGoal.GetBonus()} points!");
                }
            }
            else
            {
                Console.WriteLine($"Congratulations! You have earned {points} points!");
            }
        }
        else if (goal is EternalGoal)
        {
            int points = int.Parse(goal.GetPoints());
            _score += points;
            Console.WriteLine($"Congratulations! You have earned {points} points!");
        }
        else if (goal is ChecklistGoal)
        {
            ChecklistGoal checklistGoal = (ChecklistGoal)goal;
            int points = int.Parse(checklistGoal.GetPoints());
            _score += points;
            Console.WriteLine($"Congratulations! You have earned {points} points!");
        }
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        _goals.Clear();
        char[] separators = {'|', ':'};

        foreach (string line in lines)
        {
            string[] parts = line.Split(separators);

            string goalType = parts[0];
            if (goalType == "SimpleGoal")
            {
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];

                SimpleGoal goal = new SimpleGoal(name, description, points);
                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];

                EternalGoal goal = new EternalGoal(name, description, points);
                _goals.Add(goal);
            }
            else if (goalType == "ChecklistGoal")
            {
                string name = parts[1];
                string description = parts[2];
                string points = parts[3];
                int bonus = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int amountCompleted = int.Parse(parts[6]);

                ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus, amountCompleted);
                _goals.Add(goal);
            }
            else
            {
                _score = int.Parse(line);
            }
        }
    }
}