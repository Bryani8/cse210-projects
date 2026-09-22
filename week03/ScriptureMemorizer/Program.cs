using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Reference _reference = new Reference("2 Nephi", 26, 31);
        string text = "But the laborer in Zion shall labor for Zion; for if they labor for money they shall perish.";
        Scripture _scripture = new Scripture(_reference, text);
        string response = "";

        do
        {
            Console.Clear();
            Console.WriteLine(_scripture.GetDisplayText());
            if (_scripture.IsCompletelyHidden())
            {
                break;
            }
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            response = Console.ReadLine();
            if (response == "quit")
            {
                break;
            }
            _scripture.HideRandomWords(3);
        } while (true);
    }
}