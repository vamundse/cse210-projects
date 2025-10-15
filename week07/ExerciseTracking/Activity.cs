public abstract class Activity
{
    private string _date;
    private int _length;
    private string _name;

    public Activity()
    {
        
    }

    public Activity(string date, int length, string name)
    {
        _date = date;
        _length = length;
        _name = name;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public string GetSummary()
    {
        return $"{_date} {_name} ({_length} min): Distance {GetDistance():F2} km, Speed {GetSpeed():F2} kph, Pace {GetPace():F2} min per km";
    }

    public double GetLength()
    {
        return _length;
    }
}