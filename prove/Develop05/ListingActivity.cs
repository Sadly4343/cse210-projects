using System.Diagnostics.Metrics;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity(int duration) : base("Listing", "This is the Listing activity", duration)
    {

    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        Console.WriteLine("List as many responses you can to the following prompt ");
        Console.WriteLine();
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine(randomPrompt);
        Console.WriteLine($"You may begin in ");
        ShowCountDown(5);
        while (DateTime.Now < endTime)
        {
            List<string> responses = GetListFromUser();

            int totalResponses = responses.Count;
            Console.WriteLine($"These are how many responses {totalResponses}");


        }
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
        List<string> userResponse = new List<string>();
        Console.WriteLine("Your reponses below");
        string userLine = Console.ReadLine();
        foreach (var response in userResponse)
        {
            userResponse.Add(userLine);
        }
        return userResponse;

    }
}
