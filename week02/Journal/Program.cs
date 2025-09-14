/*
Program function: It makes a journaling system where you can enter journal notes
based on a prompt that is randomly generated. The journal can be saved to a file
and loaded from a file.

Author: Vegard André Amundsen

Last modified: 12.10.2025

Added features: I have added the option to get some standard or some weird prompts
when making a journal entry. In PromptGenerators.cs I made a new list with weird prompts
and then added a question in option 1 of the filesystem to ask for a standard or weird prompt.

I also added a warning about clearing the current journal when loading a file, so the user
should save the current journal if it wants to keep it before loading a new file.

Resouces used: I have used the resources available to me on the W02 Project: Journal Program page.
Additionaly I usually use a google search to help me find different resources to help me understand
different ways of doing things. I also use CoPilot to help me answer questions about something that
is wrong in my code, if the code does not do what I intended it to do or if I want to understand more
about what a piece of code does.
*/

using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");
        // Creates a new journal 
        Journal myJournal = new Journal();
        // Gets todays date and time
        DateTime theCurrentTime = DateTime.Now;
        // Creates a new PromptGenerator
        PromptGenerator prompt = new PromptGenerator();
        // Initializes the variable choice for the menu        
        int choice = 0;

        // Starts the while loop for the menu system and shows the options
        while (choice != 5)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Enter a journal entry");
            Console.WriteLine("2. Display your journal");
            Console.WriteLine("3. Save journal to a file");
            Console.WriteLine("4. Load journal from a file");
            Console.WriteLine("5. Quit the program");
            Console.Write("Your choice (1-5): ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            // Lets the user make an entry into the journal based on a random prompt
            if (choice == 1)
            {
                Entry newJournalEntry = new Entry();
                // lets the user choose between the two different prompt types
                string promptType = "";
                while (promptType.ToLower() != "standard" && promptType.ToLower() != "weird")
                {
                    Console.Write("Would you like a standard prompt or a weird one? ");
                    promptType = Console.ReadLine();
                    if (promptType.ToLower() == "standard")
                    {
                        string randomPrompt = prompt.GetRandomPrompt();
                        Console.WriteLine(randomPrompt);
                        // adds the prompt to the Entry variable _promptText
                        newJournalEntry._promptText = randomPrompt;
                    }
                    else if (promptType.ToLower() == "weird")
                    {
                        string randomPrompt = prompt.GetRandomWeirdPrompt();
                        Console.WriteLine(randomPrompt);
                        // adds the prompt to the Entry variable _promptText
                        newJournalEntry._promptText = randomPrompt;
                    }
                    else
                    {
                        Console.WriteLine("You must choose either standard or weird.");
                    }
                }

                // lets the user enter the prompt
                newJournalEntry._date = theCurrentTime.ToShortDateString();
                Console.Write("Your entry: ");
                newJournalEntry._entryText = Console.ReadLine();
                Console.WriteLine();

                // adds the entry to the journal list
                myJournal.AddEntry(newJournalEntry);
            }
            // Lets the user display all the entries
            else if (choice == 2)
            {
                myJournal.DisplayAll();
            }
            // Lets the user save journal entries to a file
            else if (choice == 3)
            {
                Console.Write("Filename: ");
                myJournal.SaveToFile(Console.ReadLine());
                Console.WriteLine();
            }
            // Lets the user load a journal file to the program
            else if (choice == 4)
            {
                Console.WriteLine("Warning! Loading a file will clear the current journal!");
                Console.WriteLine("If you want to save the currect journal, you should do");
                Console.WriteLine("it before loading the file.");
                string load = "";
                while (load.ToLower() != "yes" && load.ToLower() != "no")
                {
                    // warns the user about the dangers of loading a file and ask for confirmation
                    Console.Write("Are you sure you want to load a file? (yes/no) ");
                    load = Console.ReadLine();
                    if (load.ToLower() == "yes")
                    {
                        Console.Write("Filename: ");
                        myJournal.LoadFromFile(Console.ReadLine());
                    }
                    else if (load.ToLower() == "no")
                    {
                        Console.WriteLine("No file was loaded.");
                    }
                    else
                    {
                        Console.WriteLine("You have to choose yes or no.");
                    }
                }
                Console.WriteLine();
            }
            // displays a message as the user quits the program
            else if (choice == 5)
            {
                Console.WriteLine("Thank you for using the Journal Program :)");
            }
            // If the user does not enter a number between 1-5 it will display a message
            else
            {
                Console.WriteLine("You need to choose a number between 1-5!");
                Console.WriteLine();
            }
        }
    }
}