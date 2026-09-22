// I added the program the option to randomly choose a scripture from a list previously created.
using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> lScripture = new List<Scripture>();

        Reference _reference1 = new Reference("2 Nephi", 26, 31);
        string text1 = "But the laborer in Zion shall labor for Zion; for if they labor for money they shall perish.";
        Scripture _scripture1 = new Scripture(_reference1, text1);
        Reference _reference2 = new Reference("Galatians", 5, 22, 23);
        string text2 = "22 But the fruit of the Spirit is love, joy, peace, longsuffering, gentleness, goodness, faith, Meekness, temperance: against such there is no law.";
        Scripture _scripture2 = new Scripture(_reference2, text2);
        Reference _reference3 = new Reference("Matthew", 5, 3);
        string text3 = "Blessed are the poor in spirit: for theirs is the kingdom of heaven.";
        Scripture _scripture3 = new Scripture(_reference3, text3);
        lScripture.Add(_scripture1);
        lScripture.Add(_scripture2);
        lScripture.Add(_scripture3);
        string response = "";

        Random random = new Random();
        int index = random.Next(lScripture.Count);


        do
        {
            Console.Clear();
            Console.WriteLine(lScripture[index].GetDisplayText());
            if (lScripture[index].IsCompletelyHidden())
            {
                break;
            }
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            response = Console.ReadLine();
            if (response == "quit")
            {
                break;
            }
            lScripture[index].HideRandomWords(3);
        } while (true);
    }
}