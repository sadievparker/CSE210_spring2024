using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _totalPoints;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalPoints = 0;
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.Write($"{i + 1}. ");
            _goals[i].Display();
        }
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal goal = _goals[goalIndex];
            goal.RecordEvent();
            _totalPoints += goal.GetPoints();
        }
    }

    public void SaveGoals(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_totalPoints);
            foreach (var goal in _goals)
            {
                writer.WriteLine($"{goal.GetType().Name}|{goal.GetName()}|{goal.GetPoints()}|{goal.IsGoalCompleted()}");
            }
        }
    }

    public void LoadGoals(string filename)
    {
        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                _totalPoints = int.Parse(reader.ReadLine());
                _goals.Clear();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split('|');
                    string type = parts[0];
                    string name = parts[1];
                    int points = int.Parse(parts[2]);
                    bool isCompleted = bool.Parse(parts[3]);

                    Goal goal = null;
                    switch (type)
                    {
                        case "SimpleGoal":
                            goal = new SimpleGoal(name, points);
                            break;
                        case "EternalGoal":
                            goal = new EternalGoal(name, points);
                            break;
                        case "ChecklistGoal":
                            goal = new ChecklistGoal(name, points, 10, 500); 
                            break;
                    }

                    if (goal != null)
                    {
                        if (isCompleted)
                        {
                            goal.RecordEvent();
                        }
                        _goals.Add(goal);
                    }
                }
            }
        }
    }

    public int GetTotalPoints()
    {
        return _totalPoints;
    }
}
