using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to MadLibs! ");
        Console.Write("Enter an adjective: ");
        string adj1 = Console.ReadLine();
        Console.Write("Enter an animal: ");
        string animal = Console.ReadLine();
        Console.Write("Enter a verb: ");
        string verb1 = Console.ReadLine();
        Console.Write("Enter an exclamation: ");
        string exclaim = Console.ReadLine();
        Console.Write("Enter a verb: ");
        string verb2 = Console.ReadLine();
        Console.Write("Enter a verb: ");
        string verb3 = Console.ReadLine();
        Console.WriteLine("Your story is:");
        Console.WriteLine(@$"The other day I was really in trouble. 
It all started when I saw a very {adj1.ToLower()} {animal.ToLower()} {verb1.ToLower()} down the hallway. 
'{exclaim}!' I yelled. But all I could think to do was to {verb2.ToLower()} over and over. 
Miraculously,that caused it to stop, but not before it tried to {verb3.ToLower()} right in front of my family.");
    }
}

/* print(f'''The other day I was really in trouble. It all started when I saw a very
{adjective1.lower()} {animal.lower()} {verb1.lower()} down the hallway. "{exclaim.upper()}!" I yelled. 
But all I could think to do was to {verb2.lower()} over and over. Miraculously,
that caused it to stop, but not before it tried to {verb3.lower()}
right in front of my family. ''') */