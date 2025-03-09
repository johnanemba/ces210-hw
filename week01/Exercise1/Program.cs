using System;

class Program
{
    static void Main(string[] args)
    {
        console.writeline("what is your first name?");
        string firstname = console.ReadLine();

        Console.Write("What is your last name? ");
        string last = Console.ReadLine();

        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}