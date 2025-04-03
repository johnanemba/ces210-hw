// Main class to run the program
public class Program
{
    public static void Main(string[] args)
    {
        // Creating and displaying Assignment summary
        Assignment assignment = new Assignment("John Anemba", "Multiplication");
        Console.WriteLine(assignment.GetSummary());

        // Creating and displaying MathAssignment details
        MathAssignment mathAssignment = new MathAssignment("Kevin Wabitha", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());

        // Creating and displaying WritingAssignment details
        WritingAssignment writingAssignment = new WritingAssignment("joan okusimba", "Africa History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}