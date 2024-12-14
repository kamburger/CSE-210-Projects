using System;

public class Address
{
    // Attributes/parts of an address
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    // Constructor that takes in all attributes and sets them
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = state;
        _country = country;
    }

    //Getter for country
    // Used in Customer Class
    public string GetCountry()
    {
        return _country;
    }


    // Returns string of address in address form \n creates new line
    // Used in Order class for Shipping Label function
    public string AddressString()
    {
        string _address = $"{_street} \n{_city}, {_stateProvince}, {_country}"; 
        return _address;
    }
}
