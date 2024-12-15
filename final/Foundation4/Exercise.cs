using System;

public abstract class Exercise
{
    // Attributes that all exercises share: date done on and time spent
    private string _date;
    private double _duration;

    // Constructor that takes in date and time and sets them
    public Exercise(string _day, double _time)
    {
        _date = _day;
        _duration = _time;
    }

    // Getter for duration to use in overriden calculation functions
    public double GetDuration()
    {
        return _duration;
    }

    // Abstract calculations for distance, speed, and pace
    public abstract double CalculateDistance();

    public abstract double CalculateSpeed();

    public abstract double CalculatePace();

    // Displays date, type of exercise, duration, distance, speed, and pace (after calculating them)
    public void GetSummary()
    {
        Type _type = GetType();
        double _pace = CalculatePace();
        double _speed = CalculateSpeed();
        double _distance = CalculateDistance();
        
        Console.WriteLine($"{_date}: {_type.Name} ({_duration} minutes): Distance: {_distance} miles, Speed: {_speed} miles per hour, Pace: {_pace} minutes per mile.");

    }
}
