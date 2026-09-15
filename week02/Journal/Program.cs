using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        string option = "";
        do
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            option = Console.ReadLine();
            if (option == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();
                string date = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry()
                {
                    _date = date,
                    _promptText = prompt,
                    _entryText = response
                };
                journal.AddEntry(newEntry);
            }

            if (option == "2")
            {
                journal.DisplayAll();
            }

            if (option == "3")
            {
                Console.Write("What is the filename? ");
                string fileName = Console.ReadLine();
                journal.LoadFromFile(fileName);
            }

            if (option == "4")
            {
                Console.Write("What is the filename? ");
                string saveFileName = Console.ReadLine();
                journal.SaveToFile(saveFileName);
            }
        } while (option != "5");
    }
}