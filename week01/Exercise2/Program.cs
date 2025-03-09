// Write a program that asks the user for their grade percentage and then prints out their letter grade.



class Program
{
    static void Main()
    {
        // Core Requirement 1: Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        double gradePercentage = Convert.ToDouble(Console.ReadLine());

        // Core Requirement 2: Determine the letter grade using if, else if, else
        string letter = "";
        
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Core Requirement 3: Print out the letter grade
        Console.WriteLine($"Your grade is: {letter}");

        // Check if the student passed or failed
        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't give up! Keep working hard and you'll do better next time.");
        }

        // Stretch Challenge:
        // Determine if the grade should have a "+" or "-" sign
        if (letter != "F")  // There is no + or - for F grade
        {
            int lastDigit = (int)gradePercentage % 10;  // Get the last digit of the grade percentage
            string sign = "";

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }

            // Combine letter grade with sign
            string finalGrade = letter + sign;
            Console.WriteLine($"Your final grade is: {finalGrade}");
        }
        else
        {
            Console.WriteLine("Your final grade is: F (No + or - for F grade)");
        }
    }
}
