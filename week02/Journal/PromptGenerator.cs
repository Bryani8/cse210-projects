using System;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>
    {
        "What is one thing I am deeply grateful for right now?",
        "What emotion am I feeling most strongly today, and where do I feel it in my body?",
        "What was a challenge I faced today, and what is one lesson or silver lining hidden inside it?",
        "How did I show kindness to myself (or someone else) today?",
        "What is one intention I want to carry into tomorrow?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}