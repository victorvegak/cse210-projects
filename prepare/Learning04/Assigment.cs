public class Assigment
{
    protected string _studentName = "";
    protected string _topic = "";

    
    public Assigment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Provide Getters for our private member variables to acccess later both outside the class as derived class
    public string GetStudentName()
    {
        return _studentName;
    }
    public string GetTopic()
    {
        return _topic;
    }
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }

}