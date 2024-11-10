using System;

class Program
{
    static void Main(string[] args)
    {
        Activity testActivity = new Activity("test activity", "blah blah blah test activity", 60);
        testActivity.BeginningMessage();
        testActivity.Pause(5);
        testActivity.EndMessage();
    }
}