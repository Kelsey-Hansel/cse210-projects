using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        for (int i = 0; i < _entries.Count; i++)
        {
            _entries[i].Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            Entry singleEntry = new Entry();

            for (int i = 0; i < _entries.Count; i++)
            {
                singleEntry = _entries[i];
                string date = singleEntry._date;
                string prompt = singleEntry._promptText;
                string entry = singleEntry._entryText;
                outputFile.WriteLine($"{date} | {prompt} | {entry}");
            }
        }
    }
    public void LoadFromFile(string file)
    {
        string[] savedEntries = System.IO.File.ReadAllLines(file);

        foreach (string savedEntry in savedEntries)
        {
            string[] parts = savedEntry.Split("|");

            string date = parts[0];
            string prompt = parts[1];
            string entry = parts[2];

            Console.WriteLine($"Date: {date} - Prompt: {prompt}");
            Console.WriteLine(entry);
        }
    }
}