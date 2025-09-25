class Video
{
    private string _title;
    private string _author;
    private int _length;

    List<Comment> _comments = new List<Comment>();

    public Video()
    {
        _title = "Unknown";
        _author = "Unknown";
        _length = 0;
    }

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int NumberComments()
    {
        return _comments.Count();
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} senconds");
        Console.WriteLine();
        Console.WriteLine($"{NumberComments()} comments:");
        Console.WriteLine("--------------------------------------------");
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"Name: {comment.GetName()}");
            Console.WriteLine($"Comment: {comment.GetCommentText()}");
            Console.WriteLine();
        }
    }
}