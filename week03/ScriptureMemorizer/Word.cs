/*
This class checks if a word is hidden or not,
shows the word if not hidden and hides the word if hidden.
An tells us if a word is hidden or not.
This functionality is used in the scripture class.
*/

class Word
{
    // variables
    private string _text;
    private bool _isHidden;

    // constructors
    public Word()
    {
        _text = "No text";
        _isHidden = false;
    }

    public Word(string text)
    {
        _text = text;
        _isHidden = IsHidden();
    }

    // hides or shows the word
    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    // checks if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // displays the word with _ or without
    public string DisplayWord()
    {
        if (_isHidden == true)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}