using System;

class Program
{
    static void Main()
    {
        // Creating fraction objects using different constructors
        Fraction f1 = new Fraction();      // 1/1
        Fraction f2 = new Fraction(5);     // 5/1
        Fraction f3 = new Fraction(3, 4);  // 3/4
        Fraction f4 = new Fraction(1, 3);  // 1/3

        // Displaying results
        Console.WriteLine(f1.GetFractionString() + " = " + f1.GetDecimalValue());
        Console.WriteLine(f2.GetFractionString() + " = " + f2.GetDecimalValue());
        Console.WriteLine(f3.GetFractionString() + " = " + f3.GetDecimalValue());
        Console.WriteLine(f4.GetFractionString() + " = " + f4.GetDecimalValue());

        // Testing getters and setters
        Fraction testFraction = new Fraction(2, 3);
        Console.WriteLine("Original Fraction: " + testFraction.GetFractionString());

        // Updating values using setters
        testFraction.SetNumerator(7);
        testFraction.SetDenominator(9);
        
        Console.WriteLine("Updated Fraction: " + testFraction.GetFractionString());
        Console.WriteLine("Decimal Value: " + testFraction.GetDecimalValue());
    }
}
