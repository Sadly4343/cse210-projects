public class RunningActivity : Activity
{
    private int _distance;

    public RunningActivity(string name, string date, int length, int distance) : base(name, date, length)
    {
        _distance = distance;
    }
    public override int Distance()
    {
        return _distance;
    }
    public override int Speed()
    {
        return Distance() / _length;
    }
    public override int Pace()
    {
        return 60 / Speed();
    }
    public override string GetSummary()
    {
        return $"{_date} {_name} {_length} {Distance()} {Speed()} {Pace()}";
    }


}