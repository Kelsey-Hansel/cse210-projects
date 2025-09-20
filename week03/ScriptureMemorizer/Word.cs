public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        Show();
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        string displayText;
        if (_isHidden == true)
        {
            string newText = "";
            for (int i = 0; i < _text.Length; i++)
            {
                newText += "_";
            }
            return displayText = _text.Replace(_text, newText);
        }
        else
        {
            return displayText = _text;
        }
    }
}