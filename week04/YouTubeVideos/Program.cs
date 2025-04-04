using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Video> videoLibrary = new List<Video>();

        Video vid1 = new Video("Learning C# Basics", "John Anemba", 320);
        vid1.AddComment(new Comment("Alice", "Very well explained!"));
        vid1.AddComment(new Comment("Bob", "I learned a lot, thanks!"));
        vid1.AddComment(new Comment("Charlie", "Keep up the good work!"));
        videoLibrary.Add(vid1);

        Video vid2 = new Video("Understanding OOP", "John Anemba", 480);
        vid2.AddComment(new Comment("Dave", "This made OOP so much clearer!"));
        vid2.AddComment(new Comment("Eva", "Really informative and easy to follow."));
        videoLibrary.Add(vid2);

        Video vid3 = new Video("Exploring Design Patterns", "John Anemba", 700);
        vid3.AddComment(new Comment("Frank", "Awesome breakdown of design patterns!"));
        vid3.AddComment(new Comment("Grace", "Loved the practical examples."));
        vid3.AddComment(new Comment("Hank", "This was exactly what I needed!"));
        videoLibrary.Add(vid3);

        foreach (var video in videoLibrary)
        {
            video.ShowDetails();
        }
    }
}
