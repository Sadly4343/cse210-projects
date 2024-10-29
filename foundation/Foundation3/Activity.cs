public abstract class Activity
{
    protected string _name;

    protected string _date;

    protected double _length;

    public Activity(string name, string date, int length)
    {
        _name = name;
        _date = date;
        _length = length;
    }

    public virtual double Distance()
    {
        return 0;
    }
    public virtual double Speed()
    {
        return 0;
    }
    public virtual double Pace()
    {
        return 0;
    }

    public virtual void GetSummary()
    {
        Console.WriteLine($"{_date} {_name} ({_length} min)- Distance {Distance():F2} miles, Speed {Speed():F2} mph, Pace: {Pace():F2} min per mile");
    }
}