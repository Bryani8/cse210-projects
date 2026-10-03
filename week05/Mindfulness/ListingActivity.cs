class ListingActivity: Activity
{
    private int _count;
    private List<string> _prompts;
    public ListingActivity(string name, string description, int duration, int count, List<string> prompts)
    : base(name, description, duration) 
    {
        _count = count;
        _prompts = prompts;
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
        Console.Write("\n\nList as many responses you can to the following prompt:");
            GetRandomPrompt();
            Console.Write("\nYou may begin in: ");
            ShowCountDown(5);
            Console.WriteLine();
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            _count++;
        }
        Console.WriteLine($"You listed {_count} items!");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine($"\n--- {_prompts[index]} ---");
    }

    public List<string> GetListFromUser()
    {
        return _prompts;
    }
    
}