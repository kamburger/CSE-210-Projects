using System;

public class Address
{
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = state;
        _country = country;
    }

    public string GetCountry()
    {
        return _country;
    }

    public string AddressString()
    {
        string _address = $"{_street} \n{_city}, {_stateProvince} \n{_country}"; 
        return _address;
    }
}
