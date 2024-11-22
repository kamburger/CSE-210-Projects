using System;

public class SimpleGoal : Goal
{
    private bool _isCompleted = false;

    public SimpleGoal(string name, string descript, int pointsworth) : base(name, descript, pointsworth)
    {
    }

    public override void DisplayGoal()
    {
        string name = GetInfo()[0];
        string descript = GetInfo()[1];

        if (_isCompleted)
        {
            Console.WriteLine($"[X] {name} ({descript})");
        }
        else
        {
            Console.WriteLine($"[ ] {name} ({descript})");
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
