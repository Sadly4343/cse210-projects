using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");

        RunningActivity activity = new RunningActivity("running", "03 Nov 2022", 10, 30);
        activity.GetSummary();
        Console.ReadLine();


    }
}