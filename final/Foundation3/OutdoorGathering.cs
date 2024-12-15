using System;

public class OutdoorGathering : Event
{
    // Outdoor Gathering includes extra attribute of a weather statement
    private string _weather;


    // Constructor that takes in all attributes and uses base class constructor
    public OutdoorGathering(string _w, string _t, string _descript, string _d, string _tim, Address _addy) : base(_t, _descript, _d, _tim, _addy)
    {
        _weather = _w;
    }


    // Adds weather statement to full details
    public override void FullDetails()
    {
        StandardMessage();
        Console.WriteLine($"{_weather}");

    }
}
