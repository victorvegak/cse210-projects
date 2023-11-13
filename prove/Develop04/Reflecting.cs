

public class Reflecting : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public Reflecting() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
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

    public override void Start(int duration)
    {
        DisplayStartMessage();
        SpinnerAnimation(10);

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(duration);

        while (DateTime.Now < endTime)
        {
            // Display random prompt
            string randomPrompt = GetRandomPrompt();
            Console.WriteLine($"--{randomPrompt}--");
            Console.WriteLine("When you have something in mind, press enter to continue.");
            Console.ReadLine();

        // Countdown animation
            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
            CountdownAnimation(5);
            Console.Clear();

        // Ask random questions
            AskRandomQuestions(duration);

            DisplayEndMessage();
        }
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
            Console.Clear();
            Random random = new Random();

            for (int i = 0; i <3; i++)
            {
            int index = random.Next(_questions.Count);
            Console.Write($"--{_questions[index]}--");
            SpinnerAnimation(duration);
            Console.Clear();
            }
        }
    }
    public override string GetDescription()
    {
        return "Description for Reflecting activity.";
    }
}

