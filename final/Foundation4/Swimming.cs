
using System.Reflection.Metadata;

class Swimming : Activity
{
    private int _laps;

    public Swimming (DateTime date, int duration, int laps)
    : base(date, duration)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return _laps * 50 / 1000 * 0.62;
    }
    public override double GetSpeed()
    {
        return GetDistance() / _activityDuration * 60;
    }
    public override double GetPace()
    {
        return _activityDuration / GetDistance();
    }

} 