using System;

public class Reception : Event
{
    private string _rsvpEmail;
    public Reception(string _r, string _t, string _descript, string _d, string _tim, Address _addy) : base(_t, _descript, _d, _tim, _addy)
    {
        _rsvpEmail = _r;
    }
    public override void FullDetails()
    {
        StandardMessage();
        Console.WriteLine($"Please RSVP at {_rsvpEmail}");
    }
}
