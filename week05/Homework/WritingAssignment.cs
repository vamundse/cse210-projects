public class WritingAssignment : Assignment
{
    private string _title = "";

    public WritingAssignment()
    {
        _title = "Unknown";
    }

    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{GetSummary()}\n{_title} by {GetStudentName()}";
    }
}