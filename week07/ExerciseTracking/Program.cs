using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = [
            new Running(DateTime.Now, 30, 10),
            new Cycling(DateTime.Now, 60, 20),
            new Swimming(DateTime.Now, 60, 20)
        ];

        foreach (Activity item in activities)
        {
            string typeName = item.GetType().Name;
            Console.WriteLine(item.GetSumary(typeName));       
        }
        
            

    }
}