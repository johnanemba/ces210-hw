public class Cycling : Activity
{
    private double _avgSpeed;

    public Cycling(string date, int duration, double avgSpeed)
        : base(date, duration)
    {
        _avgSpeed = avgSpeed;
    }

    public override double GetDistance()
    {
        return (_avgSpeed * GetDuration()) / 60;
    }

    public override double GetSpeed()
    {
        return _avgSpeed;
    }

    public override double GetPace()
    {
        return 60 / _avgSpeed;
    }
}
