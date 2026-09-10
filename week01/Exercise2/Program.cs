using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please, type your grade: ");
        string inputUser = Console.ReadLine();
        int grade = int.Parse(inputUser);
        string letter = "";
        int secondDigit = grade / 10;
        string classLetter = "";
        if (secondDigit >= 7)
        {
            classLetter = "+";
        }
        else if (secondDigit < 3)
        {
            classLetter = "-";
        }

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}{classLetter}");

        if (grade >= 70)
        {
            Console.WriteLine("You passed!");
        }
        else
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}