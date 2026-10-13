public class Swimming : Activity
{
    private int _numberLaps;

     public Swimming(DateTime date, int timeActivity, int numberLaps)
    : base (date, timeActivity)
    {
        _numberLaps = numberLaps;
    }

    public override float GetDistance()
    {
        return _numberLaps * 50 / 1000;
    }
    public override float GetSpeed()
    {
        return GetDistance() / GetTimeActivity() * 60;
    }

    public override float GetPace()
    {
        return GetTimeActivity() / GetDistance();
    }

    
    
}