class Program
{
    static void Main(string[] args)
    {
        EternalQuest eternalQuest = new EternalQuest();

        bool continueRunning = true;
        while (continueRunning)
        {
            Console.WriteLine("1. Add a new goal");
            Console.WriteLine("2. View current goals");
            Console.WriteLine("3. Update progress for a goal");
            Console.WriteLine("4. Display total score");
            Console.WriteLine("5. Show current level");
            Console.WriteLine("6. Save goals to a file");
            Console.WriteLine("7. Load goals from a file");
            Console.WriteLine("8. Exit");
            Console.WriteLine("Enter your choice:");

            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Console.WriteLine("Select goal type:");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write("Enter your choice: ");
                    string goalTypeChoice = Console.ReadLine();

                    Console.Write("Enter goal name: ");
                    string goalName = Console.ReadLine();

                    switch (goalTypeChoice)
                    {
                        case "1":
                            Console.Write("Enter points for completing the goal: ");
                            int points = int.Parse(Console.ReadLine());
                            eternalQuest.AddGoal(new SimpleGoal(goalName, points));
                            Console.WriteLine("Simple Goal added successfully.");
                            break;
                        case "2":
                            Console.Write("Enter points for each recording: ");
                            int pointsPerRecording = int.Parse(Console.ReadLine());
                            eternalQuest.AddGoal(new EternalGoal(goalName, pointsPerRecording));
                            Console.WriteLine("Eternal Goal added successfully.");
                            break;
                        case "3":
                            Console.Write("Enter target count: ");
                            int targetCount = int.Parse(Console.ReadLine());
                            Console.Write("Enter points for each recording: ");
                            int pointsPerEvent = int.Parse(Console.ReadLine());
                            eternalQuest.AddGoal(new ChecklistGoal(goalName, targetCount, pointsPerEvent));
                            Console.WriteLine("Checklist Goal added successfully.");
                            break;
                        default:
                            Console.WriteLine("Invalid goal type choice.");
                            break;
                    }
                    break;
                case "2":
                    eternalQuest.DisplayGoals();
                    break;
                case "3":
                    eternalQuest.DisplayGoals();
                    Console.Write("Enter the index of the goal to update progress: ");
                    if (int.TryParse(Console.ReadLine(), out int goalIndexToUpdate))
                    {
                        eternalQuest.RecordEvent(goalIndexToUpdate - 1); // -1 because of 1-based indexing in the display
                        eternalQuest.LevelUp(); // Level up after updating progress
                        Console.WriteLine("Progress updated successfully.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid goal index.");
                    }
                    break;
                    break;
                case "4":
                    eternalQuest.DisplayTotalScore();
                    break;
                case "5":
                    eternalQuest.DisplayLevel();
                    break;
                case "6":
                    Console.WriteLine("Enter file path to save goals:");
                    string savePath = Console.ReadLine();
                    eternalQuest.SaveGoals(savePath);
                    Console.WriteLine("Goals saved successfully.");
                    break;
                case "7":
                    Console.WriteLine("Enter file path to load goals:");
                    string loadPath = Console.ReadLine();
                    eternalQuest.LoadGoals(loadPath);
                    Console.WriteLine("Goals loaded successfully.");
                    break;
                case "8":
                    continueRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }
        }
    }
}