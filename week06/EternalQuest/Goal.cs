/*
Author: Vegard Amundsen
Last modified: 10.10.2025
Class: Is the base class that has the base variables and functions for a goal.
*/

public abstract class Goal
{
    // variables for goal title, text and the amount of points you get on completion
    private string _title;
    private string _text;
    private int _points = 0;

    // abstract functions that are set in the derived classes
    // records completion of a goal
    public abstract void RecordGoalEvent();

    // checks if the goal is complete
    public abstract bool IsGoalComplete();

    // gets the details of the goal so it can be shown on the screen
    public abstract string GetGoalDetails();

    // gets a representation of the goal so that it can be saved in a file
    public abstract string GetGoalRepresentation();

    // checks if the bonus for a checklist goal should be awarded
    public virtual bool BonusAward()
    {
        return false;
    }

    // setters and getters
    public string GetGoalTitle()
    {
        return _title;
    }

    public void SetGoalTitle(string title)
    {
        _title = title;
    }

    public string GetGoalText()
    {
        return _text;
    }

    public void SetGoalText(string text)
    {
        _text = text;
    }

    public int GetGoalPoints()
    {
        return _points;
    }

    public void SetGoalPoints(int points)
    {
        _points = points;
    }

    public virtual int GetGoalBonus()
    {
        return 0;
    }
}