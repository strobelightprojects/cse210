using System;
using System.Threading;

public class Activity
{
    protected string name;
    protected string description;
    protected int duration;

    public Activity(string name, string description)
    {
        this.name = name;
        this.description = description;
    }

    public virtual void Start()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Description: {description}");
        Console.Write("Enter the duration in seconds: ");
        duration = int.Parse(Console.ReadLine());
    }

    public void ShowCountdownWithSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(".");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public virtual void Perform()
    {
        Console.WriteLine("Prepare to begin...");
        ShowCountdownWithSpinner(3);
        Console.WriteLine("Activity started.");
    }

    public virtual void End()
    {
        Console.WriteLine("Good job!");
        Console.WriteLine($"Activity: {name}");
        Console.WriteLine($"Duration: {duration} seconds");
        ShowCountdownWithSpinner(3);
    }
}
