using System;

public class Assignment
{
    private string _studentName;
    private string _topic;
    public Assignment(string name, string topic)
    {
        _studentName = name;
        _topic = topic;
    }
    public List<string> GetSummary()
    {
        List<string> summary = new List<string>(){_studentName, _topic};
        return summary;
    }
}
