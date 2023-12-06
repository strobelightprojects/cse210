using System;

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
        return lengthMinutes / GetDistance();
    }

    public override string GetSummary()
    {
        return base.GetSummary() + $" - Distance: {GetDistance():F2} km, Speed: {GetSpeed():F2} kph, Pace: {GetPace():F2} min per km";
    }
}
