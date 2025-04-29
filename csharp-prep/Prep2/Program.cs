using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.Write("Enter your grade: ");
        string ans = Console.ReadLine();
        float percent = float.Parse(ans);
        if (percent >= 90)
        {
            Console.WriteLine("Your got an A. ");
        }
        else if (percent < 90 && percent >= 80)
        {
            Console.WriteLine("You got a B. ");
        }
        else if (percent < 80 && percent >= 70)
        {
            Console.WriteLine("You got a C.");
        } 
        else if (percent < 70 && percent >= 60)
        {
            Console.WriteLine("You got a D. ");
        }
        else
        {
            Console.WriteLine("You got an F. ");
        }



        
    }
}