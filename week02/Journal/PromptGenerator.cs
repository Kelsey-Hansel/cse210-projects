using System.Net.NetworkInformation;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>() {"What is one blessing you noticed today?", "What was something new I learned today?", "What is one thing that made me laugh?", "Who was someone that I enjoyed seeing today?", "What is one thing from today that I could do better tomorrow?"};
    

    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, _prompts.Count);
        string randomPrompt = _prompts[number];
        return randomPrompt;
    }
}