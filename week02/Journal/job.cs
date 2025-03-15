using System;

public class Job
{
    // Fields to store the job details
    private string jobTitle;
    private string company;
    private int startYear;
    private int endYear;

    // Constructor to initialize the job details
    public Job(string title, string employer, int start, int end)
    {
        jobTitle = title;
        company = employer;
        startYear = start;
        endYear = end;
    }

    // Method to display job information
    public void ShowJobInfo()
    {
        Console.WriteLine($"{jobTitle} ({company}) {startYear}-{endYear}");
    }
}
