using System;

class Fraction
{
    private int numerator;
    private int denominator;

    // Default constructor - initializes to 1/1
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    // Constructor with one parameter - initializes denominator to 1
    public Fraction(int top)
    {
        numerator = top;
        denominator = 1;
    }

    // Constructor with two parameters
    public Fraction(int top, int bottom)
    {
        if (bottom == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        numerator = top;
        denominator = bottom;
    }

    // Getter for numerator
    public int GetNumerator()
    {
        return numerator;
    }

    // Setter for numerator
    public void SetNumerator(int value)
    {
        numerator = value;
    }

    // Getter for denominator
    public int GetDenominator()
    {
        return denominator;
    }

    // Setter for denominator with validation
    public void SetDenominator(int value)
    {
        if (value == 0)
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        denominator = value;
    }

    // Method to return fraction in string format
    public string GetFractionString()
    {
        return numerator + "/" + denominator;
    }

    // Method to return fraction as a decimal
    public double GetDecimalValue()
    {
        return (double)numerator / denominator;
    }
}
