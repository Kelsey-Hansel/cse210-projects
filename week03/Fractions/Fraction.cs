public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public void GetTop()
    {
        Console.Write("Enter the numerator: ");
        string userNumber = Console.ReadLine();
        int top = int.Parse(userNumber);

        SetTop(top);
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public void GetBottom()
    {
        Console.Write("Enter the denominator: ");
        string userNumber = Console.ReadLine();
        int bottom = int.Parse(userNumber);

        SetTop(bottom);
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }

    public double GetDecimalValue()
    {
        double decimalValue = (double)_top / _bottom;
        return decimalValue;
    }
}