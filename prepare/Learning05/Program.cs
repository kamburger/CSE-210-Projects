using System;

class Program
{
    static void Main(string[] args)
    {
        Square testSquare = new Square("purple", 5.2);
        Rectangle testRectangle = new Rectangle("pink", 3.3, 6.5);
        Circle testCircle = new Circle("blue", 2.7);
        List<Shape> testShapes = new List<Shape>{testSquare, testRectangle, testCircle};
        foreach (Shape s in testShapes)
        {
            string _shapeColor = s.GetColor();
            double _shapeArea = s.GetArea();
            Console.WriteLine($"The {_shapeColor} shape has an area of {_shapeArea}.");
        }
;
    }
}