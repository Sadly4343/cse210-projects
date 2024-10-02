public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"You entry is {_date} {_promptText} {_entryText}");
    }
}