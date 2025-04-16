using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var activities = new List<Activity>
        {
            new Running("04 Apr 2025", 30, 3.0),
            new Cycling("04 Apr 2025", 45, 14.5),
            new Swimming("04 Apr 2025", 40, 32)
        };

        foreach (Activity act in activities)
        {
            Console.WriteLine(act.GetSummary());
        }
    }
}
