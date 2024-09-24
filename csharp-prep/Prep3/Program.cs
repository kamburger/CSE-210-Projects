using System;

class Program
{
    static void Main(string[] args)
    {   Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
      /*  Console.Write("Enter a magic number: ");
        string answer = Console.ReadLine();
        int magicNumber = int.Parse(answer); */
        Console.Write("What is your guess? ");
        string guess = Console.ReadLine();
        int guessNumber = int.Parse(guess);
        while (guessNumber != magicNumber)
            {if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower! ");
                Console.Write("Guess again: ");
                string guessn = Console.ReadLine();
                guessNumber = int.Parse(guessn);
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher! ");
                Console.Write("Guess again: ");
                string guessn = Console.ReadLine();
                guessNumber = int.Parse(guessn);
            }}
            Console.WriteLine("Spot on! You guessed it!");

    }
}