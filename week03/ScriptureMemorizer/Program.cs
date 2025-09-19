/*
Program: This is the scripture memorizer program. It lets the user input a scripture and then displays it.
It then lets the user hide a certain number of words chosen by the user until all the words are hidden or the user quits the program.

Author: Vegard Amundsen
Last modified: 19.09.2025

Additional features: I have made it possible for the user to choose how many words the program hides per turn.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        // creates a new reference object
        Reference inputReference = new Reference();

        // sets the reference book and chapter
        Console.Write("Enter the book of your scripture: ");
        inputReference.SetBook(Console.ReadLine());
        Console.Write("Enter the chapter of your scripture: ");
        inputReference.SetChapter(int.Parse(Console.ReadLine()));

        // checks if the scripture has multiple verses
        Console.Write("Is your scripture multiple verses (y/n)? ");
        string numVerses = Console.ReadLine();
        while (numVerses != "y" && numVerses != "n")
        {
            Console.WriteLine("You have to write y or n to continue");
            Console.Write("Is your scripture multiple verses (y/n)? ");
            numVerses = Console.ReadLine();
        }
        // sets the referemce verses
        if (numVerses.ToLower() == "n")
        {
            Console.Write("Enter the verse of your scripture: ");
            inputReference.SetVerse(int.Parse(Console.ReadLine()));
        }
        else if (numVerses.ToLower() == "y")
        {
            Console.Write("Enter the starting verse of your scripture: ");
            inputReference.SetVerse(int.Parse(Console.ReadLine()));
            Console.Write("Enter the ending verse of your scripture: ");
            inputReference.SetEndVerse(int.Parse(Console.ReadLine()));
        }
        // lets the user write the scripture
        Console.WriteLine("Enter the text of the scripture: ");
        string text = Console.ReadLine();

        // creates the scripture object
        Scripture newScripture = new Scripture(inputReference, text);

        // lets the user decide how many words to hide
        Console.Write("How many words would you like to hide per turn? ");
        newScripture.SetNumberToHide(int.Parse(Console.ReadLine()));

        // clears the console and displays the scripture
        Console.Clear();
        newScripture.DisplayScripture();

        // gives the user instructions on how the program works and sets the input variable
        string input = "";
        Console.WriteLine();
        Console.WriteLine("To hide words press enter, to quit the program write quit");

        // while the input is not quit the user can press enter to continue to hide words
        while (input.ToLower() != "quit")
        {
            input = Console.ReadLine();
            if (input == "")
            {
                if (newScripture.AllHidden())
                {
                    Environment.Exit(0);
                }
                Console.Clear();
                newScripture.HideRandomWords();
                newScripture.DisplayScripture();
                Console.WriteLine();
                Console.WriteLine("To hide words press enter, to quit the program write quit");
            }
            else
            {
                Console.WriteLine("You can only press enter to hide words or write quit to quit the program");
            }
        }
    }
}