using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>
        {
            new Running(new DateTime(2022, 11, 03), 30, 3.0),
            new StationaryBicycle(new DateTime(2023, 11, 3), 30, 6.0),
            new Swimming(new DateTime(2022, 11, 3), 30, 20)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine();
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}