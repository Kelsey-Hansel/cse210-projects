using System;

class Program
{
    static void Main(string[] args)
    {
        DateTime date = new DateTime();
        date = DateTime.Now;

        Running runActivity = new Running(date, 45, "Running", 12.0f);
        Cycling cycleActivity = new Cycling(date, 85, "Cycling", 13.0f);
        Swimming swimActivity = new Swimming(date, 60, "Swimming", 42);

        List<Activity> activities = new List<Activity>();
        activities.Add(runActivity);
        activities.Add(cycleActivity);
        activities.Add(swimActivity);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}