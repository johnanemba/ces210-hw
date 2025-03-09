using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Step 1: Declare a list to store user input
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int input;
        
        // Loop to get user input until they enter 0
        do
        {
            Console.Write("Enter number: ");
            input = Convert.ToInt32(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }
        } while (input != 0);

        // Step 2: Calculate the sum, average, and maximum
        if (numbers.Count > 0)
        {
            int sum = 0;
            int max = numbers[0];

            foreach (int number in numbers)
            {
                sum += number;
                if (number > max)
                {
                    max = number;
                }
            }

            double average = (double)sum / numbers.Count;

            Console.WriteLine($"The sum is: {sum}");
            Console.WriteLine($"The average is: {average}");
            Console.WriteLine($"The largest number is: {max}");

            // Step 3: Stretch Challenge - Find the smallest positive number and sort the list
            int smallestPositive = int.MaxValue;

            foreach (int number in numbers)
            {
                if (number > 0 && number < smallestPositive)
                {
                    smallestPositive = number;
                }
            }

            if (smallestPositive != int.MaxValue)
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            }
            else
            {
                Console.WriteLine("There are no positive numbers.");
            }

            // Sort the list and display it
            numbers.Sort();
            Console.WriteLine("The sorted list is:");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        else
        {
            Console.WriteLine("No numbers were entered.");
        }
    }
}
