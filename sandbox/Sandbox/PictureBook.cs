using System.Net;
using System.Reflection;

public class PictureBook : Book
{
    private string _illustrator = "";

    public PictureBook() : base()
    {

    }

    public PictureBook(string author, string title, string illustrator) : base(author, title)
    {
        _illustrator = illustrator;
    }

    public string GetIllustrator()
    {
        return _illustrator;
    }

    public void SetIllustrator(string illustrator)
    {
        _illustrator = illustrator;
    }

    public string GetPictureBookInfo()
    {
        return $"{_title} written by {_author} and illustrated by {_illustrator}";
    }
}