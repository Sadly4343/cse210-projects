using System.Diagnostics;

public class BreathingActivity : Activity
{

    public BreathingActivity(int duration) : base("Breathing", "This is the breathing activity", duration)
    {
        _duration = duration;
    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe In ");
            ShowCountDown(4);
            Console.WriteLine("Breathe Out ");
            ShowCountDown(4);

        }
    }

}