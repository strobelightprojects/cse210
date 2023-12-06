using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running(new DateTime(2022, 11, 3), 20, 3.0));
        activities.Add(new Cycling(new DateTime(2022, 11, 4), 50, 9.7));
        activities.Add(new Swimming(new DateTime(2022, 11, 5), 25, 20));

        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
