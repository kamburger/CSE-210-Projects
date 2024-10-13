using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> prompts = new List<string>{"Who was the most interesting person I interacted with today?", 
        "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", 
        "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?",
        "Did I meet someone new?", "How did I serve today?", "What was the hardest part of today?"};

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

        Journal myJournal = new Journal();

        string action = DisplayScreen();

        while (action != "5")
        {    if (action == "1")
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

                myJournal._entries.Add(newEntry);
                action = DisplayScreen();
            }
            else if (action == "2")
            {
                myJournal.DisplayJournal();
                action = DisplayScreen();
            }
            else if (action == "3")
            {
                myJournal.SaveJournal();
                action = DisplayScreen();
            }
            else if (action == "4")
            {
                myJournal.UploadJournal();
                myJournal.DisplayJournal();
                action = DisplayScreen();
            }
            else
            {
                Console.WriteLine("Not a valid action, please input a number 1-6.");
                action = DisplayScreen();
            }
        }
    }

}