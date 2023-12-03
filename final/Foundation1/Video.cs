
using System.ComponentModel.DataAnnotations;
using System.Reflection;

class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> _comments = new List<Comment> ();
    public Video(string title, string author, int lengthInSeconds)
    {
        _title =  title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comment>();

    }

    public void AddComment (Comment comments)
    {
        _comments.Add(comments);
    }
    
    public int GetNumberOfComments ()
    {
        return _comments.Count;
    }

    public void DisplayVideoInfo ()
    {
        Console.WriteLine();
        Console.WriteLine($"Title: {_title}, "+
        $"Author: {_author}, Length: {_lengthInSeconds}, Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine($"Comments: ");

        foreach (var comments in _comments)
        {
            comments.DisplayCommentInfo();
        }
    }

}

