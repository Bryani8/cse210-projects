using System.Diagnostics.CodeAnalysis;

class ReflectingActivity: Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions)
    : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
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
        Console.Write("\n\nConsider the following prompt:");
            DisplayPrompt();
            Console.WriteLine("When you have something in mind , press enter to continue.");
            Console.ReadLine();
            Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            ShowSpinner(10);
        }
        DisplayEndingMessage();
        
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"\n--- {GetRandomPrompt()} ---");
    }

    public void DisplayQuestion()
    {
       Console.Write($"\n> {GetRandomQuestion()} "); 
    }
}