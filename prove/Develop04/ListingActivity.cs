using System;

public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>{"Who are people that you appreciate?", "What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
    private List<string> inputs = new List<string>();

    // Constructor for listing activity, 
    // for the base constructor inputs the listing activity will always have the same name and description, only duration changes 
    // The lists prompts and inputs we will not be changing so they are not an arguement, also why it doesn't return anything
    public ListingActivity(int duration) : base("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", duration)
    {
    }


    // Listing Activity
    public void Listing()
    {
        BeginningMessage(); // Welcome message
        Pause(3); 
        Console.WriteLine($"Prepare to begin the Reflection activity in:"); //Prepare countdown
        Countdown(10);

        Random randomIndex = new Random(); //Create random object from class
        int index = randomIndex.Next(prompts.Count()); // gets random index from 0 to the amount of total prompts 
        string _prompt = prompts[index]; // picks out prompt that corresponds to the random index
        prompts.RemoveAt(index); // removes prompt so they do not get the same one again in the same round of playing

        List<string> answers = new List<string>(); // List to store answers, to be able to count how many answer inputs

        DateTime startTime = DateTime.Now; // Get current time to add duration to
        DateTime futureTime = startTime.AddSeconds(GetDuration()); // Calculate end time
        DateTime currentTime = DateTime.Now; // get current time, what  will change to evenually stop the loop

        Console.WriteLine("Think about the following prompt for 10 seconds, then list your answers:"); 
        Console.WriteLine(_prompt); // displays random prompt
        Countdown(10);
    
        while (currentTime < futureTime) //Until the current time passes the time we want to stop, continues to prompt user for answers
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

    // Gets how many prompts are in the prompt list to ensure it does not run out 
    public int PromptsCount()
    {
        return prompts.Count();
    }
}
