using System;

public class Swimming : Exercise
{
    // Swimming tracks laps
    private int _laps;

    // Constructor that takes in all attributes 
    public Swimming(int _lap, string _day, double _time) : base(_day, _time)
    {
        _laps = _lap;
    }

    // Calculates distance from laps in formula given
    public override double CalculateDistance()
    {
        return _laps* 50 / 1000 *0.62;
    }

    // Calculates speed from duration and distance
    public override double CalculateSpeed()
    {
        double _duration = GetDuration();
        double _distance = CalculateDistance();
        return (_distance/_duration)*60;
    }

    // Calculates pace from speed
    public override double CalculatePace()
    {
        double _speed = CalculateSpeed();
        return 60/_speed;
    }
}
