/*
Program function: Makes and displays a text entry.

Author: Vegard André Amundsen

Last modified: 12.10.2025
*/

public class Entry
{
    // Initiates the three variables of the class
    public string _date;
    public string _promptText;
    public string _entryText;

    // Displays a singe entry in the journal
    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }

    // Returns the values of all three variables of the class
    public string ReturnValue()
    {
        return $"{_date}|{_promptText}|{_entryText}";
    }
}