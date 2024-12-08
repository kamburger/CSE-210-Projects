using System;

class Program
{
    static void Main(string[] args)
    {
        Product testP = new Product("Squishmallow", 38901756, 14.99, 3);
        string p = testP.GetProductInfo();
        Console.WriteLine(p);
        double p2 = testP.TotalCost();
        Console.WriteLine(p2);

        Address testA = new Address("9850 Silver Maple Rd", "Highlands Ranch", "CO", "USA");
        string a = testA.AddressString();
        Console.WriteLine(a);
    }
}