using System;

public class Event
{
    // Attributes of Events they all share: title, description, date and time, and address
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;


    // Constructor to create Event takes in all attributes and sets them
    public Event(string _t, string _descript, string _d, string _tim, Address _addy)
    {
        _title = _t;
        _description = _descript;
        _date = _d;
        _time = _tim;
        _address = _addy;
    }
    

    // Standard Message displays all shared attributes for events
    public void StandardMessage()
    {
        Console.WriteLine(_title);
        Console.WriteLine(_description);
        Console.WriteLine($"{_date} : {_time}");
        string _a = _address.AddressString();
        Console.WriteLine(_a);
    }


    // Will be overriden in kid classes to include extra details specific to that kid
    public virtual void FullDetails()
    {
        StandardMessage();
    }        
    

    // Only displays the title of the event and date
    public virtual void ShortMessage()
    {
        Type _type = GetType();
        Console.WriteLine($"{_title}");
        Console.WriteLine($"Join us for a/an {_type.Name}!");
        Console.WriteLine($"{_date}");
    }

}
