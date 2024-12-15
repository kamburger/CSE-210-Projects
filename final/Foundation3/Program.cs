using System;
using System.Diagnostics.SymbolStore;

class Program
{
    static void Main(string[] args)
    {
       // Create address for reception
       Address gradAddress = new Address("1900 Sand Castle St", "Rexburg", "Idaho", "USA");
       // Create reception
       Reception reception = new Reception("taylorkamigrad@gmail.com","Kami's Grad Party","Come celebrate Kami graduating from BYUI!", "December 19, 2024", "2 pm", gradAddress);
       // Display each message type
       reception.StandardMessage();
       Console.WriteLine();
       reception.FullDetails();
       Console.WriteLine();
       reception.ShortMessage();
       Console.WriteLine();
       
       
       // Create address for lecture
       Address lectureAddress = new Address("2388 EastHigh Blvd","Idaho Falls", "Idaho", "USA");
       // Create lecture
       Lecture lecture = new Lecture("Wendy Wilson", 625, "How to Overcome Social Media Addiction", "Learn the dangers of social media and how to prevent them from affecting you","January 23, 2025","7:00 pm", lectureAddress);
       // Display each message type
       lecture.StandardMessage();
       Console.WriteLine();
       lecture.FullDetails();
       Console.WriteLine();
       lecture.ShortMessage();
       Console.WriteLine();


       // Create address for outdoorGathering
       Address outdoorAddress = new Address("8686 Birchwood Drive", "Ririe", "Idaho", "USA");
       // Create outdoorGathering
       OutdoorGathering outdoorGathering = new OutdoorGathering("Bring a light jacket, high 60s is expected","Environmental Society Activity", "Come learn about sustainable gardening and farming practices!", "May 24, 2025", "10:00 am", outdoorAddress);
       // Display each message type
       outdoorGathering.StandardMessage();
       Console.WriteLine();
       outdoorGathering.FullDetails();
       Console.WriteLine();
       outdoorGathering.ShortMessage();
       Console.WriteLine();

    }
}