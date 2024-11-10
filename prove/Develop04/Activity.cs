using System;

public class Activity
{
    private string _activityName;
    private string _description;
    private int _duration;
    public Activity(string name, string description, int duration)
    {
        _activityName = name;
        _description = description;
        _duration = duration;
    }
    public List<string> GetActivityInfo()
    {
        List<string> activityInfo = new List<string>(){ _activityName, _description};
        return activityInfo;
    }
    public void BeginningMessage()
    {
        Console.WriteLine($"This {_activityName} activity will help you {_description}");
        Console.WriteLine($"How many seconds would you like to complete this activity?");
        string _time = Console.ReadLine();
        _duration = int.Parse(_time);
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void EndMessage()
    {
        Console.WriteLine($"Great Work!  Thank you for completing the {_activityName} activity!");
        Pause(3);
        Console.WriteLine();
        Console.WriteLine($"Congradulations on completing {_duration} seconds of mindfullness!");
        Pause(3);
        Console.WriteLine();
        Console.WriteLine("Come back soon!");
        Pause(3);
        Console.WriteLine();
        Console.WriteLine("Goodbye!");
        Pause(5);
    }
    public void Pause(int _pauseTime)
    {
        int _miliseconds = _pauseTime*1000;

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_pauseTime);

        DateTime currentTime = DateTime.Now; // get current time, what  will change to evenually stop the loop

        while (currentTime < futureTime)
        {
            Console.Write(".");  // print beginning of spinner
            Thread.Sleep(300);
            Console.Write("."); // Erase the - character
            Thread.Sleep(300);
            Console.Write("."); // Erase the - character 
            Thread.Sleep(300);  
            Console.Write("\b \b"); // Erase the - character
            Thread.Sleep(300); 
            Console.Write("\b \b");
            Thread.Sleep(300); 
            Console.Write("\b \b");
            Thread.Sleep(300); 
            currentTime = DateTime.Now;
        }

    }


}
