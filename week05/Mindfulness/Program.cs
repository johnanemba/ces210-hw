using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Mindfulness Program");

        // Main menu for activity selection
        Console.WriteLine("Select an Activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");

        int choice = int.Parse(Console.ReadLine());
            Activity activity = null;
    
            // Determine activity type based on user choice
            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity();
                    break;
                case 2:
                    activity = new ReflectionActivity();
                    break;
                case 3:
                    activity = new ListingActivity();
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }
    
            activity.Start();
        }

        // Define the Activity base class
        abstract class Activity
        {
            public abstract void Start();
        }

        // Define the BreathingActivity class
        class BreathingActivity : Activity
        {
            public override void Start()
            {
                Console.WriteLine("Starting Breathing Activity...");
                // Add logic for the Breathing Activity here
            }
        }

        // Define the ReflectionActivity class
        class ReflectionActivity : Activity
        {
            public override void Start()
            {
                Console.WriteLine("Starting Reflection Activity...");
                // Add logic for the Reflection Activity here
            }
        }

        // Define the ListingActivity class
        class ListingActivity : Activity
        {
            public override void Start()
            {
                Console.WriteLine("Starting Listing Activity...");
                // Add logic for the Listing Activity here
            }
        }
}
    
