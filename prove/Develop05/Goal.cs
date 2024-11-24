using System;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _pointsWorth;
    private int _pointsEarned = 0; //All new goals start with points being 0, should probably change this to a construct, can us the setter function to change after creating a goal
    private int _goalType; //Needed/Easy way to be able to tell what type a goal is when uploading from a document. 
                            // = 1 for SimpleGoal, 2 for EternalGoal, and 3 for ChecklistGoal



    // Constructor to create a new goat with arguments to set the name, descritpion, pointsworth, and goaltype
    public Goal(string name, string description, int pointsworth, int type)
    {
        _name = name;
        _description = description;
        _pointsWorth = pointsworth;
        _goalType = type;
    }

    
    // Getter for name and description, there is never an instance that you need one of them but not the other, so I put them in one
    // Returns list of strings with name being the zeroth index, description being the first index
    public List<string> GetInfo()
    {
        List<string> info = new List<string>{_name, _description};
        return info;
    }


    // Getter for the amount of points a goal is worth
    // returns int
    public int GetPointsWorth()
    {
        return _pointsWorth;
    }


    //Getter for the amount of points earned from the goal
    // returns int
    public int GetPointsEarned()
    {
        return _pointsEarned;
    }


    // Setter for the amount of points earned, used in the CompleteGoal() function
    public void SetPointsEarned(int points)
    {
        _pointsEarned = points;
    }


    // Getter for the type of Goal used in saving and loading goals
    // returns, 1, 2, or 3
    public int GetGoalType()
    {
        return _goalType;
    }


    // Abstract function to display the goal, overriden in children, depends on what child class it is used in
    public virtual void DisplayGoal()
    {
    }

    // Abstract function to completing the goal, overriden in children, depends on what child class it is used in
    // Will change pointsearned 
    public virtual void CompleteGoal()
    {
    }


    // Used for Saving the Goal to goal, abstract because EternalGoals and ChecklistGoals will need to save more variables
    // Will not be overriden in SimpleGoal, why there is a 1 in the beginning for SimpleGoal type
    public virtual string SaveGoalFormat()
    {
        return $"1|{_name}|{_description}|{_pointsWorth}|{_pointsEarned}";
    }
}
