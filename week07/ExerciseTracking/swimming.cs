public class Swimming : Activity
{
    private int _lapCount;

    public Swimming(string date, int duration, int lapCount)
        : base(date, duration)
    {
        _lapCount = lapCount;
    }

    public override double GetDistance()
    {
        return _lapCount * 50 / 1000.0 * 0.62; // Convert to miles
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetDuration()) * 60;
    }

    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }
}
