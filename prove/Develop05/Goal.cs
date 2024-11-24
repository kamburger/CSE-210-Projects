using System;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _pointsWorth;
    private int _pointsEarned = 0;
    private int _goalType; 

    public Goal(string name, string description, int pointsworth, int type)
    {
        _name = name;
        _description = description;
        _pointsWorth = pointsworth;
        _goalType = type;
    }


    public List<string> GetInfo()
    {
        List<string> info = new List<string>{_name, _description};
        return info;
    }


    public int GetPointsWorth()
    {
        return _pointsWorth;
    }


    public int GetPointsEarned()
    {
        return _pointsEarned;
    }


    public void SetPointsEarned(int points)
    {
        _pointsEarned = points;
    }

    public int GetGoalType()
    {
        return _goalType;
    }


    public virtual void DisplayGoal()
    {
    }

    
    public virtual void CompleteGoal()
    {
    }


    public virtual string SaveGoalFormat()
    {
        return $"1|{_name}|{_description}|{_pointsWorth}|{_pointsEarned}";
    }
}
