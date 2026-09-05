using System;
using System.Diagnostics;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the magic number? ");
        string inputUser = Console.ReadLine();
        int magicNumber = int.Parse(inputUser);
        int tries = 0; 
        int guessNumber;
        do
        {
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());
            tries++;
            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guessNumber != magicNumber);
        Console.WriteLine($"Guessing the number takes you {tries} tries.");
    }
}