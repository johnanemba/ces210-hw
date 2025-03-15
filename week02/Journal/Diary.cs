using System;
using System.Collections.Generic;
using System.IO;

public class Diary
{
    private List<JournalEntry> entries;

    // Constructor to initialize the diary
    public Diary()
    {
        entries = new List<JournalEntry>();
    }

    // Add a new journal entry
    public void AddJournalEntry(JournalEntry entry)
    {
        entries.Add(entry);
    }

    // Display all entries in the diary
    public void ShowAllEntries()
    {
        foreach (var entry in entries)
        {
            entry.DisplayEntry();
        }
    }

    // Save diary entries to a file
    public void SaveDiaryToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
        Console.WriteLine("Diary successfully saved!");
    }

    // Load diary entries from a file
    public void LoadDiaryFromFile(string filename)
    {
        entries.Clear();
        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 3)
                    {
                        var entry = new JournalEntry(parts[1], parts[2], parts[0]);
                        entries.Add(entry);
                    }
                }
            }
            Console.WriteLine("Diary successfully loaded!");
        }
        catch (Exception)
        {
            Console.WriteLine("Error while loading the diary. Please try again.");
        }
    }
}
