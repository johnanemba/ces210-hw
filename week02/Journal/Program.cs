using System;

class Program
{
    static void Main()
    {
        // Initialize the diary and prompt generator
        Diary userDiary = new Diary();
        JournalPrompt journalPrompt = new JournalPrompt();

        bool isRunning = true;
        while (isRunning)
        {
            // Display menu options to the user
            Console.WriteLine("\nWelcome to your personal Diary!");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. View all diary entries");
            Console.WriteLine("3. Save diary to a file");
            Console.WriteLine("4. Load diary from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Please choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Write a new diary entry
                    string prompt = journalPrompt.GetRandomPrompt();
                    Console.WriteLine($"Prompt: {prompt}");
                    Console.Write("Write your response: ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToString("yyyy-MM-dd");
                    JournalEntry newEntry = new JournalEntry(prompt, response, date);
                    userDiary.AddJournalEntry(newEntry);
                    break;

                case "2":
                    // View all diary entries
                    userDiary.ShowAllEntries();
                    break;

                case "3":
                    // Save the diary to a file
                    Console.Write("Enter the filename to save your diary: ");
                    string saveFilename = Console.ReadLine();
                    userDiary.SaveDiaryToFile(saveFilename);
                    break;

                case "4":
                    // Load the diary from a file
                    Console.Write("Enter the filename to load your diary: ");
                    string loadFilename = Console.ReadLine();
                    userDiary.LoadDiaryFromFile(loadFilename);
                    break;

                case "5":
                    // Exit the program
                    isRunning = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
