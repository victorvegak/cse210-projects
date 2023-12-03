
class Comment
{
    private string _commenterName;
    private string _commentText;

    public Comment(string commenterName, string commentText)
    {
        _commenterName = commenterName;
        _commentText = commentText;
    }

    public void DisplayCommentInfo()
    {
        Console.Write($"{_commenterName}: {_commentText}");
        Console.WriteLine();
    
    }
}