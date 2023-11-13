
public class Breathing: Activity
 {
    public Breathing() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public override void Start(int duration)
    {
        DisplayStartMessage();
        for (int i = duration; i > 0; i--)
        {
            Console.WriteLine($"Breathe in ... ({i} seconds)");
            Thread.Sleep(1000);
            Console.Clear();
        }

        Console.WriteLine("Now, start breathing out.. ");
        Thread.Sleep(3000);
        for (int i = duration; i > 0; i--)
        {
            Console.WriteLine($"Breath Out ... ({i} seconds)");
            Thread.Sleep(1000);
            Console.Clear();
        }
        
        DisplayEndMessage();
    }
    public override string GetDescription()
    {
        return "Description for Breathing activity.";
    }
}