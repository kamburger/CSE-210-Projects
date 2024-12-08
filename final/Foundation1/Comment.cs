using System;

public class Comment
{
    // Attributes of a comment: whoo commented and what did they comment
    private string _userName;
    private string _comment;

    // Constructor for Comment takes in username and comment
    public Comment(string name, string comment)
    {
        _userName = name;
        _comment = comment;
    }

    // Display Username: "comment"
    public void DisplayComment()
    {
        Console.WriteLine($"{_userName}: \"{_comment}\"");
    }
}
