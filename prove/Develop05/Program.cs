using System;
// Added the ability to only have prompts selected once they have been chosen not the same over and over.
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflecting");
            Console.WriteLine("3. Listing");
            Console.WriteLine("4. Quit");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity(20);

                activity.DisplayStartingMessage();
                activity.Run();
                activity.DisplayEndingMessage();


            }
            else if (choice == "2")
            {
                ReflectingActivity activity = new ReflectingActivity(20);

                activity.DisplayStartingMessage();
                activity.Run();
                activity.DisplayEndingMessage();
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity(20);

                activity.DisplayStartingMessage();
                activity.Run();
                activity.DisplayEndingMessage();
            }
            else if (choice == "4")
            {
                break;
            }
        }
    }
}


