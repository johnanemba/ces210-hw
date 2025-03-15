using System;

public class JournalEntry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }

    // Constructor to initialize a new journal entry
    public JournalEntry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    // Display the entry to the user
    public void DisplayEntry()
    {
        Console.WriteLine($"{Date}: {Prompt}\nResponse: {Response}\n");
    }
}
