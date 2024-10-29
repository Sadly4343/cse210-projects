public abstract class Activity
{
    protected string _name;

    protected string _date;

    protected int _length;

    public Activity(string name, string date, int length)
    {
        _name = name;
        _date = date;
        _length = length;
    }

    public virtual int Distance()
    {
        return 0;
    }
    public virtual int Speed()
    {
        return 0;
    }
    public virtual int Pace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{_date} {_name} {_length} {Distance()} {Speed()} {Pace()}";
    }
}