using System;

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
