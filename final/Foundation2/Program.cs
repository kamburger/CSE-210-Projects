using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Products for first order
        Product _squishmallow = new Product("Squishmallow", 38901756, 14.99, 3);
        Product _chocoMilk = new Product("Chocolate Milk", 827495322, 3.89, 1);
        Product _faceMask = new Product("Face Mask", 234987109, 2.89, 4);
        // Put Products in a List
        List<Product> _products1 = new List<Product>{_squishmallow, _chocoMilk, _faceMask};
        // Create Address for Customer
        Address _addKami = new Address("2787 Silver Tree Rd", "Denver", "CO", "USA");
        // Create Customer
        Customer _kami = new Customer("Kami", _addKami);
        // Create Order with Customer and Product List
        Order _order1 = new Order(_kami, _products1);

        // Print all Order Information
        Console.WriteLine("Order 1:");
        _order1.PrintPackingLabel();
        double cost = _order1.TotalPrice();
        Console.WriteLine($"${cost}");
        _order1.PrintShippingLabel();

        // Blank Line to break up orders
        Console.WriteLine();

        // Create Products for secon order
        Product _drpepper = new Product("Dr. Pepper", 6583000, 4.99, 2);
        Product _sweater = new Product("Purple Sweater", 77992384, 19.99, 1);
        Product _pasta = new Product("Elbow Pasta", 4485082, 0.97, 3);
        // Put Products in a List
        List<Product> _products2 = new List<Product>{_drpepper, _sweater, _pasta};
        // Create Address for second Customer
        Address _addLani = new Address("1900 Sand Castle St", "Toronto", "Ontario", "Canada");
        // Create second Customer 
        Customer _lani = new Customer("Lani", _addLani);
        // Create Order with second Customer and Product List
        Order _order2 = new Order(_lani, _products2);

        // Print all Order Information
        Console.WriteLine("Order 2:");
        _order2.PrintPackingLabel();
        double cost2 = _order2.TotalPrice();
        Console.WriteLine($"${cost2}");
        _order2.PrintShippingLabel();
    }
}