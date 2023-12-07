
class Activity
{
    protected DateTime _activityDate;
    protected int _activityDuration;

    public Activity (DateTime date, int duration)
    {
        _activityDate = date;
        _activityDuration = duration;
    }

    //methods

    public virtual double GetDistance()
    {
        return 0.0;
    }
    public virtual double GetSpeed()
    {
        return 0.0;
    }
    public virtual double GetPace()
    {
        return 0.0;
    }
    public virtual string GetSummary()
    {
        return $" Date: {_activityDate: dd MMM yyyy} Activity: {GetType().Name} ({_activityDuration} min) - " +
        $"Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per miles";
    }


}