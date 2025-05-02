using System;
using System.Globalization;


class Program
{
    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Enter your user name: ");
        string user = Console.ReadLine();
        return user;
    }

    static int UserNumber()
    {
        Console.Write("Enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());
        return num;
    }

    static double SquareNumber(double number)
    {
        
        double squ = number * number;
        Console.WriteLine($"Your number squared is: {squ}");
        return squ;
    }

    static void DisplayResult(string name, double end)
    {
        
        Console.WriteLine($"{name}, your number squared is: {end}");
    }

    static void Main(string[] args)
    {
        
        DisplayMessage();
        string id = PromptUserName();
        int num = UserNumber();
        double square = SquareNumber(num);
        DisplayResult(id, square);
    }
}