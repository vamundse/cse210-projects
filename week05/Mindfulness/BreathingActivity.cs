/*
Author: Vegard André Amundsen
Program: This is the breathing activity for the mindfulness program.
*/

public class BreathingActivity : Activity
{
    // breathing activity
    public void BreathingExcercise()
    {
        // clears the screen before the activity starts
        Console.Clear();

        // sets name and description variables
        SetName("Breathing");
        SetDescription("by walking you through breathing in and out slowly.\nClear your mind and focus on your breathing.");

        // start message
        StartingMessage(GetName(), GetDescription());
        Console.WriteLine();

        // sets time variable
        Console.Write("How many seconds would you like todays session to last? ");
        SetTime(int.Parse(Console.ReadLine()));

        // sets the end time
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetTime());

        // instructions
        Console.Write($"Get ready ");
        Spinner(5);

        Console.Clear();

        // breathing counter
        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            Countdown(8);
            Console.Clear();

            Console.WriteLine("Breathe Out..");
            Countdown(8);
            Console.Clear();
        }
        // end message
        EndingMessage(GetName());
        Console.WriteLine();
    }
}