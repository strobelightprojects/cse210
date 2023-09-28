using System;

public class Job
{
 public string JobTitle;
 public string Company;
 public int StartYear;
public int EndYear;

 public void Display()
    {
    Console.WriteLine($"{JobTitle} ({Company}) {StartYear}-{EndYear}");
    }
}