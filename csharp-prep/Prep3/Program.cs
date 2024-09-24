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
        int guessNumber = int.Parse(guess);
        if (guessNumber > magicNumber)
        {
            Console.WriteLine("Lower! ");
        }
        else if (guessNumber < magicNumber)
        {
            Console.WriteLine("Higher! ");
        }
        else
        {
            Console.WriteLine("Spot on! You guessed it!");
        }
    }
}