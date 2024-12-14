using System;

public class OutdoorGathering : Event
{
    private string _weather;
    public OutdoorGathering(string _w, string _t, string _descript, string _d, string _tim, Address _addy) : base(_t, _descript, _d, _tim, _addy)
    {
        _weather = _w;
    }
    public override void FullDetails()
    {
        StandardMessage()
        Console.WriteLine($"{_weather}")
    }
}
