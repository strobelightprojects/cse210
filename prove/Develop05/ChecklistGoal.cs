using System;


public class ChecklistGoal : Goal
{
    private int targetCount;
    private int pointsPerEvent;
    private int currentCount;

    public ChecklistGoal(string name, int targetCount, int pointsPerEvent)
    {
        Name = name;
        this.targetCount = targetCount;
        this.pointsPerEvent = pointsPerEvent;
    }

    public override int RecordEvent()
    {
        currentCount++;
        int points = pointsPerEvent;
        if (currentCount == targetCount)
        {
            IsCompleted = true;
            points += 500; // Bonus points when the target is achieved
        }
        return points;
    }

    public override string GetProgress()
    {
        return $"Completed {currentCount}/{targetCount} times";
    }
}
