
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Net.Security;
using System.Runtime.CompilerServices;
public abstract class Activity
{
    protected int _countdownTime;
    protected string _mainIntro;

    private bool _stopSpinner;

    public Activity (int countdownTime, string mainIntro)
    {
        _countdownTime = countdownTime;
        _mainIntro = mainIntro; 
        _stopSpinner = false; 
    }

    protected void StartSpinner(int seconds)
    {
        Thread spinnerThread = new Thread(SpinnerAnimation);
        spinnerThread.Start(seconds);
    }



    protected void StopSpinner()
    {
        _stopSpinner = true;
    }

    protected void SpinnerAnimation(object secondsObj)
    {
        int seconds = (int)secondsObj;
        char[] spinner = { '|', '/', '-', '\\' };
        int spinnerIndex = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        while (DateTime.Now < endTime && !_stopSpinner)
        {
            Console.Write(spinner[spinnerIndex]);
            Thread.Sleep(1000);
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
    private static int _activityCount = 0;

    public void StartActivity(int duration)
    {
        _activityCount++; // Increment activity count
        Start(duration); // Call the abstract Start method
    }
    public static int GetActivityCount()
    {
        return _activityCount;
    }
    public abstract string GetDescription(); 
    public virtual void Start (int duration)
    {
        _activityCount++;
    }
    // {
    //     Console.WriteLine("Activity completed.");


    //     // for (int i = duration; i > 0; i--)
    //     // {
    //     //     Console.WriteLine($"Time left: {i} seconds");
    //     //     Thread.Sleep(1000); // pause for 1 second 
    //     // }
    //     // Console.WriteLine("Activity completed.");
    // }
}