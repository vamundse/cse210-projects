/*
Author: Vegard André Amundsen
Program: These are the common elements of the breathing, refleciton and listing activities.
*/

public class Activity
{
    // variables
    private string _name;
    private string _description;
    private int _time;

    public Activity()
    {
        
    }
    
    public Activity(string name, string description, int time)
    {
        _name = name;
        _description = description;
        _time = time;
    }

    // setter and getter for variables

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetTime(int time)
    {
        _time = time;
    }

    public int GetTime()
    {
        return _time;
    }

    // countdown function
    public void Countdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b\b  \b\b\b");
        }
    }

    // spinner function
    public void Spinner(int seconds)
    {
        DateTime pqStartTime = DateTime.Now;
        DateTime pqEndTime = pqStartTime.AddSeconds(seconds);

        List<string> spinner = new List<string> { "|", "/", "-", "\\" };

        while (DateTime.Now < pqEndTime)
        {
            foreach (string s in spinner)
            {
                Console.Write(s);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
        }
    }

    // start message function
    public void StartingMessage(string activity, string description)
    {
        Console.WriteLine($"Welcome to the {activity} Activity.\n\nThis activity will help you {description}");
    }

    // end message function
    public void EndingMessage(string activity)
    {
       Console.WriteLine($"Great job on the {activity} Activity. I hope this will improve your day!");
    }
}