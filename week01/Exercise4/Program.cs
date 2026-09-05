using System;
using System.Collections.Generic;
using System.Transactions;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;
        int total = 0;
        float average = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
            
        } while(number != 0);
        
        int largestNumber = numbers[0];
        foreach (int numberD in numbers)
        {
            total += numberD;
            int currentNumber = numberD;
            if (currentNumber > largestNumber)
            {
                largestNumber = currentNumber;
            }
        }

        average = (float)total / numbers.Count;

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largestNumber}");
    }
}