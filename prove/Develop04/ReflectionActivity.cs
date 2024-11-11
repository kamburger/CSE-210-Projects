using System;

public class ReflectionActivity : Activity
{
    // List of prompts and questions for specific activity
    private List<string> prompts = new List<string>{"Think of a time when you did something truly selfless.","Think of a time when you helped someone in need.","Think of a time when you did something really difficult.","Think of a time when you stood up for someone else.","Think of a time someone helped you."};
    private List<string> followupQs = new List<string>{"Why was this experience meaningful to you?","Have you ever done anything like this before?/Has this happened before?","How did you get started?/How did this start?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};

    // Constructor for reflection activity, 
    // for the base constructor inputs the reflection activity will always have the same name and description, only duration changes 
    // The lists prompts and inputs we will not be changing so they are not an arguement, also why it doesn't return anything
    public ReflectionActivity(int duration) : base("Reflection", "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", duration)
    {
    }


    // Relfection Activity
    public void Reflect()
    {
        BeginningMessage();
        Pause(3);
        Console.WriteLine($"Prepare to begin the Reflection activity in:");
        Countdown(5);
        DateTime startTime = DateTime.Now; // Get current time to add duration to
        DateTime futureTime = startTime.AddSeconds(GetDuration()); // Calculate end time
        DateTime currentTime = DateTime.Now; // get current time, what  will change to evenually stop the loop

        while (currentTime < futureTime)  //Until the current time passes the time we want to stop, gives a random prompt and lets the user answer
        {
            if (PromptsCount() == 0) // We remove the prompt if its been asked so it does not get repeated
            {                           // So this if statement ensures that if all prompts are used, the program does not crash
                Console.WriteLine("Oops! We ran out of prompts! Wait to choose a new option");
                currentTime = futureTime;
            }
            else
            {
                Random randomIndex = new Random(); // creates instance of random class
                int index = randomIndex.Next(prompts.Count()); // picks random index from count of prompts
                string _prompt = prompts[index]; // gets prompt according to random index
                prompts.RemoveAt(index); // removes prompt so that the user does not get the same one in a row
                int index2 = randomIndex.Next(followupQs.Count()); // picks random index from count of questions
                string _question = followupQs[index2]; // get question from random index
                
                List<string> answers = new List<string>();

                Console.WriteLine(_prompt);
                Pause(5);
                Console.WriteLine(_question); //prints prompt, pauses for thinking time, gives question allows for response
                string _answer = Console.ReadLine();
                answers.Add(_answer);
                Pause(3);
                currentTime = DateTime.Now;
            }
        }
        Pause(3);
        EndMessage();
    }


       // Gets how many prompts are in the prompt list to ensure it does not run out
    public int PromptsCount()
    {
        return prompts.Count();
    }
}
