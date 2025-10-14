public abstract class Goal
{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal()
    {
        
    }

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }

    public abstract string GetPoints();

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public virtual string GetDetailsString()
    {
        string mark;
        bool isComplete = IsComplete();
        if (isComplete == true)
        {
            mark = "X";
        }
        else
        {
            mark = " ";
        }
        return $"[{mark}] {_shortName} ({_description})";
    }

    public abstract string GetStringRepresentation();
}

public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override string GetPoints()
    {
        return _points;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"SimpleGoal:{_shortName}|{_description}|{_points}|{_isComplete}";
    }
}

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {

    }

    public override string GetPoints()
    {
        return _points;
    }

    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal:{_shortName}|{_description}|{_points}";
    }
}

public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target = 0;
    private int _bonus = 0;

    public ChecklistGoal(string name, string description, string points, int target, int bonus, int amountCompleted) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override string GetPoints()
    {
        return _points;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public override void RecordEvent()
    {
        if (_amountCompleted < _target)
        {
            _amountCompleted += 1;
        }
    }

    public override bool IsComplete()
    {
        bool isComplete = (_amountCompleted == _target);
        return isComplete;
    }

    public override string GetDetailsString()
    {
        string mark;
        bool isComplete = IsComplete();
        if (isComplete == true)
        {
            mark = "X";
        }
        else
        {
            mark = " ";
        }
        return $"[{mark}] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName}|{_description}|{_points}|{_bonus}|{_target}|{_amountCompleted}";
    }
}