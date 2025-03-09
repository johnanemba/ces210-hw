using System;

class Program
{
    // Function to display the introductory message
    static void ShowWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // Function to ask the user for their name
    static string GetUserName()
    {
        Console.Write("Enter your name: ");
        return Console.ReadLine();
    }

    // Function to ask for the user's favorite number
    static int GetFavoriteNumber()
    {
        Console.Write("Enter your favorite number: ");
        return int.Parse(Console.ReadLine());
    }

    // Function to square the provided number
    static int CalculateSquare(int number)
    {
        return number * number;
    }

    // Function to display the result with the user's name and squared number
    static void ShowResult(string userName, int squaredValue)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredValue}");
    }

    static void Main()
    {
        // Call the function to display the welcome message
        ShowWelcomeMessage();

        // Prompt the user for their name and store it
        string name = GetUserName();

        // Ask the user for their favorite number and store it
        int favoriteNumber = GetFavoriteNumber();

        // Calculate the square of the favorite number
        int squaredNumber = CalculateSquare(favoriteNumber);

        // Display the result
        ShowResult(name, squaredNumber);
    }
}
