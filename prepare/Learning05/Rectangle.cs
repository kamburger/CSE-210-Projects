using System;

public class Rectangle : Shape
{
    private double _length;
    private double _width;
    public Rectangle(string color, double l, double w) : base(color)
    {
        _length = l;
        _width = w;
    }
    public override double GetArea()
    {
        return _length*_width;
    }
}
