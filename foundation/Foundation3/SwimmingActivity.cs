public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(string name, string date, int length, int laps) : base(name, date, length)
    {
        _laps = laps;
    }
    public override double Distance()
    {
        return _laps * 50 / 1000 * 0.62;
    }
    public override double Speed()
    {
        double hours = _length / 60;

        return Distance() / hours;
    }
    public override double Pace()
    {
        return _length / Distance();
    }
}