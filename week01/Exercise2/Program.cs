using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage: ");
        string percentageFromUser = Console.ReadLine();
        string grade = "";
        string pm = "";
        int percentage = int.Parse(percentageFromUser);
        int lastNumber = percentage % 10;

        if (percentage >= 90)
        {
            grade = "A";
            if (lastNumber < 3)
            {
                pm = "-";
            }
        }
        else if (percentage >= 80)
        {
            grade = "B";
            if (lastNumber >= 7)
            {
                pm = "+";
            }
            else if (lastNumber < 3)
            {
                pm = "-";
            }
        }
        else if (percentage >= 70)
        {
            grade = "C";
            if (lastNumber >= 7)
            {
                pm = "+";
            }
            else if (lastNumber < 3)
            {
                pm = "-";
            }
        }
        else if (percentage >= 60)
        {
            grade = "D";
            if (lastNumber >= 7)
            {
                pm = "+";
            }
            else if (lastNumber < 3)
            {
                pm = "-";
            }
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade: {grade}{pm}");

    }
}