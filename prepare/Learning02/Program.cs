using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        //create the first job instance
        Job job1 = new Job();
        // set member variable using the dot notation.
        job1._jobTitle = "Web Developer";
        job1._company = "Paypal";
        job1._startYear = 2022;
        job1._endYear = 2023;
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Technical Support Advisor";
        job2._company = "Apple";
        job2._startYear = 2018;    
        job2._endYear = 2022;

        Resume myResume = new Resume ();
        myResume._name = "Victor Vega";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}