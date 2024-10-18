using System.Diagnostics;

public class BreathingActivity : Activity
{

    public BreathingActivity(int duration) : base("Breathing", "This is the breathing activity", duration)
    {
        _duration = duration;
    }

    public void Run()
    {
        Console.WriteLine("Start breathing out");
        ShowCountDown(_duration);
        Console.
    }

}