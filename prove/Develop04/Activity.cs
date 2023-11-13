

using System;
using System.Collections.Generic;
using System.Threading;

public abstract class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;
    protected static int _activityCount = 0;

    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    }

    public static int GetActivityCount()
    {
        return _activityCount;
    }
    protected void IncrementActivityCount()
    {
        _activityCount++;
    }

    protected void DisplayStartMessage()
    {
        Console.WriteLine($"Start {_activityName}...");
        Thread.Sleep(3000);
    }

    protected void DisplayEndMessage()
    {
        Console.WriteLine($"Well done {_activityName}!!!");
        Thread.Sleep(5000);
        Console.Clear();
        _activityCount++;
    }

    protected void SpinnerAnimation(int seconds)
    {
        char[] spinner = { '|', '/', '-', '\\' };
        int spinnerIndex = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[spinnerIndex]);
            Thread.Sleep(500);
            Console.Write("\b");
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
        }
    }

    protected void CountdownAnimation(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write($"{(endTime - DateTime.Now).Seconds} seconds");
            Thread.Sleep(1000);
            Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b");
        }
    }

    public abstract string GetDescription();

    public abstract void Start(int duration);
}
