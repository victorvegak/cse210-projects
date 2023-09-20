using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Console.WriteLine("Welcome to the word guessing game!");


      // part 1/2  Console.WriteLine("What is the magic number? ");
       // int magicNumber = int.Parse(Console.ReadLine());
       // Console.WriteLine("What is your guess? ");

       Random randomGenerator = new Random();
       int magicNumber = randomGenerator.Next(1, 101);

       int guess = -1;

       while (guess != magicNumber)
       {
        Console.Write("What is your guess? ");
        guess = int.Parse(Console.ReadLine());

        if (magicNumber > guess)
        {
            Console.WriteLine ("Higher");
        }
        else if (magicNumber < guess)
        {
            Console.WriteLine ("Lower");
        }
        else
        {
            Console.WriteLine("You Guessed it!");
        }
       }

    }
}