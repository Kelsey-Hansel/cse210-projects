public abstract class Activity
{
    protected DateTime _date;
    protected double _lengthInMinutes;
    protected string _activityType;

    public Activity(DateTime date, double lengthInMinutes, string activityType)
    {
        _date = date;
        _lengthInMinutes = lengthInMinutes;
        _activityType = activityType;
    }

    public abstract float Distance();

    public abstract float Speed();

    public abstract float Pace();
    
    public string GetSummary()
    {
        float distance = Distance();
        float speed = Speed();
        float pace = Pace();

        return $"{_date.ToString("dd MMM yyyy")} {_activityType} ({_lengthInMinutes:F2} min) - Distance {distance:F2} miles, Speed: {speed:F2} mph, Pace: {pace:F2} min per mile";
    }
}

public class Running : Activity
{
    private float _distance;
    
    public Running(DateTime date, double lengthInMinutes, string activityType, float distance) : base(date, lengthInMinutes, activityType)
    {
        _distance = distance;
    }

    public override float Distance()
    {
        return _distance;
    }

    public override float Speed()
    {
        return _distance / (float)_lengthInMinutes * 60;
    }

    public override float Pace()
    {
        return (float)_lengthInMinutes / _distance;
    }
}

public class Cycling : Activity
{
    private float _speed;

    public Cycling(DateTime date, double lengthInMinutes, string activityType, float speed) : base(date, lengthInMinutes, activityType)
    {
        _speed = speed;
    }

    public override float Distance()
    {
        return _speed / 60 * (float)_lengthInMinutes;
    }

    public override float Speed()
    {
        return _speed;
    }

    public override float Pace()
    {
        return 60 / _speed;
    }
}

public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, double lengthInMinutes, string activityType, int laps) : base(date, lengthInMinutes, activityType)
    {
        _laps = laps;
    }

    public override float Distance()
    {
        return _laps * 50 / 1000 * 0.62f;
    }

    public override float Speed()
    {
        return Distance() / (float)_lengthInMinutes * 60;
    }

    public override float Pace()
    {
        return (float)_lengthInMinutes / Distance();
    }
}