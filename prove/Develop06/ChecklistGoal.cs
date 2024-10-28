public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int bonus, int target) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;


    }
    public override void RecordEvent()
    {
        _amountCompleted++;
        if (_amountCompleted == _target)
        {
            _points += _bonus;
        }
    }

    public override bool IsComplete()
    {
        if (_amountCompleted != _target)
        {
            return true;
        }
        else
            return false;
    }
    public override string GetDetailsString()
    {
        if (_amountCompleted == _target)
        { return $"[X] {_name} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}"; }
        else
        {
            return $"[ ] {_name} ({_description}) -- Currently Completed: {_amountCompleted}/{_target}";
        }

    }
    public override string GetStringRepresenation()
    {
        return $"ChecklistGoal, {_name}, {_description}, {_points},{_bonus},{_amountCompleted},{_target}";
    }
}