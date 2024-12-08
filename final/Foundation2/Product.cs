using System;

public class Product
{
    // Attributes of a Product: Name, ID Number, Price for 1, how many ordered
    private string _name;
    private int _iDNumber;
    private double _pricePerUnit;
    private int _quantity;

    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _iDNumber = id;
        _pricePerUnit = price;
        _quantity = quantity;
    }

    public string GetProductInfo()
    {
        string _productInfo = $"{_iDNumber}: {_name}   x{_quantity}";
        return _productInfo;
    }

    public double TotalCost()
    {
        return _pricePerUnit*_quantity;
    }
}