using System;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

   public override void Display()
    {
        string completionStatus;
        if (_isCompleted)
        {
            completionStatus = "X";
        }
        else
        {
            completionStatus = " ";
        }

        Console.WriteLine($"[{completionStatus}] {_name} ");
    }
    public override void RecordEvent()
    {
        _isCompleted = true;
    }

    public override bool IsCompleted()
    {
        return _isCompleted;
    }
}
