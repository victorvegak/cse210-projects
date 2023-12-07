
using System.Reflection.Metadata;

class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int duration, double distance) : base( date, duration)
    {
        _distance = distance;
    }
    public override double GetDistance()
    {
        return _distance;
    }
    public override double GetSpeed()
    {
        return _distance / _activityDuration * 60;
    }
    public override double GetPace()
    {
        return _activityDuration / _distance;
    }

}