using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        Journal theJournal = new Journal();
        Entry anEntry = new Entry();
        anEntry.Display();
        PromptGenerator promptGenerator = new PromptGenerator();

        string randomPrompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine("Random Prompt: " + randomPrompt);

    }
}