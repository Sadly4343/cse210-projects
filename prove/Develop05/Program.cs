using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        ReflectingActivity activity = new ReflectingActivity(60);

        activity.DisplayStartingMessage();
        activity.Run();
        activity.DisplayEndingMessage();



    }
}