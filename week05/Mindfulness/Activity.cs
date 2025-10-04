public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        string seconds = Console.ReadLine();
        _duration = int.Parse(seconds);
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(7);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!!");
        ShowSpinner(7);
        Console.WriteLine();
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("\\");
        spinner.Add("-");
        spinner.Add("/");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string spinnerPart = spinner[i];
            Console.Write(spinnerPart);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;

            if (i >= 4)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        int seconds = _duration;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write($"Breathe in...");
            ShowCountDown(3);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            ShowCountDown(5);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}

public class ListingActivity : Activity
{
    private int _count = 0;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        int seconds = _duration;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        List<string> userList = new List<string>();

        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in...");
        ShowCountDown(3);
        Console.WriteLine();

        while (DateTime.Now < endTime)
        {
            userList = GetListFromUser(userList);
        }

        _count = userList.Count;

        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Count);

        string randomPrompt = _prompts[randomIndex];
        Console.WriteLine($"-- {randomPrompt} --");
    }

    public List<string> GetListFromUser(List<string> userList)
    {
        Console.Write("> ");
        string response = Console.ReadLine();
        userList.Add(response);
        return userList;
    }
}

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity(string name, string description) : base(name, description)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();

        int seconds = _duration;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string enter = Console.ReadLine();

        if (enter == "")
        {
            while (DateTime.Now < endTime)
            {
                DisplayQuestions();
            }

            DisplayEndingMessage();
        }
        else
        {
            Console.WriteLine("Error. Try again.");
        }
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _questions.Count);

        string randomQuestion = _questions[randomIndex];
        return randomQuestion;
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(0, _prompts.Count);

        string randomPrompt = _prompts[randomIndex];
        return randomPrompt;
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"-- {GetRandomPrompt()} --");
        Console.WriteLine();
    }

    public void DisplayQuestions()
    {
        Console.Write($"> {GetRandomQuestion()} ");
        ShowSpinner(4);
        Console.WriteLine();
    }
}