public class SwimmingActivity : Activity
{
    private int _laps;

    public SwimmingActivity()
    {

    }

    public SwimmingActivity(string date, int length, string name, int laps) : base(date, length, name)
    {
        _laps = laps;
    }


    public override double GetDistance()
    {
        double distance = _laps * 50.0 / 1000.0;
        return distance;
    }

    public override double GetSpeed()
    {
        double speed = (GetDistance() / GetLength()) * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = 60 / GetSpeed();
        return pace;
    }
}