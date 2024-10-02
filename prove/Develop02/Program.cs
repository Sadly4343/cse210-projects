using System;


class Program
{
    static void Main(string[] args)
    {
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

                PromptGenerator promptGenerator = new PromptGenerator();
                string randomPrompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(randomPrompt);


                Entry entries = new Entry();
                Console.WriteLine("What would your entry be?");
                entries._entryText = Console.ReadLine();
                // Set the date
                entries._date = DateTime.Now.ToString("yyyy-MM-dd");

                // Display the entry
                entries.Display();
            }
            else if (choice == "2")
            {

            }
            else if (choice == "3")
            {

            }
            else if (choice == "4")
            {

            }
            else if (choice == "5")
            {
                break;
            }


        }
    }
}