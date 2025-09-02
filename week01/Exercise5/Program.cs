using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayResult();
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromtUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter you favorite number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }

    static int SquareNumber()
    {
        int num = PromptUserNumber();
        int squared = num * num;
        return squared;
    }

    static void DisplayResult()
    {
        DisplayWelcome();
        string name = PromtUserName();
        int squared = SquareNumber();
        Console.WriteLine($"{name}, the square of your number is {squared}.");
    }
}