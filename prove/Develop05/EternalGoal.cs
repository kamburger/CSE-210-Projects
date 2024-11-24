using System;

public class EternalGoal : Goal
{
    private int _timesCompleted; 

    // Constructor for new EternalGoal, timescomplete = 0
    public EternalGoal(string name, string descript, int pointsworth) : base(name, descript, pointsworth, 2)
    {
        _timesCompleted = 0;
    }

    // Constructor for loaded EternalGoal (added variable too set _timesCompleted)
    public EternalGoal(string name, string descript, int pointsworth, int times) : base(name, descript, pointsworth, 2)
    {
        _timesCompleted = times;
    }


    // 
    public override void DisplayGoal()
    {
        string name = GetInfo()[0];
        string descript = GetInfo()[1];

        if (_timesCompleted == 0)
        {
            Console.Write($"[ ] {name} ({descript})");
        }
        else
        {
            Console.Write($"[X] {name} ({descript}) ---Completed {_timesCompleted} times!");
        }
    }


    public override void CompleteGoal()
    {
        _timesCompleted += 1;
        int points = _timesCompleted*GetPointsWorth();
        SetPointsEarned(points);
    }

    public override string SaveGoalFormat()
    {
        string name = GetInfo()[0];
        string description = GetInfo()[1];
        int pointsWorth = GetPointsWorth();
        int pointsEarned = GetPointsEarned();
        return $"2|{name}|{description}|{pointsWorth}|{pointsEarned}|{_timesCompleted}";
    }
}
