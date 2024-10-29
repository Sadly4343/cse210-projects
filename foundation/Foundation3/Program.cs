using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        List<Activity> activities = new List<Activity>();


        RunningActivity activity = new RunningActivity("running", "03 Nov 2022", 30, 3);

        activities.Add(activity);
        SwimmingActivity activity1 = new SwimmingActivity("running", "03 Nov 2022", 40, 100);


        activities.Add(activity1);
        CyclingActivity activity2 = new CyclingActivity("running", "03 Nov 2022", 40, 20);


        activities.Add(activity2);

        foreach (Activity activitys in activities)
        {
            activitys.GetSummary();
        }





    }
}