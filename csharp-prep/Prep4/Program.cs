using System;
using System.Collections.Generic;

class Program

{
    static void Main(string[] args)
    {
        
        int num = -1;
        List<int> numLists = new List<int>();
        while (num != 0)
        {
            Console.Write("Enter a number: ");
            string user = Console.ReadLine();
            num = int.Parse(user);
            if (num != 0)
            {
                numLists.Add(num);
            }
        }
        int sum = 0;
        foreach (int number in numLists)
            {
                sum += number;
            }
        float avg = ((float)sum) / numLists.Count;    
        Console.WriteLine($"The Sum is: {sum}");
        Console.WriteLine($"The average is: {avg}");
        int max = numLists[0];
        foreach (int number in numLists)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
 
    }
}