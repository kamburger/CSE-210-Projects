using System;

class Program
{
    static void Main(string[] args)
    {
       bool _playing = true;
       int _totalCount = 0;
       int _breatheCount = 0;
       int _reflectCount = 0;
       int _listCount = 0;

       while (_playing)
       {
            Console.WriteLine("Type the number of the activity you would like to do:");
            Console.WriteLine("1. Breathing Exercise");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            string _input = Console.ReadLine();

            int _activityNumber = int.Parse(_input);

            if (_activityNumber == 1)
            {
                BreathingActivity Breathing = new BreathingActivity(60);
                Breathing.Breathe();
                _totalCount += 1;
                _breatheCount += 1;
            }
            else if (_activityNumber == 2)
            {
                ReflectionActivity Reflection = new ReflectionActivity(60);
                if (Reflection.PromptsCount() == 0)
                {
                    Console.WriteLine("Oops! We ran out of prompts! Choose a new option");
                }
                else
                {
                    Reflection.Reflect();
                    _totalCount += 1; 
                    _reflectCount += 1;                   
                }
            }
            else if (_activityNumber == 3)
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
            else if (_activityNumber == 4)
            {
                ListingActivity Listing = new ListingActivity(60);
                Listing.Pause(2);                
                Console.WriteLine($"You played the breathing exercise {_breatheCount} times, the reflection activity {_reflectCount} times, and the listing activity {_listCount} times!");
                Console.WriteLine($"This means you played {_totalCount} mindfullness games! Great Work! Come Back Soon!");
                Console.WriteLine("Quitting");
                Listing.Pause(4);
                _playing = false;
            }
            else
            {
                Console.WriteLine("Please Enter a valid number");
            }
       }

    }
}