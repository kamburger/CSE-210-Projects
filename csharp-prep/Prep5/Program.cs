using System;

class Program
{
    static void Main(string[] args)
    {
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        {
            Console.Write("What is your Username? ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string num = Console.ReadLine();
            int favNumber = int.Parse(num);
            return favNumber;
        }
        static int SquareNumber(int number)
        {
            int squared = number*number;
            return squared;
        }
        static void DisplayResult(string user, int squaredNumber)
        {
            Console.WriteLine($"Hello {user}! The square of your number is {squaredNumber}.");
        }
        static void Main()
        {
            DisplayWelcome();
            string userName = PromptUserName();
            int userNumber = PromptUserNumber();
            int numberSquared = SquareNumber(userNumber);
            DisplayResult(userName, numberSquared);
        }
        Main();
    }
}