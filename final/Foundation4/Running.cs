using System;

public class Running : Exercise
{
    // Running tracks distance
    private double _distance;

    // Constructor that takes in all attributes 
    public Running(double _dist, string _day, double _time) : base(_day, _time)
    {
        _distance = _dist;
    }

    // Returns distance
    public override double CalculateDistance()
    {
        return _distance;
    }

    // Uses distance and duration to calculate speed
    public override double CalculateSpeed()
    {
        double _duration = GetDuration();
        return (_distance/_duration)*60;
    }

    // Uses distance and duration to calculate pace
    public override double CalculatePace()
    {
        double _duration = GetDuration();
        return (_duration/_distance);
    }
    
}
