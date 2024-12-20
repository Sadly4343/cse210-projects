using System.Collections.Concurrent;

public class Video
{

    public string _title;

    public string _author;
    public string _length;

    public List<Comment> _comments = new List<Comment>();

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public void ShowComments()
    {
        foreach (Comment comment in _comments)
        {
            comment.GetDisplayText();
        }
    }

    public void ShowVideoDetails()
    {
        Console.WriteLine($"{_title} {_author} {_length}");
        Console.WriteLine();
        ShowComments();
    }

    public string ShowCommentQuantity()
    {
        int count = _comments.Count;
        return $"Total number of comments is {count}";
    }
}