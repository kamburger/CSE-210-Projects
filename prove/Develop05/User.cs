using System;
using System.IO; 

public class User
{
    private string _userName;
    private int _totalPoints = 0;
    private List<Goal> _goals = new List<Goal>();

    public User(string name, List<Goal> goals)
    {
        _userName = name;
        _goals = goals;
    }

    public User(string name)
    {
        _userName = name;
    }


    public int GetTotalPoints()
    {
        return _totalPoints;
    }


    public void ListGoals()
    {
        Console.WriteLine("Your Goals Are: ");
        int n = 1;
        foreach (Goal g in _goals)
        {
            Console.WriteLine();
            Console.Write($"{n}.");
            g.DisplayGoal();
            n += 1;
        }
    }



    public void CreateGoal()
    {
        Console.WriteLine("What type of goal would you like to create? (Type the cooresponding number)");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        string _num = Console.ReadLine();
        int _number = int.Parse(_num);

        Console.WriteLine("What would you like to name your goal?");
        string _goalName = Console.ReadLine();
        Console.WriteLine("Write a short description of your goal: ");
        string _goalDescript = Console.ReadLine();
        Console.WriteLine("How much is your goal worth?");
        string _worth = Console.ReadLine();
        int _goalWorth = int.Parse(_worth);

        if (_number == 1)
        {
            SimpleGoal g = new SimpleGoal(_goalName, _goalDescript, _goalWorth);
            _goals.Add(g);

            Console.WriteLine("Way to go! You added the Simple goal of :");
            g.DisplayGoal();
        }
        else if (_number == 2)
        {
            EternalGoal g = new EternalGoal(_goalName, _goalDescript, _goalWorth);
            _goals.Add(g);

            Console.WriteLine("Way to go! You added the Eternal goal of :");
            g.DisplayGoal();
        }            
        else if (_number == 3)
        {
            Console.WriteLine("How many times do you have to complete this goal? ");
            string _times = Console.ReadLine();
            int _goalTimes = int.Parse(_times);
            Console.WriteLine("How many points do you get for the final completion?");
            string _fPoints = Console.ReadLine();
            int _goalFpoints = int.Parse(_fPoints);

            ChecklistGoal g = new ChecklistGoal(_goalName, _goalDescript, _goalWorth, _goalTimes, _goalFpoints);
            _goals.Add(g);

            Console.WriteLine("Way to go! You added the Checklist goal of:");
            g.DisplayGoal();
        }
        else
        {
            Console.WriteLine("ERROR: Not a valid option.");
        }
    }



    public void RemoveGoal()
    {
        Console.WriteLine("Which of the following goals would you like to remove from your list? (Enter the corresponding number) ");
        ListGoals();
        string _nummyS = Console.ReadLine();
        int _nummy = int.Parse(_nummyS);
        _nummy -= 1;
        _goals.RemoveAt(_nummy);
    }



    public void RecordEvent()
    {
        Console.WriteLine("Which of the following goals would you like to check off/complete? ");
        ListGoals();
        string _nummyS = Console.ReadLine();
        int _nummy = int.Parse(_nummyS);
        _nummy -= 1;
        _goals[_nummy].CompleteGoal();
        Console.WriteLine("Congrats! You completed: ");
        _goals[_nummy].DisplayGoal();

        foreach (Goal g in _goals)
        {
            int p = g.GetPointsEarned();
            _totalPoints = _totalPoints + p;
        }

        Console.WriteLine($"You now have {_totalPoints} points!");
    }



    public void SaveGoals()
    {
        Console.WriteLine("What would you like the file to be named (no spaces/special characters)? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Goal g in _goals)
            {

                string format = g.SaveGoalFormat();
                outputFile.WriteLine($"{format}");
            }
        }
    }


    public void UploadGoals()
    {
        List<Goal> loadedGoals = new List<Goal>();
        Console.WriteLine("What is the filename you are uploading from?");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
            {

                string[] parts = line.Split("|");
                string name = parts[0];
                string description = parts[1];
                string pw = parts[2];
                int pointsworth = int.Parse(pw);
                string pe = parts[3];
                int pointsEarned = int.Parse(pe);

                if (parts.Count() == 4)
                {
                    if (pointsEarned > 0)
                    {
                        SimpleGoal newGoal = new SimpleGoal(name, description, pointsworth, "true");
                        newGoal.SetPointsEarned(pointsEarned);
                        loadedGoals.Add(newGoal);
                    }
                    else
                    {
                        SimpleGoal newGoal = new SimpleGoal(name, description, pointsworth);
                        newGoal.SetPointsEarned(pointsEarned);
                        loadedGoals.Add(newGoal);
                    }
                }
                else if (parts.Count() == 5)
                {
                    int timesDone = int.Parse(parts[4]);
                    EternalGoal newGoal = new EternalGoal(name, description, pointsworth, timesDone);
                    newGoal.SetPointsEarned(pointsEarned);
                    loadedGoals.Add(newGoal);
                }
                else 
                {
                    int allowedTimes = int.Parse(parts[4]);
                    int finalPoints = int.Parse(parts[5]);
                    int timesDone = int.Parse(parts[6]);
                    ChecklistGoal newGoal = new ChecklistGoal(name, description, pointsworth, allowedTimes, finalPoints, timesDone);
                    newGoal.SetPointsEarned(pointsEarned);
                    loadedGoals.Add(newGoal);
                }

            }
            _goals = loadedGoals;
    }
}
