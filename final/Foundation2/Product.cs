using System;

public class Product
{
    // Attributes of a Product: Name, ID Number, Price for 1, how many ordered
    private string _name;
    private int _iDNumber;
    private double _pricePerUnit;
    private int _quantity;

    // Constructor that takes in all attributes and sets them
    public Product(string name, int id, double price, int quantity)
    {
        _name = name;
        _iDNumber = id;
        _pricePerUnit = price;
        _quantity = quantity;
    }


    // Getter for id number, product name, and quantity
    // Used in Order class for Packing Label function
    public string GetProductInfo()
    {
        string _productInfo = $"{_iDNumber}: {_name}   x{_quantity}";
        return _productInfo;
    }


    // Returns total price for amount of one type of product ordered
    // Used in Order Class for Total Price function
    public double TotalCost()
    {
        return _pricePerUnit*_quantity;
    }
}