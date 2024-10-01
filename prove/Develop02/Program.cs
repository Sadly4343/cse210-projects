using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();

        string randomPrompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine("Random Prompt: " + randomPrompt);

    }
}