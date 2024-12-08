using System;

public class Order
{
    private Customer _customer;
    private List<Product> _products;

    public Order(Customer c, List<Product> products)
    {
        _customer = c;
        _products = products;
    }

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


    public void PrintPackingLabel()
    {
        Console.WriteLine("Products Ordered: ");
        foreach (Product p in _products)
        {
            string _info = p.GetProductInfo();
            Console.WriteLine(_info);
        }
    }


    public void PrintShippingLabel()
    {
        string _cName = _customer.GetName();
        string _cAddress = _customer.GetAddressString();
        Console.WriteLine(_cName);
        Console.WriteLine(_cAddress);
    }
}
