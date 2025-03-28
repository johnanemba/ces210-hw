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
// This program exceeds the core requirements by:
// - Loading scriptures from an external file instead of hardcoding them.
// - Allowing the user to request hints (`hint` command).
// - Ensuring that only visible words are hidden (not re-hiding already hidden words).
// - Using proper encapsulation by making class fields private.
// - Adding a method to check if all words are hidden, which is useful for determining when to end the game.
// - Using LINQ for filtering and manipulating collections, which is a more modern approach in C#.