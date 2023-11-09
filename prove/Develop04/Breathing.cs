

public class Breathing: Activity
{

    public Breathing() : base (0, "Breathing.\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }
    public override string GetDescription()
    {
        
        return _mainIntro;
    }
    public override void Start(int duration)
    {
        Console.WriteLine("Start breathing in... ");
        Thread.Sleep(3000);
        for (int i = duration; i > 0; i--)
        {
            Console.WriteLine($"Breathe in ... ({i} seconds)");
            Thread.Sleep(1000); // Pause for 1  second 
            Console.Clear();
        }
        Console.WriteLine("Now, start breathing out.. ");
        Thread.Sleep(3000);
        for (int i = duration; i > 0; i--)
        {

            Console.WriteLine($"Breath Out ... ({i} seconds)");
            Thread.Sleep(1000); // pause for 1 second
            Console.Clear();
        }
        Console.WriteLine("Well done!!!");
        Thread.Sleep(5000);
        Console.Clear();
    }

    
}