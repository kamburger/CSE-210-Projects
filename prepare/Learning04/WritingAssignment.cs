using System;

public class WritingAssignment : Assignment
{
    private string _title;
    public WritingAssignment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }
    public string GetWritingInformation()
    {
        string _studentName = GetStudentName();
        return $"{_title} by {_studentName}";
    }
}
