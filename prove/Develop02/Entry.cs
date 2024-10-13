using System;

public class Entry
{
    // The attributes of an entry are the date, prompt, and responsee to the prompt
    public string _date;
    public string _prompt;
    public string _answer;

    // Displays attributes of an entry on separate lines.
    public void DisplayEntry()
    {
        Console.WriteLine($"{_date}");
        Console.WriteLine($"{_prompt}");
        Console.WriteLine($"{_answer}");
    }
}
