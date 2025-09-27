public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;

    private List<Comment> _comments = new List<Comment>();

    public void AddComments(string name, string text)
    {
        Comment comment = new Comment();
        comment.SetComment(name, text);
        _comments.Add(comment);
    }

    public int CountComments()
    {
        int commentCount = _comments.Count;
        return commentCount;
    }

    public void DisplayVideoContent()
    {
        Console.WriteLine($"{_title} by: {_author} | Length: {_lengthInSeconds} seconds");
        Console.WriteLine($"Comments: ({CountComments()})");

        foreach (Comment comment in _comments)
        {
            comment.DisplayComment();
        }
    }

    public void SetVideoContent(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = length;
    }
}