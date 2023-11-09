
public class Reflecting : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public Reflecting () : base (0, "Reflection Activity:\n This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
      
        _prompts = new List<string>
        {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
        };
    }
    public override string GetDescription()
    
    {
        return _mainIntro;
    }
    public override void Start(int duration)
    {
        Console.WriteLine("Start reflecting...");
        SpinnerAnimation(10);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {

        //display random prompt
        string randomPrompt = GetRandomPrompt();
        Console.WriteLine($"--{randomPrompt }--");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        
        // countdown animation
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
        CountdownAnimation(5);
        Console.Clear();

        // ask a random questions
        AskRandomQuestions(duration);
        }
            Console.WriteLine("Well done!!");
        }
        
        private string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }

    private void AskRandomQuestions(int duration)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

    while (DateTime.Now < endTime)
    {
        
            Random random = new Random();
            int index = random.Next(_questions.Count);
            Console.WriteLine($"--{_questions[index]}--");
            SpinnerAnimation(10);
            Console.Clear();

                
            }
            StopSpinner();
            
    }
}


