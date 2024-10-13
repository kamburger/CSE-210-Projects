using System;

class Program
{
    static void Main(string[] args)
    {
        // Create list of prompts to pull from for journal entry
        List<string> prompts = new List<string>{"Who was the most interesting person I interacted with today?", 
        "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", 
        "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?",
        "Did I meet someone new?", "How did I serve today?", "What was the hardest part of today?"};

        // Create function for option screen for user
        static string DisplayScreen()
        {
            Console.WriteLine("Type the number to do the following action:");
            Console.WriteLine("1: Create a new entry");
            Console.WriteLine("2: Display your Journal Entries");
            Console.WriteLine("3: Save your Journal to a text file");
            Console.WriteLine("4: Upload a Journal from a text file");
            Console.WriteLine("5: Quit (you will lose progress if not saved)");
            string screen = Console.ReadLine();
            return screen;
        }

        // Create Journal for options 1, 2, and 3
        Journal myJournal = new Journal();

        // Get action they want to use first
        string action = DisplayScreen();

        // Until 5 is entered the display screen will run after each action to get a new action
        while (action != "5")
        {    if (action == "1")
            {
                // Create new entry
                Entry newEntry = new Entry();

                //Get today's date for new entry
                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                newEntry._date = dateText;

                //Get a random prompt, display prompt, save answer and prompt to entry.
                Random randomIndex = new Random();
                int index = randomIndex.Next(prompts.Count());
                newEntry._prompt = prompts[index];
                Console.WriteLine($"{prompts[index]}");
                string promptAnswer = Console.ReadLine();
                newEntry._answer = promptAnswer;

                // Add entry to journal
                myJournal._entries.Add(newEntry);
                // Display Option Screen
                action = DisplayScreen();
            }
            else if (action == "2")
            {
                //Display Journal function
                myJournal.DisplayJournal();
                // Display Option Screen
                action = DisplayScreen();
            }
            else if (action == "3")
            {
                // Save Journal function
                myJournal.SaveJournal();
                // Display Option Screen
                action = DisplayScreen();
            }
            else if (action == "4")
            {
                // Upload Journal Function
                myJournal.UploadJournal();
                // Display new journal 
                myJournal.DisplayJournal();
                // Display Option Screen
                action = DisplayScreen();
            }
            else
            {
                // If they don't enter a number 1-5 this message will display and then the screen will display again
                Console.WriteLine("Not a valid action, please input a number 1-6.");
                action = DisplayScreen();
            }
        }
    }

}