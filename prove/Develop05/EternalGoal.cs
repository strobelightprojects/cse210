using System;


public class EternalGoal : Goal
{
    private int pointsPerEvent;

    public EternalGoal(string name, int pointsPerEvent)
    {
        Name = name;
        this.pointsPerEvent = pointsPerEvent;
    }

    public override int RecordEvent()
    {
        return pointsPerEvent;
    }

    public override string GetProgress()
    {
        return "[ ]"; 
    }
}
