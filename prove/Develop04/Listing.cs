using System;
using System.Threading;

public class Listing : Activity
{
    private string[] listingPrompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes"
    };

    public Listing() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area")
    {
    }

    public override void Start()
    {
        base.Start();
    }

    public override void Perform()
    {
        base.Perform();

        Random random = new Random();
        string prompt = listingPrompts[random.Next(listingPrompts.Length)];
        Console.WriteLine(prompt);
        ShowCountdownWithSpinner(5);

        Console.WriteLine("Start listing items. Press Enter after each item.");
        int itemCount = 0;
        while (duration > 0)
        {
            Console.ReadLine();
            itemCount++;
            duration--;
        }

        Console.WriteLine($"You listed {itemCount} items.");
    }

    public override void End()
    {
        base.End();
    }
}
