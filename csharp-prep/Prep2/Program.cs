using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("Please enter You grade percentage: ");
        string valueFromUser = Console.ReadLine();

        int grade = int.Parse(valueFromUser);

        string letter = "";

        if ( grade >= 90)
        {
           letter = "A";
        }

        else if ( grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70) 
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }
        Console.WriteLine ($"Your grade is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulation!  You passed the class!");
        }
        else
        {
            Console.Write("Stay focus and you'll get it next time!");
        }
    }
}