using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> prompts = new List<string>;
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");
        prompts.Add("Did I meet someone new?");
        prompts.Add("How did I serve today?");
        prompts.Add("What was the hardest part of today?");

        Journal myJournal = new Journal();

        Console.WriteLine("Type the number to do the following action:");
        Console.WriteLine("1: Create a new entry");
        Console.WriteLine("2: Display your Journal Entries");
        Console.WriteLine("3: Save your Journal to a text file");
        Console.WriteLine("4: Upload a Journal from a text file");
        Console.WriteLine("5: Extra credit item");
        string action = Console.ReadLine();
        if (action == "1")
        {
            Entry newEntry = new Entry();

            DateTime theCurrentTime = DateTime.Now;
            string dateText = theCurrentTime.ToShortDateString();
            newEntry._date = dateText;

            Random randomIndex = new Random();
            int index = randomIndex.Next(prompts.Count());
            newEntry._prompt = prompts[index];
            Console.WriteLine($"{prompts[index]}");
            string promptAnswer = Console.ReadLine();
            newEntry._answer = promptAnswer;

            myJournal.Add(newEntry);
        }
        else if (action == "2")
        {
            myJournal.DisplayJournal();
        }
    }
}