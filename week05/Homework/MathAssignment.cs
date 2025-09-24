public class MathAssignment : Assignment
{
    private string _textBookSection = "";
    private string _problems = "";

    public MathAssignment()
    {
        _textBookSection = "Unknown";
        _problems = "Unknown";
    }

    public MathAssignment(string studentName, string topic, string textBookSection, string problems) : base(studentName, topic)
    {
        _textBookSection = textBookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{GetSummary()}\n{_textBookSection} {_problems}";
    }
}