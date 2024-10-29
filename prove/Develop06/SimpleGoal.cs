public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string description, int points, bool complete) : base(name, description, points)
    {
        _isComplete = false;
    }
    public override void RecordEvent()
    {
        _isComplete = true;

    }

    public override bool IsComplete()
    {
        return true;
    }
    public override string GetStringRepresenation()
    {
        return $"SimpleGoal, {_name}, {_description}, {_points},{_isComplete}";
    }

}