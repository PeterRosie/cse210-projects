using System;

class Program
{
    static double AddNumbers(double a, double b)
    {
        return a + b;

    }    
    
    static void Main(string[] args)
    {
        Console.Write("Input your first name: ");
        string firstName = Console.ReadLine();
        Console.Write("Input your last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"Your name is: {firstName} {lastName}");
        int x1 = 10;
        if(x1==10)
        {
            Console.WriteLine("X is 10");
        }
        Console.WriteLine("Hey how are you?");
        for(int i = 0; i < 20; i++)
        {
            Console.WriteLine("Hello Kevin.");

        }

        // int x = 0;
        // int y = x++;
        // Console.WriteLine(x);
        // Console.WriteLine(y);

        List<int> myNumbers = new List<int>();
        Console.Write("Enter a number: ");
        int num = 0;
        num = int.Parse(Console.ReadLine());
        myNumbers.Add(99);
        myNumbers.Add(25);
        myNumbers.Add(-132);
        myNumbers.Add(num);
        
         foreach(int i in myNumbers)
         {
           Console.WriteLine(i);
        }
        double total = AddNumbers(123.98, 985.1234);
        Console.WriteLine(total);
        



    }

}