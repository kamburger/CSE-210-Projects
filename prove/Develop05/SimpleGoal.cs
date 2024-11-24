using System;

public class SimpleGoal : Goal
{
    private bool _isCompleted;

    public SimpleGoal(string name, string descript, int pointsworth) : base(name, descript, pointsworth, 1)
    {
        _isCompleted = false;
    }

    public SimpleGoal(string name, string descript, int pointsworth, string t) : base(name, descript, pointsworth, 1)
    {
        _isCompleted = true;
    }

    public override void DisplayGoal()
    {
        string name = GetInfo()[0];
        string descript = GetInfo()[1];

        if (_isCompleted)
        {
            Console.Write($"[X] {name} ({descript})");
        }
        else
        {
            Console.Write($"[ ] {name} ({descript})");
        }
    }


    public override void CompleteGoal()
    {
        if (!_isCompleted)
        {
            _isCompleted = true;
            int points = GetPointsWorth();
            SetPointsEarned(points);
        }
        else
        {
            Console.WriteLine(" ERROR: This Goal has already been completed.");
        }
    }


}
