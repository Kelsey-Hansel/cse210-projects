using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference = new Reference("2 Nephi", 4, 16);
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        foreach (var line in text.Split(" "))
        {
            _words.Add(new Word(line));
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        Random randomNumber = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            var notHidden = _words.Where(word => !word.IsHidden()).ToList();
            if (numberToHide > 0)
            {
                var wordToHide = notHidden[randomNumber.Next(notHidden.Count)];
                wordToHide.Hide();
            }
        }
    }

    public string GetDisplayText()
    {
        string scriptureReference = _reference.GetDisplayText();
        string scriptureText = "";
        for (int i = 0; i < _words.Count; i++)
        {
            scriptureText = scriptureText + " " + _words[i].GetDisplayText();
        }
        string text = $"{scriptureReference} {scriptureText}";

        return text;
    }

    public bool IsCompletelyHidden()
    {
        bool allHidden = new bool();
        allHidden = _words.All(word => word.IsHidden());
        return allHidden;
    }
}