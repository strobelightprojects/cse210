class Yoga : Activity
{
    private string[] yogaPoses = {
        "Mountain ",
        "Downward-Facing Dog",
        "Warrior II",
        "Tree" ,
        "Child's ",
        "Cobra "
    };

    public Yoga() : base("Yoga", "This activity will guide you through a yoga session to improve flexibility and relaxation.")
    {
    }

    public override void Perform()
    {
        base.Perform();

        Random random = new Random();
        for (int i = 0; i < duration; i++)
        {
            string pose = yogaPoses[i % yogaPoses.Length];
            Console.WriteLine($"Perform the {pose} yoga pose...");
            ShowCountdownWithSpinner(15);
        }
    }
}
