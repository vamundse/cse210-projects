public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity()
    {

    }

    public CyclingActivity(string date, int length, string name, double speed) : base(date, length, name)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        double distance = (_speed / 60) * GetLength();
        return distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        double pace = 60 / _speed;
        return pace;
    }

    

}