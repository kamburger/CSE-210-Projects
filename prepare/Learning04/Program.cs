using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment test = new Assignment("Samuel Bennett", "Multiplication");
        List<string> testsummary = test.GetSummary();
        string _testName = testsummary[0];
        string _testTopic = testsummary[1];
        Console.WriteLine($"{_testName} - {_testTopic}");
    }
}