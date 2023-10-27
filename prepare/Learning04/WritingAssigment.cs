using System.Collections.Specialized;
public class WrittingAssigment: Assigment
{
    private string _title;

    public WrittingAssigment(string studentName, string topic, string title)
    : base(studentName, topic)
    {
        _title = title;
    }


    public string GetWritingInfo()
    {
        // calling the getter here because _studentName is private in the base class
        string studentName = GetStudentName();
        return $"{_title} by {_studentName}";
    }


}