using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.Write("What activity do you want to do today? ");
        int choice = int.Parse(Console.ReadLine());

        Console.Clear();

        if (choice == 1)
        {
            // breathing activity initialization
            BreathingActivity session1 = new BreathingActivity();

            // activity starting message
            Console.WriteLine(session1.StartingMessage(session1.GetName(), session1.GetDescription()));
            Console.WriteLine();

            // user entry
            Console.Write("How many seconds do you want your breathing session to last? ");
            int sessionTime = int.Parse(Console.ReadLine());
            Console.Clear();

            // starting activity
            session1.BreathingExcercise(sessionTime);
            Console.Clear();

            // activity end message
            Console.WriteLine(session1.EndingMessage(session1.GetName()));
        }
    }
}