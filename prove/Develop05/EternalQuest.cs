using System;
using System.Collections.Generic;
using System.IO;

// Class to manage and interact with goals
public class EternalQuest
{
    private List<Goal> goals = new List<Goal>();
    private int totalScore = 0;
    private int currentLevel = 1;

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
{
    if (goalIndex >= 0 && goalIndex < goals.Count)
    {
        int pointsEarned = goals[goalIndex].RecordEvent();
        totalScore += pointsEarned;
        Console.WriteLine($"Event recorded for goal '{goals[goalIndex].Name}'.");
    }
    else
    {
        Console.WriteLine("Invalid goal index!");
    }
}


    public void DisplayGoals()
    {
        Console.WriteLine("Current Goals:");
        if (goals.Count > 0)
        {
            for (int i = 0; i < goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {goals[i].Name} - Progress: {goals[i].GetProgress()}");
            }
        }
        else
        {
            Console.WriteLine("No goals added yet.");
        }
    }

    public void DisplayTotalScore()
    {
        Console.WriteLine($"Total Score: {totalScore}");
    }

    public void DisplayLevel()
    {
        Console.WriteLine($"Current Level: {currentLevel}");
    }

    public void LevelUp()
    {
        int previousLevel = currentLevel;
        currentLevel = (totalScore / 5000) + 1;

        if (currentLevel > previousLevel)
        {
            Console.WriteLine($"Congratulations! You've leveled up to Level {currentLevel}!");
        }
    }

    public void SaveGoals(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (Goal goal in goals)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.IsCompleted}");
            }
            writer.WriteLine($"TotalScore,{totalScore}");
        }
    }

    public void LoadGoals(string filePath)
    {
        goals.Clear();
        totalScore = 0;

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                if (parts[0] == "SimpleGoal")
                {
                    goals.Add(new SimpleGoal(parts[1], int.Parse(parts[2])));
                }
                else if (parts[0] == "EternalGoal")
                {
                    goals.Add(new EternalGoal(parts[1], int.Parse(parts[2])));
                }
                else if (parts[0] == "ChecklistGoal")
                {
                    goals.Add(new ChecklistGoal(parts[1], int.Parse(parts[2]), int.Parse(parts[3])));
                }
                else if (parts[0] == "TotalScore")
                {
                    totalScore = int.Parse(parts[1]);
                }
            }
        }
    }
}
