class BreathingActivity: Activity
{
    public BreathingActivity(string name, string description, int duration)
    : base(name, description, duration)
    {
        
    }

    public void Run()
    {
        DisplayStartingMessage();
        string inputUser = Console.ReadLine();
        SetDuration(int.Parse(inputUser));
        Console.Clear();
        Console.Write("Get Ready... ");
        ShowSpinner(5);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime)
        {
            Console.Write("\n\nBreathe in... ");
            ShowCountDown(5);
            Console.Write("\nNow breathe out... ");
            ShowCountDown(5);
        }
        DisplayEndingMessage();
    }
}