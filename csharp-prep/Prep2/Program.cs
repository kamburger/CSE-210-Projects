using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the grade percentage? ");
        string percentage = Console.ReadLine();
        int percent = int.Parse(percentage);
        string letter = "";
        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }
        Console.WriteLine($"You got a/an {letter}");
        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine("You passed the class! ");
        }
        else
        {
            Console.WriteLine("You failed :(");
        }
    }
}