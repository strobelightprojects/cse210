using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1.JobTitle = "Chef";
        job1.Company = "KFC";
        job1.StartYear = 2012;
        job1.EndYear = 2020;

        Job job2 = new Job();
        job2.JobTitle = "Manager";
        job2.Company = "KFC";
        job2.StartYear = 2020;
        job2.EndYear = 2023;

        Resume myResume = new Resume();
        myResume.Name = "Allison Rose";

        myResume.Jobs.Add(job1);
        myResume.Jobs.Add(job2);

        myResume.Display();
    }
}