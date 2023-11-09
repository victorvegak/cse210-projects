
public class Listing: Activity
{
    private List<string> _prompts;
    private List<string> _responses;

    public Listing() : base(0, "Listing Activity:\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area. ")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "what are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        _responses = new List<string>();
    }

    public override string GetDescription()
    {
        return _mainIntro;
    }
    public override void Start(int duration)
    {
        Console.WriteLine("Start Listing....");
        foreach (string prompt in _prompts)
        {
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("Enter your response: ");
        string response = Console.ReadLine();
        _responses.Add(response);
        Console.Clear();

        // countdown animation 
        for (int i = 5; i> 0; i --)
        {
            Console.WriteLine($"{i} seconds");
            Thread.Sleep(2000);
            Console.Clear();

        }
            
        }
    
        Console.WriteLine("Listing completed.");
        Console.WriteLine($"Number of response entered: {_responses.Count}");
        Console.WriteLine("Well done! ");
        Thread.Sleep(5000);
        Console.Clear();

    }
}