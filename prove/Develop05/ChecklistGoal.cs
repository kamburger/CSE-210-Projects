using System;

public class ChecklistGoal : Goal
{
    private int _allowedTimes; 
    private int _finalPoints;
    private int _timesCompleted = 0;

    public ChecklistGoal(string name, string descript, int pointsworth, int timesCompletable, int finalpointvalue) : base(name, descript, pointsworth, 3)
    {
        _allowedTimes = timesCompletable;
        _finalPoints = finalpointvalue;
    }

    public ChecklistGoal(string name, string descript, int pointsworth, int timesCompletable, int finalpointvalue, int timesCompleted) : base(name, descript, pointsworth, 3)
    {
        _allowedTimes = timesCompletable;
        _finalPoints = finalpointvalue;
        _timesCompleted = timesCompleted;
    }



    public override void DisplayGoal()
    {
        string name = GetInfo()[0];
        string descript = GetInfo()[1];
        if (_timesCompleted <= _allowedTimes)
        {
            Console.Write($"[{_timesCompleted}/{_allowedTimes}] {name} ({descript})");
        }
        else 
        {
            Console.Write($"[{_allowedTimes}/{_allowedTimes}] {name} ({descript})");
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



    public override string SaveGoalFormat()
    {
        string name = GetInfo()[0];
        string description = GetInfo()[1];
        int pointsWorth = GetPointsWorth();
        int pointsEarned = GetPointsEarned();
        return $"{name}|{description}|{pointsWorth}|{pointsEarned}|{_allowedTimes}|{_finalPoints}|{_timesCompleted}";
    }

}
