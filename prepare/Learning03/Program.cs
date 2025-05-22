using System;

class Program
{
    static void Main(string[] args)
    {
        int num = 6;
        Fraction fraction = new Fraction();
        Fraction fraction1 = new Fraction(num);
        Fraction fraction2 = new Fraction(6, 7);

        fraction.SetTop(1);
        fraction.SetBottom(1);
        Console.WriteLine($"{fraction.GetFractionString()}");
        Console.WriteLine(fraction.GetDecimalValue());
        fraction.SetTop(5);
        fraction.SetBottom(1);
        Console.WriteLine($"{fraction1.GetFractionString()}");
        Console.WriteLine(fraction1.GetDecimalValue());
        fraction2.SetTop(3);
        fraction2.SetBottom(4);
        Console.WriteLine($"{fraction2.GetFractionString()}");
        Console.WriteLine(fraction2.GetDecimalValue());
        fraction2.SetTop(1);
        fraction2.SetBottom(3);
        Console.WriteLine($"{fraction2.GetFractionString()}");
        Console.WriteLine(fraction2.GetDecimalValue());

    }
}