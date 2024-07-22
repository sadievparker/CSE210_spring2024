using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void Display()
    {
        string completionStatus;
        if (_isCompleted)
        {
            completionStatus = " ";
        }
        else
        {
            completionStatus = " ";
        }

        Console.WriteLine($"[{completionStatus}] {_name} ");
    }

    public override void RecordEvent()
    {
        // Points awarded each time without marking as completed
    }

    public override bool IsCompleted()
    {
        return false; // Eternal goals are never completed
    }
}
