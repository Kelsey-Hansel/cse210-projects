using System.Diagnostics.Contracts;

public class Resume
{
    public string _name = "Allison Rose";
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");

        foreach (Job jobDetails in _jobs)
        {
            jobDetails.DisplayJobDetails();
        }
    }
}