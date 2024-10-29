using System;

public class MathAssignment : Assignment

{
    private string _textbookSection;
    private string _problems;
    public MathAssignment(string name, string topic, string section, string problems) : base(name, topic)
    {
        _textbookSection = section;
        _problems = problems; 
    }
    public List<string> GetHomeworkList()
    {
        List<string> homework = new List<string>(){_textbookSection, _problems};
        return homework;
    }
}
