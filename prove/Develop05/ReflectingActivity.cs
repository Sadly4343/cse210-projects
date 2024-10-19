public class ReflectingActivity : Activity
{

    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity(int duration) : base("Reflecting", "This is the reflecting activity", duration)
    {
        _duration = duration;
    }

    public void Run()
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine(randomPrompt);
        Console.WriteLine($"Press Enter when you are ready ");
        string userInput = Console.ReadLine();

        while (userInput == "" && DateTime.Now < endTime)
        {
            string ranQuestion = GetRandomQuestions();
            Console.WriteLine(ranQuestion);
            ShowSpinner(5);
            Console.WriteLine();

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

    public string GetRandomQuestions()
    {
        _questions = new List<string>
        {

        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"

        };
        Random random = new Random();
        int index = random.Next(_questions.Count);

        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(_prompts);
    }
    public void DisplayQuestions()
    {
        Console.WriteLine(_questions);
    }
}
