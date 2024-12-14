using System;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    public Event(string _t, string _descript, string _d, string _tim, Address _addy)
    {
        _title = _t;
        _description = _descript;
        _date = _d;
        _time = _tim;
        _address = _addy;
    }
    public void StandardMessage()
    {
        Console.WriteLine(_title);
        Console.WriteLine(_description);
        Console.WriteLine($"{_date} : {_time}");
        string _a = _address.AddressString();
        Console.WriteLine(_a);
    }
    public virtual void FullDetails()
    {
        
    }        
    
    public void ShortMessage()
    {
        Console.WriteLine($"{_title}");
        Console.WriteLine($"event type  - {_date}");
    }
}
