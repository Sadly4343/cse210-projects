using System;


class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();

        string randomPrompt = promptGenerator.GetRandomPrompt();

        Console.WriteLine(randomPrompt);




        Entry entries = new Entry();
        Console.WriteLine("What would your entry be?");
        entries._entryText = Console.ReadLine();


    }
}