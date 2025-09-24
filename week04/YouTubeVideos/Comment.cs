class Comment
{
    private string _name;
    private string _commentText;

    public Comment()
    {
        _name = "Unknown";
        _commentText = "No text";
    }

    public Comment(string name, string commentText)
    {
        _name = name;
        _commentText = commentText;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetCommentText()
    {
        return _commentText;
    }
}