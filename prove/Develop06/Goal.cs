public abstract class Goal
{
    protected string _name;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool isComplete();
    public virtual string GetDetailsString()
    {
        return "";
    }
    public abstract string GetStringRepresenation();
}