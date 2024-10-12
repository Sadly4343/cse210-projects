using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");

        Video v1 = new Video
        {
            _title = "today",
            _author = "logan",
            _length = "24"

        };
        v1.AddComment(new Comment { _name = "logan", _text = "yes" });
        v1.ShowVideoDetails();
        Video v2 = new Video
        {
            _title = "today",
            _author = "logan",
            _length = "24"

        };
        v2.AddComment(new Comment { _name = "logan", _text = "yes" });
        v2.ShowVideoDetails();
    }
}