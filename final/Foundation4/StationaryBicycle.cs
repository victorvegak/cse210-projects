
using System.Reflection.Metadata;

class StationaryBicycle : Activity
{
    private double _speed;

    public StationaryBicycle(DateTime date, int duration, double speed)
     : base(date, duration)
    {
        _speed = speed;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetDistance()
    {
        return _speed * _activityDuration / 60;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }


}