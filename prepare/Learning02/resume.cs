using System;

public class Resume
{
    public string Name;

    // Make sure to initialize your list to a new List before you use it.
    public List<Job> Jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine("Jobs:");

        // Notice the use of the custom data type "Job" in this loop
        foreach (Job job in Jobs)
        {
            // This calls the Display method on each job
            job.Display();
        }
    }
}