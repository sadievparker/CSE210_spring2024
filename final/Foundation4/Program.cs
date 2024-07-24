using System;

class Program
{
    public static void Main(string[] args)
    {
        var activities = new List<Activity>
        {
            new Running(new DateTime(2024, 7, 23), 60, 6.0),
            new Cycling(new DateTime(2024, 7, 23), 60, 15.0),
            new Swimming(new DateTime(2024, 7, 23), 30, 80)
        };

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}