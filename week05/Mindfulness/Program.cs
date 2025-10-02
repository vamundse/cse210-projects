/*
Author: Vegard André Amundsen
Program: This is a mindfullness program that gives the user three different ways of practicing mindfulness.
Added functionality:
- I have made sure that the same follow-up question in the reflection activity will not be used twice.
- I have made it possible to store the prompt the user was asked so it can be displayed together with the number of things it input.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        // initialize menu choice variable
        int choice;

        // welcome message
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.WriteLine();

        do
        {
            // menu system
            Console.WriteLine("Menu options:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();

            // user input
            Console.Write("What activity do you wish to do? ");
            choice = int.Parse(Console.ReadLine());

            // make sure that the user has chosen a valid menu option
            while (choice != 1 && choice != 2 && choice != 3 && choice != 4)
            {
                Console.WriteLine();
                Console.WriteLine("You must enter a number between 1 and 3");
                Console.Write("What activity do you want to do today? ");
                choice = int.Parse(Console.ReadLine());
            }

            // if breathing activity
            if (choice == 1)
            {
                // initializes and starts the activity
                BreathingActivity breathing = new BreathingActivity();
                breathing.BreathingExcercise();
            }

            // if reflection activity
            else if (choice == 2)
            {
                // initializes and starts the activity
                ReflectionActivity reflection = new ReflectionActivity();
                reflection.ReflectionExercise();
            }

            // if listing activity
            else if (choice == 3)
            {
                // initializes and starts the activity
                ListingActivity listing = new ListingActivity();
                listing.ReflectionExercise();
            }
            
            // checks if the user wants to quit the program
        } while (choice != 4);
    }
}