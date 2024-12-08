using System;

public class Order
{
    // Order has attributes of customer and list of products
    private Customer _customer;
    private List<Product> _products;

    // Constructor that takes in all attributes and sets them
    public Order(Customer c, List<Product> products)
    {
        _customer = c;
        _products = products;
    }


    // Calls GetUSA function for customer
    // If USA is true shippingcost = 5, if not = 35
    // returns shippingcost
    public int ShippingCost()
    {
        int _shippingCost = 0;
        bool _usa = _customer.GetUSA();
        if (_usa)
        {
            _shippingCost = 5;
        }
        else
        {
            _shippingCost = 35;
        }

        return _shippingCost;
    }


    // adds all products total costs and shipping costs
    public double TotalPrice()
    {
        double _totalPrice = 0;
        foreach (Product p in _products)
        {
            _totalPrice = _totalPrice + p.TotalCost();
        }
        int _shipping = ShippingCost();
        _totalPrice = _totalPrice + _shipping;
        return _totalPrice;
    }

    // Prints all products infos
    public void PrintPackingLabel()
    {
        Console.WriteLine("Products Ordered: ");
        foreach (Product p in _products)
        {
            string _info = p.GetProductInfo();
            Console.WriteLine(_info);
        }
    }

    // Prints name of customer and address in address form
    public void PrintShippingLabel()
    {
        string _cName = _customer.GetName();
        string _cAddress = _customer.GetAddressString();
        Console.WriteLine(_cName);
        Console.WriteLine(_cAddress);
    }
}
