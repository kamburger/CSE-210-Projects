using System;

public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>{"Who are people that you appreciate?", "What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
    private List<string> inputs = new List<string>();

    public ListingActivity(int duration) : base("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration)
    {
    }

    public void Listing()
    {
        BeginningMessage();
        Pause(3);
        Console.WriteLine($"Prepare to begin the Reflection activity in:");
        Countdown(10);
        Console.Write("\b \b");

        Random randomIndex = new Random();
        int index = randomIndex.Next(prompts.Count());
        string _prompt = prompts[index];
        prompts.RemoveAt(index);

        List<string> answers = new List<string>();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());
        DateTime currentTime = DateTime.Now; // get current time, what  will change to evenually stop the loop

        Console.WriteLine("Think about the following prompt for 10 seconds, then list your answers:");
        Console.WriteLine(_prompt);
        Countdown(10);
        Console.Write("\b \b");
        while (currentTime < futureTime)
        {
            Console.WriteLine("List an answer to the prompt above: ");
            string _answer = Console.ReadLine();
            answers.Add(_answer);
            currentTime = DateTime.Now;
        }
        Pause(3);
        int count = answers.Count();
        Console.WriteLine($"You listed {count} things!");
        Pause(3);
        EndMessage();
    }
    public int PromptsCount()
    {
        return prompts.Count();
    }
}
