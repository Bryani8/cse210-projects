public class Cycling : Activity
{
    private float _speed;

    public Cycling(DateTime date, int timeActivity, float speed)
    : base (date, timeActivity)
    {
        _speed = speed;
    }

    public override float GetSpeed() => _speed;
    public override float GetDistance()
    {
        return GetSpeed() / 60 * GetTimeActivity();
    }

    public override float GetPace()
    {
        return GetTimeActivity() / GetDistance();
    }
}