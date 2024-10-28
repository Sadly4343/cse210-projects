public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, string points) : base(name, description, points)
    {
    }
    public override void RecordEvent()
    {

    }

    public override bool isComplete()
    {
        return false;
    }
    public override string GetStringRepresenation()
    {
        return "";
    }

}