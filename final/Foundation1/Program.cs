using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videos = new List<Video>();

        
        Video video1 = new Video("Running", "Mr.Runner", 312);
        video1.AddComment("Bob", "Great vid!");
         video1.AddComment("Sally", "I learned a lot");
          video1.AddComment("Mike","Nice running");
        videos.Add(video1);

        Video video2 = new Video("Space", "TheAstroMan", 419);
        video2.AddComment("Andrew", "interesting content.");
         video2.AddComment("Ike", "great space content.");
          video2.AddComment("Brad", "Nice galaxyn photos.");
              video2.AddComment("Scott", "Needs more explanation.");
        videos.Add(video2);

        Video video3 = new Video("Ocean", "AquamanResearch", 295);
        video3.AddComment("Drew", "Nice explanation!");
         video3.AddComment("Sam", "Could be more detailed.");
            video3.AddComment("Smith", "great altantis idea!");
        videos.Add(video3);

        // Displaying information for each video
        foreach (Video video in videos)
        {
            Console.WriteLine($"Title: {video.Title}");
            Console.WriteLine($"Author: {video.Author}");
            Console.WriteLine($"Length: {video.LengthSeconds} seconds");
            Console.WriteLine($"Number of comments: {video.GetNumberOfComments()}");

            Console.WriteLine("Comments:");
            foreach (Comment comment in video.GetAllComments())
            {
                Console.WriteLine($"- {comment.CommenterName}: {comment.CommentText}");
            }

            Console.WriteLine();
        }
    }
}
