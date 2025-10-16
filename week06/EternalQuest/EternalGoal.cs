/*
Author: Vegard Amundsen
Last modified: 10.10.2025
Class: Is the derived class that provides what is needed for an Eternal goal with a name and text. A eternal goal can never be completed.
*/

public class EternalGoal : Goal
{
    // records completion of a goal
    public override void RecordGoalEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {GetGoalPoints()} points!\nAnd your reward in heaven.");
    }

    // checks if the goal is complete, it will never be true
    public override bool IsGoalComplete()
    {
        return false;
    }

    // gets the details of the goal so it can be shown on the screen
    public override string GetGoalDetails()
    {
        return $"{GetGoalTitle()} ({GetGoalText()}), {GetGoalPoints()} points";
    }

    // gets a representation of the goal so that it can be saved in a file
    public override string GetGoalRepresentation()
    {
        return $"EternalGoal:{GetGoalTitle()};{GetGoalText()}";
    }
}