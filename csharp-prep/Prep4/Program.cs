using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        Console.WriteLine("Enter a list of number, type 0 when finished.");

        List<int> numbers = new List<int>();

        while (true)

        {

            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number == 0)
                    break;
                
                numbers.Add(number);
            }

            else
            {
                Console.WriteLine("Invalid input");
            }

        }

        foreach (int num in numbers)

        {

            Console.Write(num + " ");

        }
        

    }
}