using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");
        Console.WriteLine();

        List<Activity> activities = new List<Activity>();

        RunningActivity running = new RunningActivity("03 Nov 2022", 30, "Running", 4.5);
        CyclingActivity cycling = new CyclingActivity("12 Oct 2023", 20, "Cycling", 20);
        SwimmingActivity swimming = new SwimmingActivity("24 Jul 2025", 15, "Swimming", 9);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}