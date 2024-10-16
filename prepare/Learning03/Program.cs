using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction test1 = new Fraction();
        Fraction test2 = new Fraction(6);
        Fraction test3 = new Fraction(6, 7);
        Console.WriteLine($"{test1._top}{test1._bottom}")
        Console.WriteLine($"{test2._top}{test2._bottom}")
        Console.WriteLine($"{test3._top}{test3._bottom}")
    }
}