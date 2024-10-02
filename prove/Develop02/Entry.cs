public class Entry
{
    public string _date;
    public string _promptText;

    public string _remindText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"Your entry is {_date} {_promptText} {_entryText} and who did I remind that I love them, {_remindText}");
    }
}