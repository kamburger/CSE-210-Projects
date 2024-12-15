using System;

public class Cycling : Exercise
{
    // Cycling also tracks speed
    private double _speed;

    // Constructor that takes in all attributes 
    public Cycling(double _fast, string _day, double _time) : base(_day, _time)
    {
        _speed = _fast;
    }

    // Uses duration and speed to calculate distance
    public override double CalculateDistance()
    {
        double _duration = GetDuration();
        return (_speed/60)*_duration;
    }

    // Returns speed
    public override double CalculateSpeed()
    {
        return _speed;
    }

    // Calculates pace from speed
    public override double CalculatePace()
    {
        return 60/_speed;
    }
}
