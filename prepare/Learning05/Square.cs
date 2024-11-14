using System;

public class Square : Shape
{
    private double _sideLength;
    public Square(string color, double length) : base(color)
    {
        _sideLength = length;
    }
    public override double GetArea()
    {
        return _sideLength*_sideLength;
    }
}
