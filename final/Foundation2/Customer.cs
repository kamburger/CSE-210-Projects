using System;

public class Customer
{
    // Customer contains name and address class
    private string _name;
    private Address _address;

    // Constructor that takes in all attributes and sets them
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }


    // Getter for name
    public string GetName()
    {
        return _name;
    }


    // Get address in address form from Address class 
    public string GetAddressString()
    {
        return _address.AddressString();
    }

    // Returns bool of if country is USA or Not
    public bool GetUSA()
    {
        string _country = _address.GetCountry();
        bool _usa = false;

        if (_country == "USA")
        {
            _usa = true;
        }
        else
        {
            _usa = false;
        }
        return _usa;
    }
}
