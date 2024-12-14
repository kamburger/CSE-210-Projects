using System;

public class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(string _talker, int _c, string _t, string _descript, string _d, string _tim, Address _addy) : base(_t, _descript, _d, _tim, _addy)
    {
        _speaker = _talker;
        _capacity = _c;
    }
    public override void FullDetails()
    {
        StandardMessage()
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Room Capacity: {_capacity}")
    }
}
