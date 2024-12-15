using System;

class Program
{
    static void Main(string[] args)
    {
        // Create running exercise
        Running running = new Running(5, "December 10, 2024", 60);
        // Create cycling exercise
        Cycling cycling = new Cycling(10, "December 13, 2024", 20);
        // Create swimming exercise
        Swimming swimming = new Swimming(40, "December 15, 2024", 30);
        // Put exercises in a list
        List<Exercise> exercise = new List<Exercise>{running, cycling, swimming};
        // For each exercise in the list display the summary
        foreach (Exercise e in exercise)
        {
            e.GetSummary();
        }
    }
}