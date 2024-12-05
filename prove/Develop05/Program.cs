using System;

class Program
{
    static void Main(string[] args)
    {
        bool _playing = true; // To create loop for user to do multiple activities

        Console.WriteLine("Welcome to the Goal Game!");
        Console.WriteLine("What would you like your username to be? ");
        string _userName = Console.ReadLine();
        User player = new User(_userName);

        while (_playing) // Repeats activity choice and activity until 4 is entered
       {
            Console.WriteLine();
            Console.WriteLine("Type the number of the activity you would like to do:");
            Console.WriteLine("1. Create a Goal");
            Console.WriteLine("2. List Your Goals");                    //Choosing Menu
            Console.WriteLine("3. Remove a Goal");
            Console.WriteLine("4. Record an Event");
            Console.WriteLine("5. Save Your Goals");
            Console.WriteLine("6. Upload Your Goals");
            Console.WriteLine("7. Quit");
            string _input = Console.ReadLine();  // User's choice

            int _activityNumber = int.Parse(_input); // changes user's choice to int for if statement

            if (_activityNumber == 1) // Executes Choice 1: 
            {
                player.CreateGoal();
            }
            else if (_activityNumber == 2) // Executes Choice 2: 
            {
                player.ListGoals();
            }
            else if (_activityNumber == 3) // Executes Choice 3: 
            {
                player.RemoveGoal();
            }
            else if (_activityNumber == 4) // Executes Choice 4: 
            {
                player.RecordEvent();
            }
            else if (_activityNumber == 5) // Executes Choice 5:
            {
                player.SaveGoals();
            }
            else if (_activityNumber == 6) // Executes Choice 6: 
            {
                player.UploadGoals();
            }
            else if (_activityNumber == 7) // Executes Choice 7: Quits Game
            {
                Console.WriteLine("Quitting... Keep up the good work!");
                _playing = false;
            }
            else  // If the user does not enter an int 1-6 this message shows and the menu will be brought up again
            {
                Console.WriteLine("Please Enter a valid number");
            }
       }

    }
    
}