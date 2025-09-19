/*
This class handles the scripture. It gets the reference from the reference class,
it gets the text from the user and then splits it into several part in the _words list,
it gets a random word from the list and hides it or shows it and it puts together the
scripture text with hidden and non hidden words.
*/

using System.Globalization;

class Scripture
{
    // variables
    private List<Word> _words = new List<Word>();
    private Reference _reference;
    private Random _randomNumber = new Random();
    private int _numberToHide = 1;

    // constructors
    public Scripture()
    {
        Console.WriteLine("We are missing the scripture reference or the scripture text");
    }

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] parts = text.Split(" ");
        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    public void SetNumberToHide(int number)
    {
        _numberToHide = number;
    }

    // hides words in the text using the Word class methods
    public void HideRandomWords()
    {
        int tries = 0;
        int index;
        for (int i = 0; i < _numberToHide; i++)
        {
            // gets a random word index that is not already hidden
            do
            {
                index = _randomNumber.Next(0, _words.Count);
                tries++;
                // breaks the loop so it's not infinite
                if (tries > _words.Count * 3)
                {
                    break;
                }
            } while (_words[index].IsHidden() == true);

            // hides the word
            if (_words[index].IsHidden() == false)
            {
                _words[index].Hide();
            }
        }
    }

    // displays the scripture by looping the _words list
    // and using the Word class DisplayWord() method    
    public void DisplayScripture()
    {
        Console.WriteLine(_reference.DisplayReference());
        foreach (Word word in _words)
        {
            Console.Write($"{word.DisplayWord()} ");
        }
        Console.WriteLine();
    }

    // checks if all the words are hidden

    public bool AllHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;

    }
}