using System;

class Program
{
    static void Main(string[] args)
    {
       bool _playing = true; // To create loop for user to do multiple activities
       int _totalCount = 0; //Count of amount of activities the user does
       int _breatheCount = 0; // Count of the amount of time the user does the breathing activity
       int _reflectCount = 0; // Count of the amount of time the user does the reflection activity
       int _listCount = 0; // Count of the amount of time the user does the listing activity

       while (_playing) // Repeats activity choice and activity until 4 is entered
       {
            Console.WriteLine("Type the number of the activity you would like to do:");
            Console.WriteLine("1. Breathing Exercise");
            Console.WriteLine("2. Reflection Activity");                    //Choosing Menu
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            string _input = Console.ReadLine();  // User's choice

            int _activityNumber = int.Parse(_input); // changes user's choice to int for if statement

            if (_activityNumber == 1) // Executes Choice 1: Breathing Activity, adds to corresponding counts
            {
                BreathingActivity Breathing = new BreathingActivity(60);
                Breathing.Breathe();
                _totalCount += 1;                                
                _breatheCount += 1;
            }
            else if (_activityNumber == 2) // Executes Choice 2: Reflection Activity, adds to corresponding counts
            {
                ReflectionActivity Reflection = new ReflectionActivity(60);
                if (Reflection.PromptsCount() == 0)  // We remove the prompt if its been asked so it does not get repeated
                {                                    // So this if statement ensures that if all prompts are used, the program does not crash
                    Console.WriteLine("Oops! We ran out of prompts! Choose a new option");
                }
                else
                {
                    Reflection.Reflect();
                    _totalCount += 1;                           
                    _reflectCount += 1;                   
                }
            }
            else if (_activityNumber == 3) // Executes Choice 3: Listing Activity, adds to corresponding counts
            {
                ListingActivity Listing = new ListingActivity(60);
                if (Listing.PromptsCount() == 0)
                {
                    Console.WriteLine("Oops! We ran out of prompts! Choose a new option");
                }
                else
                {
                    Listing.Listing();
                    _totalCount += 1; 
                    _listCount += 1;                   
                }
            }
            else if (_activityNumber == 4) // Executes Choice 4: Quits activity, lists counts, changes playing to false so the loop ends
            {
                ListingActivity Listing = new ListingActivity(60);
                Listing.Pause(2);                
                Console.WriteLine($"You played the breathing exercise {_breatheCount} times, the reflection activity {_reflectCount} times, and the listing activity {_listCount} times!");
                Console.WriteLine($"This means you played {_totalCount} mindfullness games! Great Work! Come Back Soon!");
                Console.WriteLine("Quitting");
                Listing.Pause(4);
                _playing = false;
            }
            else  // If the user does not enter an int 1-4 this message shows and the menu will be brought up again
            {
                Console.WriteLine("Please Enter a valid number");
            }
       }

    }
}