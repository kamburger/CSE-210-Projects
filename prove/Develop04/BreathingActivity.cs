using System;

public class BreathingActivity : Activity
{
    private string _breatheIn = "Breathe In...";
    private string _breatheOut= "Breathe Out...";


    // Constructor for reflection activity, 
    // for the base constructor inputs the reflection activity will always have the same name and description, only duration changes 
    // The lists prompts and inputs we will not be changing so they are not an arguement, also why it doesn't return anything
    public BreathingActivity(int duration) : base("Breathing", "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", duration)
    {
    }


    // Breathing Activity
    public void Breathe()
    {
        BeginningMessage();
        Pause(3);
        Console.WriteLine($"Prepare to begin the Breathing activity in:");
        Countdown(5);
        DateTime startTime = DateTime.Now; // Get current time to add duration to
        DateTime futureTime = startTime.AddSeconds(GetDuration()); // Calculate end time

        DateTime currentTime = DateTime.Now; // get current time, what  will change to evenually stop the loop
        while (currentTime < futureTime) //Until the current time passes the time we want to stop,
        {                                 // switches between saying breathing in for 4 seconds and breathing out for seconds
            Console.Write(_breatheIn);
            Countdown(4);
            Console.WriteLine();
            Console.Write(_breatheOut);
            Countdown(4);
            Console.WriteLine();
            currentTime = DateTime.Now;
        }
        Pause(3);
        EndMessage();
    }
}
