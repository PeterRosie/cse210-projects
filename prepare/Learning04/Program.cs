using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(myAssignment.GetSummary());
        MathAssignment myMathAssignment = new MathAssignment("Roberto Rodriguz", "Fractions", "Section 7.3", "Problems 8-19");
        Console.WriteLine(myMathAssignment.GetSummary());
        Console.WriteLine(myMathAssignment.GetHomeworkList());
        WritingAssignment myWriting = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II by Mary Waters");
        Console.WriteLine(myWriting.GetSummary());
        Console.WriteLine(myWriting.GetWritingInformation());      
    }
}