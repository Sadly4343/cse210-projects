using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System.Numerics;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity(int duration) : base("Listing", "This is the Listing activity", duration)
    {
        _count = 0;
    }

    public void Run()
    {
        Console.WriteLine("List as many responses you can to the following prompt ");
        Console.WriteLine();
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine(randomPrompt);
        Console.WriteLine($"You may begin in ");
        ShowCountDown(5);
        GetListFromUser();
        Console.WriteLine(_count);
    }

    public string GetRandomPrompt()
    {
        _prompts = new List<string>
        {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."

        };
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        List<string> userResponses = new List<string>();
        while (DateTime.Now < endTime)
        {
            string userReplys = Console.ReadLine();
            userResponses.Add(userReplys);
            _count++;
        }
        return userResponses;
    }
}
