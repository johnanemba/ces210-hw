using System;
using System.Collections.Generic;

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Duration { get; set; } // Duration in seconds
    private List<Comment> Comments { get; set; }

    public Video(string title, string author, int duration)
    {
        Title = title;
        Author = author;
        Duration = duration;
        Comments = new List<Comment>();
    }
    
    public class Comment
    {
        public string Author { get; set; }
        public string Text { get; set; }
    
        public Comment(string author, string text)
        {
            Author = author;
            Text = text;
        }
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Duration: {Duration} seconds");
        Console.WriteLine("Comments:");
        foreach (var comment in Comments)
        {
            Console.WriteLine($"- {comment.Author}: {comment.Text}");
        }
        Console.WriteLine();
    }
}