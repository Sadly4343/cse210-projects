
public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        _prompts = new List<string>
        {
            "What did you learn today?",
            "What made you smile today?",
            "What are you grateful for today?",
            "What was the highlight of your day?",
            "What did you do for yourself today?"
        };
        Random random = new Random();
        int index = random.Next(_prompts.Count);

        return _prompts[index];
    }
}
