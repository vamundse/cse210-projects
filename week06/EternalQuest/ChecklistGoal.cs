/*
Author: Vegard Amundsen
Last modified: 10.10.2025
Class: Is the derived class that provides what is needed for a Checklist goal with a name and text, points, bonuses and goal repetition.
The goal is only completed once the user has done the amount of repetitions it entered.
*/

public class ChecklistGoal : Goal
{
    private int _repetitions = 0;
    private int _completeRepetitions = 0;
    private int _bonus = 0;

    // records completion of a goal
    public override void RecordGoalEvent()
    {
        _completeRepetitions++;
        Console.WriteLine($"Congratulations! You have earned {GetGoalPoints()}!");
        if (IsGoalComplete() == true && _repetitions == _completeRepetitions)
        {
            Console.WriteLine($"You have completed the entire goal and the bonus of {_bonus} points has been added.");
        }
    }

    // checks if the goal is complete
    public override bool IsGoalComplete()
    {
        if (_repetitions <= _completeRepetitions)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // gets the details of the goal so it can be shown on the screen
    public override string GetGoalDetails()
    {
        return $"{GetGoalTitle()} ({GetGoalText()}), {GetGoalPoints()} points per repetition, {GetGoalBonus()} bonus on completion -- Currently completed: {_completeRepetitions}/{_repetitions}";
    }

    // gets a representation of the goal so that it can be saved in a file
    public override string GetGoalRepresentation()
    {
        return $"ChecklistGoal:{GetGoalTitle()};{GetGoalText()};{GetGoalPoints()};{GetGoalBonus()};{_repetitions};{_completeRepetitions}";
    }

    // checks if the bonus for a checklist goal should be awarded
    public override bool BonusAward()
    {
        if (_repetitions == _completeRepetitions)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // setters and getters
    public int GetGoalRepetitions()
    {
        return _repetitions;
    }

    public void SetGoalRepetitions(int repetitions)
    {
        _repetitions = repetitions;
    }

    public int GetCompleteGoalRepetitions()
    {
        return _completeRepetitions;
    }

    public void SetCompleteGoalRepetitions(int completeRepetitions)
    {
        _completeRepetitions = completeRepetitions;
    }

    public override int GetGoalBonus()
    {
        return _bonus;
    }

    public void SetGoalBonus(int bonus)
    {
        _bonus = bonus;
    }
}