using System;
using System.Collections.Generic;
//I added an additional input asking who they reminded that day they loved them as a prompt after the entry to the journal so they can record that.

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        myJournal._entries = new List<Entry>();
        while (true)
        {
            Console.WriteLine("Journal");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                Entry entries = new Entry();
                PromptGenerator promptGenerator = new PromptGenerator();
                string randomPrompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(randomPrompt);
                entries._promptText = randomPrompt;
                Console.WriteLine("What would your entry be?");
                entries._entryText = Console.ReadLine();
                Console.WriteLine("Who did you remind today that you love them?");
                entries._remindText = Console.ReadLine();
                entries._date = DateTime.Now.ToString("yyyy-MM-dd");

                myJournal.AddEntry(entries);
            }
            else if (choice == "2")
            {
                myJournal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.WriteLine("What is your file to open? ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);
            }
            else if (choice == "4")
            {
                Console.WriteLine("What is your file to save the journal?");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            }
            else if (choice == "5")
            {
                break;
            }


        }
    }
}