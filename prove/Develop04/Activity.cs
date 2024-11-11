using System;

public class Activity
{
    // Each activity has the characteristics of a name, description, and duration in common
    private string _activityName;
    private string _description;
    private int _duration;


    // Constructor to set variables when creating new Activity
    public Activity(string name, string description, int duration)
    {
        _activityName = name;
        _description = description;
        _duration = duration;
    }


    // Getter for Duration
    // The only variable we need to be able to access in the children classes is the duration
    public int GetDuration()
    {
        return _duration;
    }


    // Uses the name and description to print a beginning message
    // Includes a setter for duration from use input
    public void BeginningMessage()
    {
        Console.WriteLine($"This {_activityName} activity will help you {_description}");
        Console.WriteLine($"How many seconds would you like to complete this activity?");
        string _time = Console.ReadLine();
        _duration = int.Parse(_time);
    }


    // The same end message at the end of each activity, with pauses inbetween each message
    public void EndMessage()
    {
        Console.WriteLine();
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


    // Pauses console for input amount of time, play ... appearing and disappearing while sleeping 
    // Not exact input time unless it is a multiple of 1800 milisecond (length of animation)
    public void Pause(int _pauseTime)
    {

        DateTime startTime = DateTime.Now; // current time to add time to
        DateTime futureTime = startTime.AddSeconds(_pauseTime); // time we want to stop the pause

        DateTime currentTime = DateTime.Now; // get current time, what  will change to evenually stop the loop

        while (currentTime < futureTime) //Until the current time passes the time we want to stop
        {
            Console.Write(".");  // print first '.'
            Thread.Sleep(300); // slow down animation
            Console.Write("."); // print second '.'
            Thread.Sleep(300); // keep animation at the same pace
            Console.Write("."); // final '.'
            Thread.Sleep(300);  // keep animation at the same pace
            Console.Write("\b \b"); // Erase the last '.'
            Thread.Sleep(300);  // keep animation at the same pace
            Console.Write("\b \b"); // Erase the second '.'
            Thread.Sleep(300);  // keep animation at the same pace
            Console.Write("\b \b"); //Erase final '.'
            Thread.Sleep(300); // keep animation at the same pace
            currentTime = DateTime.Now; // Check time to continue loop or stop
        }
    }


    //Similar to pause but instead counts down my ones instead of an animation
    public void Countdown(int _countdownFrom)
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_countdownFrom);

        DateTime currentTime = DateTime.Now; // get current time, what  will change to evenually stop the loop

        while (currentTime < futureTime) //Until the current time passes the time we want to stop
        {                                   // print integer, integer-1,... every 1 second
            Console.Write(_countdownFrom); // print integer
            Thread.Sleep(1000);         // sleep for one second in between integers
            Console.Write("\b \b");    // clear integer
            if (_countdownFrom >= 10) // Need an extra clear if counting down from 10 or more
            {
                Console.Write("\b \b"); // Assumming someone will not countdown from a 3 digit integer
            }
            _countdownFrom = _countdownFrom - 1;  // minus one to integer for next print
            currentTime = DateTime.Now; // Check time to continue loop or stop

        }
    }
   

}
