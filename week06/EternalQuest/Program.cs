/*
Author: Vegard Amundsen
Last modified: 10.10.2025
Program: Lets the user set goals with points and the user can then follow up these goals and get points for completion and grow in level.

Added functionality: I have made it possible for the user to see what it entered as a goal in one line. I have added bronze, silver, gold and platinum
levels that the user can reach if it reaches a certain amount of points. I have therefore also set a limit on how many points the user can get for
each type of goal.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the EternalQuest Project.");
        GoalManager manager = new GoalManager();
        manager.start();
    }
}