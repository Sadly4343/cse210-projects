public class CyclingActivity : Activity
{
    private int _speed;

    public CyclingActivity(string name, string date, int length, int speed) : base(name, date, length)
    {
        _speed = speed;
    }
    public override int Distance()
    {
        return _speed * _length;
    }
    public override int Speed()
    {
        return Distance() * _length;
    }
    public override int Pace()
    {
        return _length / Distance();
    }




}