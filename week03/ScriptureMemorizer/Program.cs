// Main program execution
class Program
{
    static void Main()
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string verseText = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";
        Scripture scripture = new Scripture(reference, verseText);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetScriptureDisplay());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");
            string input = Console.ReadLine();
            
            if (input.ToLower() == "quit")
                break;
            
            scripture.HideWords();
            if (scripture.IsFullyHidden())
                break;
        }

        Console.Clear();
        Console.WriteLine(scripture.GetScriptureDisplay());
        Console.WriteLine("\nAll words are now hidden. Memorization complete!");
    }
}
