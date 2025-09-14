/*
Program function: Produces a random prompt for a user.

Author: Vegard André Amundsen

Last modified: 12.10.2025
*/

public class PromptGenerator
{
    // Initializes the list of prompts for the generator
    public List<string> _prompts = new List<string>();
    public List<string> _weirdPrompts = new List<string>();

    // Adds prompts to the list of the generator
    public PromptGenerator()
    {
        _prompts.Add("Who did you interact with today?");
        _prompts.Add("What did you eat for Dinner?");
        _prompts.Add("What was your favorite activity?");
        _prompts.Add("Where did you go?");
        _prompts.Add("How was your day at school?");
        _prompts.Add("What was your favorite experience?");
        _weirdPrompts.Add("If your day was a movie genre, what would it be and why?");
        _weirdPrompts.Add("What was the strangest thing you saw or heard today?");
        _weirdPrompts.Add("If you could give your day a theme song, what would it be?");
        _weirdPrompts.Add("Did you have a moment today that felt like déjà vu?");
        _weirdPrompts.Add("If you had to describe your day using only animal noises, which would you choose?");
        _weirdPrompts.Add("What is the weirdest thought you had today?");
    }

    // Creates a new random number generator
    public Random randumNumber = new Random();

    // Gets a random prompt from the list _prompts
    public string GetRandomPrompt()
    {
        int indexNumber = randumNumber.Next(_prompts.Count);
        return _prompts[indexNumber];
    }

    public string GetRandomWeirdPrompt()
    {
        int indexNumber = randumNumber.Next(_weirdPrompts.Count);
        return _weirdPrompts[indexNumber];
    }
}