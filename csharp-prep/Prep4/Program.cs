using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number;
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        do 
        {
            Console.Write("Enter a number: ");
            string answer = Console.ReadLine();
            number = int.Parse(answer);
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        while (number != 0);
        int sum = 0;
        foreach (int num in numbers)
        {
            sum = sum + num;
        }
        Console.WriteLine($"The sum of the numbers is {sum}");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average of the numbers is {average}");
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The largest number is {max}");
    }

}