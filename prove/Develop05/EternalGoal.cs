using System;

public class EternalGoal : Goal
{
    private int _timesCompleted = 0;

    public EternalGoal(string name, string descript, int pointsworth) : base(name, descript, pointsworth)
    {
    }

    public override void DisplayGoal()
    {
        string name = GetInfo()[0];
        string descript = GetInfo()[1];

        if (_timesCompleted == 0)
        {
            Console.WriteLine($"[ ] {name} ({descript})");
        }
        else
        {
            Console.WriteLine($"[X] {name} ({descript}) ---Completed {_timesCompleted} times!");
        }
    }


    public override void CompleteGoal()
    {
        _timesCompleted += 1;
        int points = _timesCompleted*GetPointsWorth();
        SetPointsEarned(points);
    }
}
