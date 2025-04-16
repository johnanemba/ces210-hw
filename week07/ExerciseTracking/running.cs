public class Running : Activity
{
    private double _distanceMiles;

    public Running(string date, int duration, double distanceMiles)
        : base(date, duration)
    {
        _distanceMiles = distanceMiles;
    }

    public override double GetDistance()
    {
        return _distanceMiles;
    }

    public override double GetSpeed()
    {
        return (_distanceMiles / GetDuration()) * 60;
    }

    public override double GetPace()
    {
        return GetDuration() / _distanceMiles;
    }
}
