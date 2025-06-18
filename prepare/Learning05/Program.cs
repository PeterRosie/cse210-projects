using System;

class Program
{
    static void Main(string[] args)
    {
        Square newSquare = new Square("green", 2);
        Console.WriteLine(newSquare.GetArea());
        Rectangle myRectangle = new Rectangle("yellow", 8, 12);
        Console.WriteLine(myRectangle.GetArea());
        Circle myCircle = new Circle("red", 10);
        Console.WriteLine(myCircle.GetArea());
    }

}
