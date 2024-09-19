using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the grade? ");
        string percentage = Console.ReadLine();
        int percent = int.Parse(percentage);
        if (percent >= 90)
        {
            Console.WriteLine("You got an A");
        }
        else if (percent >= 80)
        {
            Console.WriteLine("You got a B");
        }
        else if (percent >= 70)
        {
            Console.WriteLine("You got a C");
        }
        else if (percent >= 60)
        {
            Console.WriteLine("You got a D");
        }
        else 
        {
            Console.WriteLine("You got an F");
        }
        if (percent >= 70)
        {
            Console.WriteLine("You passed the class! ");
        }
        else
        {
            Console.WriteLine("You failed :(");
        }
    }
}