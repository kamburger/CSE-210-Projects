using System;
using System.Diagnostics.SymbolStore;

class Program
{
    static void Main(string[] args)
    {
       Address _addLani = new Address("1900 Sand Castle St", "Toronto", "Ontario", "Canada");
       Reception _test = new Reception("taylorkamigrad@gmail.com","Grad Party","Come celebrate Kami graduating from BYUI!", "December 19, 2024", "2 pm", _addLani);
       _test.FullDetails();
        
    }
}