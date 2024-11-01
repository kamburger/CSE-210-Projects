using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment test = new Assignment("Samuel Bennett", "Multiplication");
        string _testName = test.GetSummary()[0];
        string _testTopic =  test.GetSummary()[1];
        Console.WriteLine($"{_testName} - {_testTopic}");

        MathAssignment mathtest = new MathAssignment("Roberto Rodriquez", "Fractions", "7.3","8-19");
        string _mathName = mathtest.GetSummary()[0];
        string _mathTopic = mathtest.GetSummary()[1];
        string _sectionTest = mathtest.GetHomeworkList()[0];
        string _problemsTest = mathtest.GetHomeworkList()[1];
        Console.WriteLine($"{_mathName} - {_mathTopic}");
        Console.WriteLine($"Section {_sectionTest}: Problems {_problemsTest}");

        WritingAssignment writingtest = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        string _writingName = writingtest.GetSummary()[0];
        string _writingTopic = writingtest.GetSummary()[1];
        string _writingtitle = writingtest.GetWritingInformation();
        Console.WriteLine($"{_writingName} - {_writingTopic}");
        Console.WriteLine($"{_writingtitle}");
    }

}