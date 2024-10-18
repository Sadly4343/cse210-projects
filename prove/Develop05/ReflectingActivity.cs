public class ReflectingActivity : Activity
{

    private List<string> _prompts;
    private List<string> _questions;
    public ReflectingActivity(int duration) : base("Reflecting", "This is the reflecting activity", duration)
    {

    }

    public void Run()
    {
        
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

        return _prompts[index];
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
