using System;

public class ChecklistGoal : Goal
{
    private int _timesCompleted = 0;
    private int _allowedTimes;
    private int _finalPoints;

    public ChecklistGoal(string name, string descript, int pointsworth, int timesCompletable, int finalpointvalue) : base(name, descript, pointsworth)
    {
        _allowedTimes = timesCompletable;
        _finalPoints = finalpointvalue;
    }

    public override void DisplayGoal()
    {
        string name = GetInfo()[0];
        string descript = GetInfo()[1];
        if (_timesCompleted <= _allowedTimes)
        {
            Console.WriteLine($"[{_timesCompleted}/{_allowedTimes}] {name} ({descript})");
        }
        else 
        {
            Console.WriteLine($"[{_allowedTimes}/{_allowedTimes}] {name} ({descript})");
        }

    }

    public override void CompleteGoal()
    {
        _timesCompleted += 1;
        if (_timesCompleted < _allowedTimes)
        {
            int points = _timesCompleted*GetPointsWorth();
            SetPointsEarned(points);
            
        }
        else if (_timesCompleted == _allowedTimes)
        {
            int points = (_timesCompleted-1)*GetPointsWorth() + _finalPoints;
            SetPointsEarned(points);
        }
        else
        {
            Console.WriteLine("ERROR: You have already completed this goal the max amount of times.");
        }
    }
}
