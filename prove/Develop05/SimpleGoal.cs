using System;

public class SimpleGoal : Goal
{
    private bool _isCompleted; // A simple goal is either completed or not and can only be completed once

    // Constructor for new Goal or uncompleted loaded goal, no new variables that are not in the base class, since it is a new goal _isCompleted it set to false
    public SimpleGoal(string name, string descript, int pointsworth) : base(name, descript, pointsworth, 1)
    {
        _isCompleted = false;
    }

    // Constructor for if a loaded goal is already completed, if this did not exist loading SimpleGoals would assume that all of them are not completed
    public SimpleGoal(string name, string descript, int pointsworth, string t) : base(name, descript, pointsworth, 1)
    {
        _isCompleted = true;
    }


    // Overriden from base class 
    public override void DisplayGoal()
    {
        string name = GetInfo()[0];  // get name and description to print
        string descript = GetInfo()[1];

        if (_isCompleted)
        {
            Console.Write($"[X] {name} ({descript})"); // If it is completed an X to mark it off will display
        }
        else
        {
            Console.Write($"[ ] {name} ({descript})"); // If it is not completed an empty space to eventually put an x will show
        }
    }


    public override void CompleteGoal()
    {
        if (!_isCompleted)  // If the goal has not been completed already
        {
            _isCompleted = true;  //Change the status to completed
            int points = GetPointsWorth(); //Get the amount of points the goal is worth
            SetPointsEarned(points); // And set the amount of points it is worth to the amount of points earned from this goal
        }
        else
        {
            Console.WriteLine(" ERROR: This Goal has already been completed."); // If the goal has been completed they will be told they cannot complete it again
        }
    }


}
