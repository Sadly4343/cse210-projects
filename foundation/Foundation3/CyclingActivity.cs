public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(string name, string date, int length, double speed) : base(name, date, length)
    {
        _speed = speed;
    }
    public override double Distance()
    {
        double hours = _length / 60;
        return Speed() * hours;
    }
    public override double Speed()
    {
        return _speed;
    }
    public override double Pace()
    {
        return _length / Distance();
    }




}