using System;

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
