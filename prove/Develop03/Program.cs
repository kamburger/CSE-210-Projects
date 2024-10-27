using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture defaultScripture = new Scripture();
        defaultScripture.DisplayScripture();
        Console.WriteLine("Press Enter to Hide a Word");
        defaultScripture.RedactScripture();
    }
}