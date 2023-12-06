using System;
using System.Collections.Generic;

public class Activity
{
    private DateTime date;
    protected int lengthMinutes;

    public Activity(DateTime date, int lengthMinutes)
    {
        this.date = date;
        this.lengthMinutes = lengthMinutes;
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual string GetSummary()
    {
        return $"{date:dd MMM yyyy} - {GetType().Name} ({lengthMinutes} min)";
    }
}

public class Running : Activity
{
    private double distance;

    public Running(DateTime date, int lengthMinutes, double distance) : base(date, lengthMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return distance / (lengthMinutes / 60.0); 
    }

    public override double GetPace()
    {
        return lengthMinutes / distance; 
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" - Distance: {distance:F2} miles, Speed: {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}

public class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, int lengthMinutes, double speed) : base(date, lengthMinutes)
    {
        this.speed = speed;
    }

    public override double GetSpeed()
    {
        return speed;
    }

    public override double GetDistance()
    {
        return speed * (lengthMinutes / 60.0); 
    }

    public override double GetPace()
    {
        return 60.0 / speed; 
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" - Distance: {GetDistance():F2} miles, Speed: {speed:F2} mph, Pace: {GetPace():F2} min per mile";
    }
}

public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, int lengthMinutes, int laps) : base(date, lengthMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return laps * 50.0 / 1000; 
    }

    public override double GetSpeed()
    {
        return GetDistance() / (lengthMinutes / 60.0); 
    }

    public override double GetPace()
    {
        return lengthMinutes / GetDistance(); // Pace in minutes per kilometer
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" - Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}

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
