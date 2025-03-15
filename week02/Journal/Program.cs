using System;

class Program
{
    static void Main()
    {
        // Creating job instances with specific details
        Job firstJob = new Job("Software Engineer", "Microsoft", 2019, 2022);
        Job secondJob = new Job("Manager", "Apple", 2022, 2023);

        // Display individual job info
        firstJob.ShowJobInfo();
        secondJob.ShowJobInfo();

        // Creating a resume for the person
        Resume myResume = new Resume("Allison Rose");

        // Adding jobs to the resume
        myResume.AddJob(firstJob);
        myResume.AddJob(secondJob);

        // Display the full resume
        myResume.ShowResume();
    }
    
    class Job
    {
        public string JobTitle { get; set; }
        public string Company { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
    
        public Job(string jobTitle, string company, int startYear, int endYear)
        {
            JobTitle = jobTitle;
            Company = company;
            StartYear = startYear;
            EndYear = endYear;
        }
    
        public void ShowJobInfo()
        {
            Console.WriteLine($"{JobTitle} at {Company} from {StartYear} to {EndYear}");
        }
    }
    
    class Resume
    {
        public string Name { get; set; }
        private List<Job> Jobs { get; set; } = new List<Job>();
    
        public Resume(string name)
        {
            Name = name;
        }
    
        public void AddJob(Job job)
        {
            Jobs.Add(job);
        }
    
        public void ShowResume()
        {
            Console.WriteLine($"Resume of {Name}");
            foreach (var job in Jobs)
            {
                job.ShowJobInfo();
            }
        }
    }
}
