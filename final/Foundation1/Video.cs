using System;

public class Video
{
    // Attributes
    private string _title;
    private string _author;
    private double _length;
    private List<Comment> _comments = new List<Comment>();

    // Constructor takes in title, author, video length, and list of comments
    public Video(string title, string author, double length, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = comments;
    }


    // Counts amount of Comments on the video using .Count() function of lists
    public int CountComments()
    {
        return _comments.Count();
    }


    public void DiplayVideoInformation()
    {
        int n = CountComments(); // Count comments to display how many there are
        Console.WriteLine($"Video Title: {_title}"); // Display title
        Console.WriteLine($"Author: {_author}");  // Display author
        Console.WriteLine($"Length: {_length} minutes"); // Display length in minutes
        Console.WriteLine($"Comments ({n}): "); // Comments section header amount of comments in parenthesis
        foreach (Comment c in _comments) // for each comment display the comment
        {
            c.DisplayComment();
        }
        
    }
}
