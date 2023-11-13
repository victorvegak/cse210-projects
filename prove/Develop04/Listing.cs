
public class Listing: Activity
 {
    private List<string> _prompts;
    private List<string> _responses;

    public Listing() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
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

    public override void Start(int duration)
    {

        DisplayStartMessage();
        SpinnerAnimation(10);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        
        while (DateTime.Now < endTime)
        {
            // Display a random prompt
            string randomPrompt = GetRandomPrompt();
            Console.WriteLine($">{randomPrompt}");

            // enter response
            while(DateTime.Now < endTime)
            {

                Console.Write("> ");
                string response = Console.ReadLine();
                
        
                if (string.IsNullOrWhiteSpace(response))
                {
                    break;
                }
                _responses.Add(response);
            }
        }  

        Console.WriteLine("Listing completed.");
        Console.WriteLine($"Number of responses entered: {_responses.Count}");
        Thread.Sleep(5000);
        Console.Clear();
        DisplayEndMessage();
        
    
    }
    private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    public override string GetDescription()
    {
        return "Description for Listing activity.";
    }
}