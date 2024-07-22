using System;

public class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public ChecklistGoal(string name, int points, int targetCount, int bonusPoints)
        : base(name, points)
    {
        _targetCount = targetCount;
        _currentCount = 0;
        _bonusPoints = bonusPoints;
    }

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

        Console.WriteLine($"[{completionStatus}] {_name} -  Currently Completed: {_currentCount}/{_targetCount} times");
    }

    public override void RecordEvent()
    {
        if (_currentCount < _targetCount)
        {
            _currentCount++;
            if (_currentCount == _targetCount)
            {
                _isCompleted = true;
                _points += _bonusPoints;
            }
        }
    }

    public override bool IsCompleted()
    {
        return _isCompleted;
    }
}
