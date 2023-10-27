using System;

class Program
{
    static void Main(string[] args)
    {
        //create a base assigment object 
       Assigment assigment1 = new Assigment("Samuel Bennett", "Multiplication");
    //    assigment1.SetStudentName("Samuel Bennet");
    //    assigment1.SetTopic("Fractions");
       Console.WriteLine(assigment1.GetSummary());

    //now create the derived 
       MathAssigment assigment2 = new MathAssigment("Roberto Rodriguez", "Fraction", "7.3", "8-19");
        //    assigment2.SetTextBookSection("7.3");
        //    assigment2.SetProblem("8-19");
        Console.WriteLine(assigment2.GetSummary());
        Console.WriteLine(assigment2.GetHomeworkList());

        WrittingAssigment assigment3 = new WrittingAssigment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(assigment3.GetSummary());
        Console.WriteLine(assigment3.GetWritingInfo());

    }
}