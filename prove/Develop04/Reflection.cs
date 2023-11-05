using System;
using System.Threading;

public class Reflection : Activity
{
    private string[] reflectionPrompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private string[] reflectionQuestions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        // Add more reflection questions
    };

    public Reflection() : base("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience")
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
        for (int i = 0; i < duration;)
        {
            string prompt = reflectionPrompts[random.Next(reflectionPrompts.Length)];
            Console.WriteLine(prompt);
            ShowCountdownWithSpinner(10);

            foreach (var question in reflectionQuestions)
            {
                Console.WriteLine(question);
                ShowCountdownWithSpinner(10);
                
            }
            i += reflectionQuestions.Length;
        }
    }

    public override void End()
    {
        base.End();
    }
}
