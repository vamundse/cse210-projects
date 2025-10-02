/*
Author: Vegard André Amundsen
Program: This is the reflection activity for the mindfulness program.
*/

public class ReflectionActivity : Activity
{
    // variables
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    private string GetRandomPrompt()
    {
        Random _randomPromptNumber = new Random();
        int rPN = _randomPromptNumber.Next(_prompts.Count);
        string prompt = _prompts[rPN];
        return prompt;
    }

    private void DisplayRandomPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine(GetRandomPrompt());
        Console.WriteLine();
    }

    private string GetRandomQuestion()
    {
        Random _randomQuestionNumber = new Random();
        List<int> usedQuestions = new List<int>();

        // makes the loop continues as long as the question already has been asked and there are questions left to ask
        int rQN;
        do
        {
            rQN = _randomQuestionNumber.Next(_questions.Count);
        } while (usedQuestions.Contains(rQN) && usedQuestions.Count < _questions.Count);

        // adds the question asked to used list
        usedQuestions.Add(rQN);

        //returns the question string
        return _questions[rQN];
    }

    private void DisplayRandomQuestions()
    {
        string question = GetRandomQuestion();
        Console.WriteLine(question);
        Spinner(10);
    }

    // reflection exercise
    public void ReflectionExercise()
    {
        // clears the screen before the activity starts
        Console.Clear();

        // sets name and description variables
        SetName("Reflection");
        SetDescription("reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.");

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

        // gets the session time and sets the end time
        Console.Clear();

        // loop to end the activity after the time set
        while (DateTime.Now < endTime)
        {
            // get a random index for the prompt
            GetRandomPrompt();

            // instructions
            DisplayRandomPrompt();

            // makes the user press enter to continue
            Console.WriteLine("When you have something in mind, press enter to continue.");
            string answer = Console.ReadLine();

            // continues the program on enter press
            if (string.IsNullOrWhiteSpace(answer))
            {
                Console.Clear();

                // instructions
                Console.WriteLine("Ponder these follow up questions.");
                Spinner(5);

                // displays questions until time runs out
                while (DateTime.Now < endTime)
                {
                    DisplayRandomQuestions();
                }
            }
        }
        Console.Clear();
    }
}