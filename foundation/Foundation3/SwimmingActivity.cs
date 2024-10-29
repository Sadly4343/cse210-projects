public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity(string name, string date, int length, int laps) : base(name, date, length)
    {
        _laps = laps;
    }
    public override int Distance()
    {
        return 3;
    }
    public override int Speed()
    {
        return 3;
    }
    public override int Pace()
    {
        return 60 / Speed();
    }
}