using System;

class Program
{
    static void Main(string[] args)
    {
         Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();

        int per = int.Parse(answer);

        string letter = "";

        if (per >= 90)
        {
            letter = "A";
        }
             else if (per >= 80)
        {
                letter = "B";
        }
                  else if (per >= 70)
        {
                    letter = "C";
        }
                        else if (per >= 60)
        {
                             letter = "D";
        }
                             else
        {
                                letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");
        
        if (per >= 70)
        {
             Console.WriteLine("Congratualtions you passed the class!");
        }
            else
        {
                 Console.WriteLine("Sorry you didn't pass the class!");
        }
    }
 }
