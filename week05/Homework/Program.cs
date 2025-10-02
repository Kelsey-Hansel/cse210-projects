using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment studentAssignment = new Assignment("James Bond", "Spying");
        Console.WriteLine(studentAssignment.GetSummary());
        Console.WriteLine();

        MathAssignment studentMath = new MathAssignment("Josh Boyd", "Algebra", "5.2", "6-23");
        Console.WriteLine(studentMath.GetSummary());
        Console.WriteLine(studentMath.GetHomeworkList());
        Console.WriteLine();

        WritingAssignment studentWriting = new WritingAssignment("Amanda Brown", "English III", "The Benefits of Studying to Music");
        Console.WriteLine(studentWriting.GetSummary());
        Console.WriteLine(studentWriting.GetWritingInformation());
        Console.WriteLine();
    }
}