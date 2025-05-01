using System;

class Program
{
    static void Main(string[] args)
    {
        
        Random randomGenerator = new Random();
        int magicNum = randomGenerator.Next(1, 100);

        int number = 0;
        while (number != magicNum)
        {
            Console.Write("Guess a number: ");
            number = int.Parse(Console.ReadLine());
            if (number < magicNum)
            {
                
                Console.WriteLine("Higher");
            }
            else if (number > magicNum)
            {
                
                Console.WriteLine("Lower");
            }
            else
            {
                
                Console.WriteLine("You guessed the number.");
            }

        }
    }
}