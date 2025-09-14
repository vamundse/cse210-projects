/*
Program function: Adds text entries to a list, displays all entries in the list
and saves and loads files with text entries of the same type.

Author: Vegard André Amundsen

Last modified: 12.10.2025
*/

using System.IO.Enumeration;
using System.IO;

public class Journal
{
    // Initializes the list where the journal entries will be stored
    public List<Entry> _entries = new List<Entry>();

    // Adds an entry to the list of the journal
    public void AddEntry(Entry addEntry)
    {
        _entries.Add(addEntry);
    }

    // Displays all of the entries of the journal
    public void DisplayAll()
    {
        foreach (Entry journalEntry in _entries)
        {
            journalEntry.Display();
        }
    }

    // Saves all of the entries of the journal to a file
    public void SaveToFile(string file)
    {
        string filename = file;

        using (StreamWriter saveFile = new StreamWriter(filename))
        {
            foreach (Entry journalEntry in _entries)
            {
                saveFile.WriteLine(journalEntry.ReturnValue());
            }

        }
    }

    // loads all of the entries from a saved journal file
    public void LoadFromFile(string file)
    {
        string filename = file;
        string[] lines = System.IO.File.ReadAllLines(filename);

        // clears the _entries list to load the file
        _entries.Clear();

        // splits the file into variables and adds them to a new entry
        // and then adds the entry itself to the journal _entries list
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            Entry loadedJournalEntry = new Entry();
            loadedJournalEntry._date = parts[0];
            loadedJournalEntry._promptText = parts[1];
            loadedJournalEntry._entryText = parts[2];

            AddEntry(loadedJournalEntry);
        }
    }
}