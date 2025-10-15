public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity()
    {

    }

    public RunningActivity(string date, int length, string name, double distance) : base(date, length, name)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    
    public override double GetSpeed()
    {
        double speed = (_distance / GetLength()) * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = GetLength() / _distance;
        return pace;
    }

}