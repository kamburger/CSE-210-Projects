using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a magic number: ");
        string answer = Console.ReadLine();
        int magicNumber = int.Parse(answer);
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int numberGuess = int.Parse(guess);
        
    }
}