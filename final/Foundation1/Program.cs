using System;

class Program
{
    static void Main()
    {
        // youtube videos
        var video1 = new Video("Wedding Video", "Sadie Parker ", 300);
        var video2 = new Video("Disneyland Must Do!", "Micky Mouse", 600);
        var video3 = new Video("Get Ready with me", "Olivia Jones", 1200);

        // comments on the video 1 
        video1.AddComment(new Comment("Jill", "Such a special day!"));
        video1.AddComment(new Comment("Marc", "Beautiful video."));
        video1.AddComment(new Comment("Dallin", "I have watched this 10 times!"));

         // comments on the video 2
        video2.AddComment(new Comment("Ariel1999", "Going to Disney next week can't wait!"));
        video2.AddComment(new Comment("Mulanlover", "I am not even going to disney but I watched this whole video."));
        video2.AddComment(new Comment("Lisa", "I am excited to try the new cafe on Main Street. "));

          // comments on the video 3
        video3.AddComment(new Comment("Aspen", "I have the same mirror and I love it!"));
        video3.AddComment(new Comment("Morgan", "I have watched your videos since I was 15."));
        video3.AddComment(new Comment("Maddy", "FIRST!"));

        // Store videos in a list
        var videos = new List<Video> { video1, video2, video3 };

        // Display video details
        foreach (var video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.Length} seconds");
            Console.WriteLine($"Number of Comments: {video.GetNumberOfComments()}");

            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"  Comment by {comment.Name}: {comment.Text}");
            }

            Console.WriteLine();
        }
    }
}