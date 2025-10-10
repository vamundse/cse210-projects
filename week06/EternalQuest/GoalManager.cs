/*
Author: Vegard Amundsen
Last modified: 10.10.2025
Class: Takes care of the functionality of the program like the menu system, saving and loading files, displaying goals and making new goals.
*/

public class GoalManager
{
    // List where the goals get added
    private List<Goal> _goals = new List<Goal>();

    //array with the reward levels
    private string[] _awards = { "Bronze", "Silver", "Gold", "Platinum" };

    // keps the users score
    private int _score = 0;

    // constructor
    public GoalManager()
    {

    }

    // the menu system
    public void start()
    {
        int menuChoice = 0;
        while (menuChoice != 6)
        {
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Create as new goal");
            Console.WriteLine("2. Show all of the goals you have set");
            Console.WriteLine("3. Save your goals in a new list");
            Console.WriteLine("4. Load a list of goals");
            Console.WriteLine("5. Mark goal as completed");
            Console.WriteLine("6. Quit the program");
            Console.Write("What do you want to do (1-6)? ");
            menuChoice = int.Parse(Console.ReadLine());

            while (menuChoice < 1 || menuChoice > 6)
            {
                Console.Write("You need to type a number between 1-6: ");
                menuChoice = int.Parse(Console.ReadLine());
            }

            if (menuChoice == 1)
            {
                CreateGoal();
            }
            else if (menuChoice == 2)
            {
                ListGoalDetails();
            }
            else if (menuChoice == 3)
            {
                SaveGoals();
            }
            else if (menuChoice == 4)
            {
                LoadGoals();
            }
            else if (menuChoice == 5)
            {
                RecordGoalEvent();
            }
            else if (menuChoice == 6)
            {
                Console.WriteLine();
                Console.WriteLine("Thank you for today and good luck with your goals.");
            }
        }
    }

    // function thtat displays the player score and level
    public void DisplayPlayerScore()
    {
        Console.WriteLine($"You currently have a score of {_score} points.");
        DisplayPlayerLevel();
        Console.WriteLine();
    }

    // function that displays pleyer level
    private void DisplayPlayerLevel()
    {
        if (_score >= 4000)
        {
            Console.WriteLine($"You are on {_awards[3]} level!");
        }
        else if (_score >= 3000)
        {
            Console.WriteLine($"You are on {_awards[2]} level!");
        }
        else if (_score >= 2000)
        {
            Console.WriteLine($"You are on {_awards[1]} level!");
        }
        else if (_score >= 1000)
        {
            Console.WriteLine($"You are on {_awards[0]} level!");
        }
        else
        {
            Console.WriteLine("You do not have enough point to reach a medal level yet.");
        }
    }

    // function that lists the goals the user has entered into the program
    public void ListGoalDetails()
    {
        Console.Clear();
        DisplayPlayerScore();
        Console.WriteLine("Your goals:");
        int count = 0;
        string complete = " ";
        foreach (Goal goal in _goals)
        {
            if (goal.IsGoalComplete() == true)
            {
                complete = "X";
            }
            else
            {
                complete = " ";
            }
            count++;
            Console.WriteLine($"{count}. [{complete}] {goal.GetGoalDetails()}");
        }
        Console.WriteLine();
    }

