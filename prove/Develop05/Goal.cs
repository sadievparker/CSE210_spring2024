using System;

public abstract class Goal
{
    protected string _name;
    protected int _points;
    protected bool _isCompleted;

    public Goal(string name, int points)
    {
        _name = name;
        _points = points;
        _isCompleted = false;
    }

    public abstract void Display();
    public abstract void RecordEvent();
    public abstract bool IsCompleted();
    public int GetPoints()
    {
        return _points;
    }

    public string GetName()
    {
        return _name;
    }

    public bool IsGoalCompleted()
    {
        return _isCompleted;
    }
}
