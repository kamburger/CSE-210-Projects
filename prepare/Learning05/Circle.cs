using System;

public class Circle : Shape
{
    private double _radius;
    public Circle(string color, double r) : base(color)
    {
        _radius = r;
    }
    public override double GetArea()
    {
        return 3.14159*_radius*_radius;
    }
}
