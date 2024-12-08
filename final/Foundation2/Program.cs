using System;

class Program
{
    static void Main(string[] args)
    {
        Product testP = new Product("Squishmallow", 38901756, 14.99, 3);
        Product testP2 = new Product("Chocolate Milk", 827495322, 3.89, 1);
        List<Product> testProducts = new List<Product>{testP, testP2};

        Address testA = new Address("9850 Silver Maple Rd", "Highlands Ranch", "CO", "USA");
        
        Customer testC = new Customer("Kami", testA);

        Order testO = new Order(testC, testProducts);

        testO.PrintPackingLabel();
        testO.PrintShippingLabel();
        double cost = testO.TotalPrice();
        Console.WriteLine(cost);
       
    }
}