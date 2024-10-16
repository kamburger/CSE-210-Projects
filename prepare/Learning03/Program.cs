using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction test1 = new Fraction();
        Fraction test2 = new Fraction(6);
        Fraction test3 = new Fraction(6, 7);
        Console.WriteLine(test1.GetDecimalValue());
        Console.WriteLine(test1.GetFractionString());
        Console.WriteLine(test2.GetDecimalValue());
        Console.WriteLine(test2.GetFractionString());
        Console.WriteLine(test3.GetDecimalValue());
        Console.WriteLine(test3.GetFractionString());
        test2.SetTop(5);
        test2.SetBottom(9);
        Console.WriteLine(test2.GetDecimalValue());
        Console.WriteLine(test2.GetFractionString());
        Console.WriteLine(test2.GetTop());
        Console.WriteLine(test2.GetBottom());

    }
}