/*
Author: Vegard Amundsen
Last modified: 10.10.2025
Class: Is the derived class that provides what is needed for a simple goal with a name, text and points.
*/

public class SimpleGoal : Goal
{
    // variable that sets the status of completion
    private bool _isComplete = false;

    // records completion of a goal
    public override void RecordGoalEvent()
    {
        _isComplete = true;

        Console.WriteLine($"Congratulations! You have earned {GetGoalPoints()} points!");
    }

    // checks if the goal is complete
    public override bool IsGoalComplete()
    {
        if (_isComplete == true)
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
        return $"{GetGoalTitle()} ({GetGoalText()}), {GetGoalPoints()} points";
    }

    // gets a representation of the goal so that it can be saved in a file
    public override string GetGoalRepresentation()
    {
        return $"SimpleGoal:{GetGoalTitle()};{GetGoalText()};{GetGoalPoints()};{_isComplete}";
    }

    // setter for completion
    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }
}