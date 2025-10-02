/*
Author: Vegard André Amundsen
Program: This is the listing activity for the mindfulness program.
*/

public class ListingActivity : Activity
{
    // variables
    private int _count = 0;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    // lets user type answers, adds them to a list and counts them
    private void GetListFromUser()
    {
       // user input
        Console.Write("> ");
        string answer = Console.ReadLine();

        //counts the answer
        _count++;
    }

    private string GetRandomPrompt()
    {
        // adds random prompt and displays it
        Random _randomPromptNumber = new Random();
        int rPN = _randomPromptNumber.Next(_prompts.Count);
        return _prompts[rPN];
    }

    private void DisplayRandomPrompt(string prompt)
    {
        Console.WriteLine($"After the countdown, list as many responses as you can to the following prompt:\n{prompt}");
    }

    // reflection activity
    public void ReflectionExercise()
    {
        // clears the screen before the activity starts
        Console.Clear();

        // sets name and description variables
        SetName("Listing");
        SetDescription("reflect on the good things in your life\nby having you list as many things as you can in a certain area.");

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

        // loops until the session time runs out
        while (DateTime.Now < endTime)
        {
            // gets a prompt and displays it
            string prompt = GetRandomPrompt();
            DisplayRandomPrompt(prompt);
            Countdown(10);

            // a loop that lets the user write as many things a it can while there is still time
            while (DateTime.Now < endTime)
            {
                GetListFromUser();
            }
            Console.Clear();
            // shows the user how many entries it made
            Console.WriteLine($"Fantastic! You listed {_count} things, to the prompt: {prompt}");
        }

        // end message
        EndingMessage(GetName());
        Console.WriteLine();
    }
}