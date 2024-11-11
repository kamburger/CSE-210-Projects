using System;

public class BreathingActivity : Activity
{
    private string _breatheIn = "Breathe In...";
    private string _breatheOut= "Breathe Out...";

    public BreathingActivity(int duration) : base("Breathing", "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", duration)
    {
    }
    public void Breathe()
    {
        BeginningMessage();
        Pause(3);
        Console.WriteLine($"Prepare to begin the Breathing activity in:");
        Countdown(5);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

        DateTime currentTime = DateTime.Now; // get current time, what  will change to evenually stop the loop
        while (currentTime < futureTime)
        {
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
