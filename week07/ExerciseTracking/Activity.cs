using System.Runtime.InteropServices;

public abstract class Activity
{
    private DateTime _date;
    private int _timeActivity;

    public Activity(DateTime date, int timeActivity)
    {
        _date = date;
        _timeActivity = timeActivity;
    }

    // private float _distance;
    // private float _speed;
    // private int _numberLaps;
    public int GetTimeActivity() => _timeActivity;

    public abstract float GetDistance();
    public abstract float GetSpeed();
    public abstract float GetPace();

    public string GetSumary(string activity)
    {
        string formattedDate = _date.ToString("dd MMM yyyy");
        string data = $"{formattedDate} {activity} ({_timeActivity} min)- Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
        return data;
    }
}