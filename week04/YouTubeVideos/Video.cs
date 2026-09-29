public class Video
{
    private string _title;
    private string _author;
    private int _lengthVideo;
    private List<Comment> _nComments;

    public Video(string title, string author, int lenghtVideo)
    {
        _title = title;
        _author = author;
        _lengthVideo = lenghtVideo;
        _nComments = new List<Comment>();
    }

    public void addComment(Comment comment)
    {
        _nComments.Add(comment);
    }

    public int _displayNumberComments()
    {   
        return _nComments.Count;
    }

    public void displayVideoData()
    {
        Console.WriteLine($"\n{_title}, {_author}, {_lengthVideo}, {_displayNumberComments()}\n");
        foreach (Comment item in _nComments)
        {
            Console.WriteLine($"{item.GetAuthor()}: {item.GetText()}"); 
        }
    }
}