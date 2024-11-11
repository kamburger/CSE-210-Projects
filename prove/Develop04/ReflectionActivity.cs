using System;

public class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>{"Think of a time when you did something truly selfless.","Think of a time when you helped someone in need.","Think of a time when you did something really difficult.","Think of a time when you stood up for someone else.","Think of a time someone helped you."};
    private List<string> followupQs = new List<string>{"Why was this experience meaningful to you?","Have you ever done anything like this before?/Has this happened before?","How did you get started?/How did this start?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};

    public ReflectionActivity(int duration) : base("Reflection", "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", duration)
    {
    }
    public void Reflect()
    {
        BeginningMessage();
        Pause(3);
        Console.WriteLine($"Prepare to begin the Reflection activity in:");
        Countdown(5);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

        DateTime currentTime = DateTime.Now; // get current time, what  will change to evenually stop the loop
        while (currentTime < futureTime)
        {
            Random randomIndex = new Random();
            int index = randomIndex.Next(prompts.Count());
            string _prompt = prompts[index];
            prompts.RemoveAt(index);
            int index2 = randomIndex.Next(followupQs.Count());
            string _question = followupQs[index2];
            followupQs.RemoveAt(index2);

            List<string> answers = new List<string>();

            Console.WriteLine(_prompt);
            Pause(5);
            Console.WriteLine(_question);
            string _answer = Console.ReadLine();
            answers.Add(_answer);
            Pause(3);
            currentTime = DateTime.Now;
        }
        Pause(3);
        EndMessage();
    }
    public int PromptsCount()
    {
        return prompts.Count();
    }
}
