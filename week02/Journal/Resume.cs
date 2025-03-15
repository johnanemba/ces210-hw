using System;
using System.Collections.Generic;

public class Resume
{
    // Fields for storing the person's name and list of jobs
    private string name;
    private List<Job> jobsList;

    // Constructor to initialize the name and job list
    public Resume(string personName)
    {
        name = personName;
        jobsList = new List<Job>();
    }

    // Method to add a job to the resume
    public void AddJob(Job newJob)
    {
        jobsList.Add(newJob);
    }

    // Method to show the entire resume
    public void ShowResume()
    {
        Console.WriteLine($"Name: {name}");
        Console.WriteLine("Work Experience:");
        foreach (var job in jobsList)
        {
            job.ShowJobInfo();
        }
    }
}
