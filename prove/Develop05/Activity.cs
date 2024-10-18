public class Activity
{
    private string _name;
    private string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine($"This activity will {_description}");
        Console.WriteLine();
        Console.WriteLine($"How long, in seconds, would you like your session? ");
        string userInput = Console.ReadLine();
        _duration = int.Parse(userInput);
        Console.WriteLine("Get Ready ...");
        ShowSpinner(5);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Well Done!!!");
        Thread.Sleep(3000);
        Console.WriteLine($"Nice Job, You completed another {_duration} of the {_name} Activity!");

    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }

}