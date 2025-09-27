public class Comment
{
    private string _name;
    private string _text;

    public void DisplayComment()
    {
        Console.WriteLine(_name);
        Console.WriteLine($"    {_text}");
        Console.WriteLine();
    }

    public void SetComment(string name, string text)
    {
        _name = name;
        _text = text;
    }
}