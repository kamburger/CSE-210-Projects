using System;

public class Reception : Event
{
    // Reception includes extra attribute of rsvp
    private string _rsvpEmail;


    // Constructor that takes in all attributes and uses base class constructor
    public Reception(string _r, string _t, string _descript, string _d, string _tim, Address _addy) : base(_t, _descript, _d, _tim, _addy)
    {
        _rsvpEmail = _r;
    }


    // Adds rsvp to full details
    public override void FullDetails()
    {
        StandardMessage();
        Console.WriteLine($"Please RSVP at {_rsvpEmail}");
        Console.WriteLine();
    }

}
