public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int amountCompleted, int bonus, int target) : base(name, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;

    }
    public override void RecordEvent()
    {

    }

    public override bool isComplete()
    {
        return false;
    }
    public override string GetDetailsString()
    {
        return "";
    }
    public override string GetStringRepresenation()
    {
        return "";
    }
}