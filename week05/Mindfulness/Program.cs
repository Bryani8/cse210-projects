// I added a log that shows the number of activities that the user has performed, and when the user quit the program
// receives a summary of those activities.

using System;
using System.Numerics;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        int breathingActivityTimes = 0;
        int listingActivityTimes = 0;
        int reflectingActivityTimes = 0;
        BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);

        List<string> promptsRA = new List<string>();
        promptsRA.Add("Think of a time when you stood up for someone else.");
        promptsRA.Add("Think of a time when you did something really difficult.");
        promptsRA.Add("Think of a time when you helped someone in need.");
        promptsRA.Add("Think of a time when you did something truly selfless.");

        List<string> questionsRA = new List<string>();
        questionsRA.Add("Why was this experience meaningful to you?");
        questionsRA.Add("Have you ever done anything like this before?");
        questionsRA.Add("How did you get started?");
        questionsRA.Add("How did you feel when it was complete?");
        questionsRA.Add("What made this time different than other times when you were not as successful?");
        questionsRA.Add("What is your favorite thing about this experience?");
        questionsRA.Add("What could you learn from this experience that applies to other situations?");
        questionsRA.Add("What did you learn about yourself through this experience?");
        questionsRA.Add("How can you keep this experience in mind in the future?");
        ReflectingActivity reflectingActivity = new ReflectingActivity("Relfecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in another aspects of your life.", 0, promptsRA, questionsRA);
        // reflectingActivity.Run();

        List<string> promptsLA = new List<string>();
        promptsLA.Add("Who are people that you appreciate?");
        promptsLA.Add("What are personal strengths of yours?");
        promptsLA.Add("Who are people that you have helped this week?");
        promptsLA.Add("When have you felt the Holy Ghost this month?");
        promptsLA.Add("Who are some of your personal heroes?");
        ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", 0, 0, promptsLA);
        // listingActivity.Run();
        string option = "";
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Start breathing activity");
            Console.WriteLine("\t2. Start reflecting activity");
            Console.WriteLine("\t3. Start listing activity");
            Console.WriteLine("\t4. Quit");
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();

            if (option == "1")
            {
                breathingActivity.Run();
                breathingActivityTimes++;
            }

            else if (option == "2")
            {
                reflectingActivity.Run();
                reflectingActivityTimes++;
            }

            else if (option == "3")
            {
                listingActivity.Run();
                listingActivityTimes++;
            }
        } while (option != "4");
        int total = breathingActivityTimes + listingActivityTimes + reflectingActivityTimes;
        Console.WriteLine($"\nYou have completed {total} activities");
        Console.WriteLine($"{breathingActivityTimes} breathing activities");
        Console.WriteLine($"{listingActivityTimes} listing activities");
        Console.WriteLine($"{reflectingActivityTimes} reflecting activities");
    }
}