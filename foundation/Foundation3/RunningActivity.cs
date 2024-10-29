using System.Security.Cryptography.X509Certificates;

public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(string name, string date, int length, double distance) : base(name, date, length)
    {
        _distance = distance;
    }
    public override double Distance()
    {

        return _distance;
    }
    public override double Speed()
    {

        double hours = _length / 60;

        return _distance / hours;
    }
    public override double Pace()
    {
        double hours = _length / 60;
        return hours / _distance * 60;
    }


}