using System;

class Program
{
    static void Main(string[] args)
    {
        // Create videos
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Captain America", "SuperheroDude", 120);
        video1.Comments.Add(new Comment("Spencer", "Captain America rocks"));
        video1.Comments.Add(new Comment("Carlos", "Iron man is better"));
        video1.Comments.Add(new Comment("Gabe", "This is a comment"));

        Video video2 = new Video("LA Galaxy vs LAFC", "MLS", 180);
        video2.Comments.Add(new Comment("Diego", "Soccer"));
        video2.Comments.Add(new Comment("Daniel", "Yes"));

        Video video3 = new Video("Music Video", "Beats and stuff", 150);
        video3.Comments.Add(new Comment("Jeffery", "Nice Video"));

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        // Display video information and comments
        foreach (Video video in videos)
        {
            Console.WriteLine("Title: " + video._title);
            Console.WriteLine("Author: " + video._author);
            Console.WriteLine("Length: " + video._length + " seconds");
            Console.WriteLine("Number of Comments: " + video.GetNumberOfComments());

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.Comments)
            {
                Console.WriteLine("Username: " + comment._name);
                Console.WriteLine("Comment: " + comment._comment);
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        Console.ReadLine();
    }
}