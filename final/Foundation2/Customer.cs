using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }


    public string GetName()
    {
        return _name;
    }


    public string GetAddressString()
    {
        return _address.AddressString();
    }

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
