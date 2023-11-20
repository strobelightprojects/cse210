using System;


public abstract class Goal
{
    public string Name { get; set; }
    public bool IsCompleted { get; protected set; }

    public abstract int RecordEvent();
    public abstract string GetProgress();
}
