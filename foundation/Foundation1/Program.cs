using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video v1 = new Video
        {
            _title = "First Video",
            _author = "Logan",
            _length = "48 Seconds"

        };
        v1.AddComment(new Comment { _name = "Jack", _text = ": This was awesome" });
        v1.AddComment(new Comment { _name = "Theo", _text = ": Epic Video!" });
        v1.AddComment(new Comment { _name = "James", _text = ": I liked the Ocean!" });
        videos.Add(v1);
        Video v2 = new Video
        {
            _title = "Tidal",
            _author = "John",
            _length = "24 Seconds"

        };
        v2.AddComment(new Comment { _name = "Theo", _text = ": This was awesome" });
        v2.AddComment(new Comment { _name = "Jack", _text = ": I liked the Ocean!" });
        v2.AddComment(new Comment { _name = "James", _text = ": Epic Video!" });
        videos.Add(v2);

        Video v3 = new Video
        {
            _title = "Water",
            _author = "Elijah",
            _length = "60 Seconds"

        };
        v3.AddComment(new Comment { _name = "Theo", _text = ": I liked the Ocean!" });
        v3.AddComment(new Comment { _name = "Jack", _text = ": This was awesome" });
        v3.AddComment(new Comment { _name = "James", _text = ": Epic Video!" });
        videos.Add(v3);

        Video v4 = new Video
        {
            _title = "Ocean",
            _author = "Theo",
            _length = "15 Seconds"

        };
        v4.AddComment(new Comment { _name = "Jack", _text = ": Epic Video!" });
        v4.AddComment(new Comment { _name = "Theo", _text = ": I liked the Ocean!" });
        v4.AddComment(new Comment { _name = "James", _text = ": This was awesome" });
        videos.Add(v4);

        foreach (Video video in videos)
        {
            video.ShowVideoDetails();
            Console.WriteLine();
            Console.WriteLine(video.ShowCommentQuantity());
            Console.WriteLine();

        }
    }
}