using System;

public class Resume
{
    public string _name;

    //initializ list to a new List 

    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        

        foreach (Job job in _jobs)
        {
            // call the display metho on each job
            job.Display();
        }
    }
}