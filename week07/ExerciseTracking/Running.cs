public class Running : Activity
{
    private float _distance;

    public Running(DateTime date, int timeActivity, float distance)
    : base (date, timeActivity)
    {
        _distance = distance;
    }

    public override float GetDistance() => _distance;
    public override float GetSpeed()
    {
        return _distance / GetTimeActivity() * 60;
    }

    public override float GetPace()
    {
        return GetTimeActivity() / _distance;
    }

    
}