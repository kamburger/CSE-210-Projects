using System;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _pointsWorth;
    private int _pointsEarned = 0;

    public Goal(string name, string description, int pointsworth)
    {
        _name = name;
        _description = description;
        _pointsWorth = pointsworth;
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


    public virtual void DisplayGoal()
    {
    }

    
    public virtual void CompleteGoal()
    {
    }

}
