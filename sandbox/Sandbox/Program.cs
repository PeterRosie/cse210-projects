using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Input your first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Input your last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is: {firstName} {lastName}");
        int x = 10;
        if(x==10)
        {
            Console.WriteLine("X is 10");
        }
        Console.WriteLine("Hey how are you?");
        for(int i = 0; i < 20; i++)
        {
            Console.WriteLine("Hello Kevin.");
        }
    }
}