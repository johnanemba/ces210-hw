using System;

class Program
{
    static void Main()
    {
        // This is the main loop where the user can play the game multiple times
        string playAgain = "yes";
        while (playAgain.ToLower() == "yes")
        {
            // Initialize random number generator to generate a random number between 1 and 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101); // Magic number between 1 and 100

            // Initialize a counter to track the number of guesses the user makes
            int guessCount = 0;
            int userGuess = 0;

            // Start the game by asking the user to guess the number
            Console.WriteLine("I have selected a magic number between 1 and 100. Try to guess it!");

            // Keep asking for guesses until the correct one is made
            while (userGuess != magicNumber)
            {
                // Ask the user for their guess
                Console.Write("What is your guess? ");
                userGuess = Convert.ToInt32(Console.ReadLine());

                // Increment the number of guesses
                guessCount++;

                // Provide feedback on whether the guess is too high, too low, or correct
                if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guessCount} guesses.");
                }
            }

            // Ask if the user wants to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }

        // When the user says no, thank them for playing
        Console.WriteLine("Thanks for playing! Goodbye.");
    }
}
