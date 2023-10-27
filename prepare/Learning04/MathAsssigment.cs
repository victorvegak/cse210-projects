using System.Collections.Specialized;

public class MathAssigment : Assigment
{
    private string _textbookSection;
    private string _problems;

    //notice the syntac here that the mathassigment constructor has paramaeters  
    public MathAssigment(string studentName, string topic, string textbooksection, string problems)
        : base(studentName, topic)
    {
        _textbookSection = textbooksection;
        _problems = problems;
    }


    public string  GetHomeworkList()
    {
        return $"Section:{_textbookSection} Problems:{_problems}";
    }

}