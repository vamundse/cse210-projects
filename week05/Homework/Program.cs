using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Console.WriteLine();

        Assignment assignment1 = new Assignment("John Stones", "Plumbing");
        Console.WriteLine(assignment1.GetSummary());

        Console.WriteLine();

        MathAssignment assignment2 = new MathAssignment("Rose Blunder", "Multiplication", "Section 8", "Problems 2-5");
        Console.WriteLine(assignment2.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment assignment3 = new WritingAssignment("Corey Long", "World War II", "The human disaster");
        Console.WriteLine(assignment3.GetWritingInformation());
    }
}