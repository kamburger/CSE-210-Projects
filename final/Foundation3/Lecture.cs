using System;

public class Lecture : Event
{
    // Lecture includes extra attributes of speaker and capacity
    private string _speaker;
    private int _capacity;


    // Constructor that takes in all attributes and uses base class constructor
    public Lecture(string _talker, int _c, string _t, string _descript, string _d, string _tim, Address _addy) : base(_t, _descript, _d, _tim, _addy)
    {
        _speaker = _talker;
        _capacity = _c;
    }


    // Adds speaker and capacity to full details
    public override void FullDetails()
    {
        StandardMessage();
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Room Capacity: {_capacity}");
    }
}
