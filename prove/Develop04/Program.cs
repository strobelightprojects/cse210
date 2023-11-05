using System;
using System.Threading;

class Program
{
    static void Main()
    {
        while (true)
        {
            DisplayMenu();
            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= 4)
            {
                Activity activity = null;

                switch (choice)
                {
                    case 1:
                        activity = new Breathing();
                        break;
                    case 2:
                        activity = new Reflection();
                        break;
                    case 3:
                        activity = new Listing();
                        break;
                    case 4:
                        return;
                }

                activity.Start();
                activity.Perform();
                activity.End();
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
            }

            Console.Write("Do you want to perform another activity? (yes/no): ");
            if (Console.ReadLine().ToLower() != "yes")
            {
                break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("Menu:");
        Console.WriteLine("1. Breathing");
        Console.WriteLine("2. Reflection");
        Console.WriteLine("3. Listing");
        Console.WriteLine("4. Exit");
        Console.Write("Enter your choice (1-4): ");
    }
}
