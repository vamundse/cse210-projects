public class Activity
{
    public string StartingMessage(string activity, string description)
    {
        return $"Welcome to the {activity} Activity, this activity will help you\n{description}";
    }

    public string EndingMessage(string activity)
    {
        return $"Great job on the {activity} Activity. I hope this will improve your day!";
    }
}