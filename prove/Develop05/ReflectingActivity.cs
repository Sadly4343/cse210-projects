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
        return "";
    }

    public string GetRandomQuestions()
    {
        return "";
    }

    public void DisplayPrompt()
    {

    }
    public void DisplayQuestions()
    {

    }
}
