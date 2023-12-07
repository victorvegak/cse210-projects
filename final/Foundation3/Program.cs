using System;
using System.Reflection.PortableExecutable;

class Program
{
    static void Main(string[] args)
    {
        // creating event type
        Address eventAddress = new Address("350 N State St", "Salt Lake City", "UT", "84114") ;

        Lecture lecture = new Lecture("Fundraising Masterclass", "Get ready to level up your fundraising game with our Masterclass that will teach you the secrets to raising more money for your nonprofit.", DateTime.Now, new TimeSpan(2, 20, 0), eventAddress, "Victor Vega", 20);

        Reception reception = new Reception("Wedding Reception", "Wedding Street offers free planning assistance to confirm day of availability and/or set up venue tours", DateTime.Now, new TimeSpan(5, 30, 0), eventAddress, "victor@yahoo.com");

        OutdoorGathering outdoor = new OutdoorGathering("Outdoor Movie Night", "Transform your outdoor space into a cozy cinema with blankets, cushions, and a large screen.", DateTime.Now, new TimeSpan(6, 0, 0), eventAddress, "warm summer breeze");


        //generate marketing messages
        Console.WriteLine();
        Console.WriteLine ("Standard Details:");
        Console.WriteLine();
        Console.WriteLine (lecture.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine (reception.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine (outdoor.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine ("Full Details: ");
        Console.WriteLine();
        Console.WriteLine (lecture.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine (reception.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine (outdoor.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine ("Short Description: ");
        Console.WriteLine();
        Console.WriteLine (lecture.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine (reception.GetShortDescription());
        Console.WriteLine();
        Console.WriteLine (outdoor.GetShortDescription());
        Console.WriteLine();

    }
}