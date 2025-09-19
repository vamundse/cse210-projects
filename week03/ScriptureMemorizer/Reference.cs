/*
This class sets the book, chapter and verses of the scripture reference.
I decided to try and make som getters and setters.
*/

class Reference
{
    // variables
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    // constructors
    public Reference()
    {
        _book = "Unknown";
        _chapter = 0;
        _verse = 0;
        _endVerse = 0;
    }

    public Reference(string book, int chapter, int verse)
    {
        SetBook(book);
        SetChapter(chapter);
        SetVerse(verse);
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        SetBook(book);
        SetChapter(chapter);
        SetVerse(startVerse);
        SetEndVerse(endVerse);
    }

    // setters
    public void SetBook(string book)
    {
        _book = book;
    }

    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }

    public void SetVerse(int verse)
    {
        _verse = verse;
    }

    public void SetEndVerse(int endVerse)
    {
        _endVerse = endVerse;
    }

    // getters
    public string GetBook()
    {
        return _book;
    }

    public int GetChapter()
    {
        return _chapter;
    }

    public int GetVerse()
    {
        return _verse;
    }

    public int GetEndVerse()
    {
        return _endVerse;
    }

    // displays the reference
    public string DisplayReference()
    {
        if (_endVerse != 0)
        {
            return $"{GetBook()} {GetChapter()}:{GetVerse()}-{GetEndVerse()}";
        }
        else
        {
            return $"{GetBook()} {GetChapter()}:{GetVerse()}";
        }

    }
}