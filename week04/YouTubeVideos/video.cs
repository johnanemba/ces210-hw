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

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }

    public void ShowDetails()
    {
        Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nDuration: {Duration} seconds\nTotal Comments: {GetCommentCount()}");
        foreach (var comment in Comments)
        {
            Console.WriteLine($"- {comment.Name}: {comment.Message}");
        }
        Console.WriteLine("====================================");
    }
}
