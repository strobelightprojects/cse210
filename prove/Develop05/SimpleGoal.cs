using System;


public class SimpleGoal : Goal
{
    private int points;

    public SimpleGoal(string name, int points)
    {
        Name = name;
        this.points = points;
    }

    public override int RecordEvent()
    {
        IsCompleted = true;
        return points;
    }

    public override string GetProgress()
    {
        return IsCompleted ? "[X]" : "[ ]";
    }
}
