using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment homework = new Assignment("Bryan Morocho", "Fractions");
        Console.WriteLine(homework);
        MathAssignment mathHomework = new MathAssignment("Bryan Morocho", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathHomework.GetSummary());
        Console.WriteLine(mathHomework.GetHomeWorkList());

        WritingAssignment writingHomework = new WritingAssignment("Bryan Morocho", "European History", "The causes of World War");
        Console.WriteLine(writingHomework.GetSummary());
        Console.WriteLine(writingHomework.GetWritingInformation());
    }
}