    // function that creates a goal with user input
    public void CreateGoal()
    {
        Console.Clear();
        Console.WriteLine("What type of goal do you wish to set?");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");

        int goalChoice;
        do
        {
            Console.Write("Please choose a number between 1 and 3: ");
            goalChoice = int.Parse(Console.ReadLine());
        } while (goalChoice < 1 || goalChoice > 3);

        Console.Clear();

        if (goalChoice == 1)
        {
            SimpleGoal simple = new SimpleGoal();
            Console.Write("What is the title of your goal? ");
            simple.SetGoalTitle(Console.ReadLine());
            Console.Write("What is the specific goal? ");
            simple.SetGoalText(Console.ReadLine());
            int points;
            do
            {
                Console.Write("How many points would you like to award yourself for this goal (max 500)? ");
                points = int.Parse(Console.ReadLine());
                simple.SetGoalPoints(points);
            } while (points > 500);
            Console.WriteLine();
            Console.WriteLine("You have entered the goal: ");
            Console.WriteLine($"{simple.GetGoalDetails()}");
            _goals.Add(simple);
            Console.WriteLine();
        }

        else if (goalChoice == 2)
        {
            EternalGoal eternal = new EternalGoal();
            Console.Write("What is the title of your goal? ");
            eternal.SetGoalTitle(Console.ReadLine());
            Console.Write("What is the specific goal? ");
            eternal.SetGoalText(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("You have entered the goal: ");
            Console.WriteLine($"{eternal.GetGoalDetails()}");
            _goals.Add(eternal);
            Console.WriteLine();
        }

        else if (goalChoice == 3)
        {
            ChecklistGoal checklist = new ChecklistGoal();
            Console.Write("What is the title of your goal? ");
            checklist.SetGoalTitle(Console.ReadLine());
            Console.Write("What is the specific goal? ");
            checklist.SetGoalText(Console.ReadLine());
            Console.Write("How many times do you have to repeat this goal before it is complete? ");
            checklist.SetGoalRepetitions(int.Parse(Console.ReadLine()));
            int points;
            do
            {
                Console.Write("How many points would you like to award yourself every time you complete a repetition (max 50?) ");
                points = int.Parse(Console.ReadLine());
                checklist.SetGoalPoints(points);
            } while (points > 50);
            int bonus;
            do
            {
                Console.Write("What bonus will you grant yourself when finish the goal completely (max 500)? ");
                bonus = int.Parse(Console.ReadLine());
                checklist.SetGoalBonus(bonus);
            } while (bonus > 500);
            Console.WriteLine();
            Console.WriteLine("You have entered the goal: ");
            Console.WriteLine($"{checklist.GetGoalDetails()}");
            _goals.Add(checklist);
            Console.WriteLine();
        }
    }

    // function that records when a user has completed a goal
    public void RecordGoalEvent()
    {
        Console.Clear();
        Console.WriteLine("Your goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetGoalTitle()}");
        }
        Console.Write("Which goal have you completed? ");
        int choice = int.Parse(Console.ReadLine());
        while (choice < 1 || choice > _goals.Count)
        {
            Console.WriteLine("Choose a number on the screen!");
        }
        Console.WriteLine();
        _goals[choice - 1].RecordGoalEvent();
        _score += _goals[choice - 1].GetGoalPoints();
        if (_goals[choice - 1].BonusAward() == true)
        {
            _score += _goals[choice - 1].GetGoalBonus();
        }
        Console.WriteLine($"You now have a score of {_score} points.");
        DisplayPlayerLevel();
        Console.WriteLine();
    }

    // function that saves the goals and score to a file
    public void SaveGoals()
    {
        Console.Clear();
        string filename = "myFile.txt";
        Console.Write("Please choose a filename to save your list of goals to a file (filename.txt): ");
        filename = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetGoalRepresentation());
            }
        }
        Console.WriteLine($"You have saved your list of goals to {filename}");
        Console.WriteLine();
    }

    // function that loads the score and goals from a file
    public void LoadGoals()
    {
        Console.Clear();
        string filename = "myFile.txt";
        Console.Write("Please choose a filename to load your list of goals from a file (filename.txt): ");
        filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] typePlusData = lines[i].Split(":");
            string goalType = typePlusData[0];
            string[] parts = typePlusData[1].Split(";");

            if (goalType == "SimpleGoal")
            {
                SimpleGoal simple = new SimpleGoal();
                simple.SetGoalTitle(parts[0]);
                simple.SetGoalText(parts[1]);
                simple.SetGoalPoints(int.Parse(parts[2]));
                simple.SetIsComplete(bool.Parse(parts[3]));
                _goals.Add(simple);
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal eternal = new EternalGoal();
                eternal.SetGoalTitle(parts[0]);
                eternal.SetGoalText(parts[1]);
                _goals.Add(eternal);
            }
            else if (goalType == "ChecklistGoal")
            {
                ChecklistGoal checklist = new ChecklistGoal();
                checklist.SetGoalTitle(parts[0]);
                checklist.SetGoalText(parts[1]);
                checklist.SetGoalPoints(int.Parse(parts[2]));
                checklist.SetGoalBonus(int.Parse(parts[3]));
                checklist.SetGoalRepetitions(int.Parse(parts[4]));
                checklist.SetCompleteGoalRepetitions(int.Parse(parts[5]));
                _goals.Add(checklist);
            }
        }
        Console.WriteLine($"Your list of goals has been loaded from {filename}");
        Console.WriteLine();
    }
}