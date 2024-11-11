using System;

class Program
{
    static void Main(string[] args)
    {
      //  Activity testActivity = new Activity("test activity", "blah blah blah test activity", 60);
     //   testActivity.BeginningMessage();
     //   testActivity.Pause(5);
     //   testActivity.Countdown(5);
      //  testActivity.EndMessage();
      //  BreathingActivity testBreathing = new BreathingActivity(60);
      //  testBreathing.Breathe();
        ReflectionActivity testReflection = new ReflectionActivity(60);
        testReflection.Reflect();

    }
}