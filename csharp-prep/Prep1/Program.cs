using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");
        //Ask user for their name.
        Console.WriteLine("What is your first name? ");
        string firstname = Console.ReadLine();
        Console.WriteLine("What is your last name? ");
        string lastname = Console.ReadLine();

        Console.WriteLine($"Your name is {lastname}, {firstname} {lastname}");
    }
}