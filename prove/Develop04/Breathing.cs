public class Breathing : Activity
{
    public Breathing() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly")
    {
    }

    public override void Start()
    {
        base.Start();
    }

    public override void Perform()
    {
        base.Perform();

        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine(i % 2 == 0 ? "Breathe in" : "Breathe out");
            ShowCountdownWithSpinner(3);
        }
    }

    public override void End()
    {
        base.End();
    }
}
