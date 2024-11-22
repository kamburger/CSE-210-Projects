using System;

class Program
{
    static void Main(string[] args)
    {
        ChecklistGoal testS = new ChecklistGoal("Call Doctor", "Call Doctor About Blood Test Results", 50, 2, 100);
        testS.DisplayGoal();
        testS.CompleteGoal();
        testS.DisplayGoal();
        testS.CompleteGoal();
        testS.DisplayGoal();
        testS.CompleteGoal();
        testS.DisplayGoal();
        int p = testS.GetPointsEarned();
        Console.WriteLine(p);
    }
}