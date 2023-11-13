using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. View activity Count");
            Console.WriteLine("5. Quit");

            Console.Write("Select a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();

            Activity selectedActivity = null;

            switch (choice)
            {
                case 1:
                    selectedActivity = new Breathing();
                    break;

                case 2:
                    selectedActivity = new Reflecting();
                    break;
                case 3:
                    selectedActivity = new Listing();
                    break;
                case 4:
                    Console.WriteLine($"Total Activities Performed: {Activity.GetActivityCount()}");
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option. ");
                    break;
            }
            if (selectedActivity != null)
            {
                StartActivity(selectedActivity);
            }
        }
    }
    static void StartActivity(Activity activity)
    {
        Console.Clear();
        Console.WriteLine(activity.GetDescription());
        Console.Write("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        Console.Clear(); 

        Console.WriteLine("Get Ready...");
        Thread.Sleep(3000);

        activity.Start(duration);
    }
}    