using System;



class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Bonjour tout le monde.");

        Circle myCircle = new Circle();
        myCircle.SetRadius(10);
        Console.WriteLine($"{myCircle.GetRadius()}");
        Circle myCircle2 = new Circle();
        myCircle2.SetRadius(20);
        Console.WriteLine($"{myCircle2.GetRadius()}");
        Console.WriteLine($"{myCircle.GetArea()}");
        Console.WriteLine($"{myCircle2.GetArea()}");

        Cylinder myCylinder = new Cylinder();
        myCylinder.SetHeight(10);
        myCylinder.SetCircle(myCircle);
        Console.WriteLine($"{myCylinder.GetVolume()}");

        int duration = 12;
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(duration);
        int sleepTime = 250;
        int count = duration;

        string animationString = "(^_^)(-_-)";

        while (DateTime.Now < endTime)
        {
            Console.Write(animationString[0..5]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");
            Console.Write(animationString[5..]);
            Thread.Sleep(sleepTime);
            Console.Write("\b\b\b\b\b");
        }
        while (DateTime.Now < endTime)
            {
                Console.Write("+");
                Thread.Sleep(sleepTime);
                Console.Write("\b");
                Console.Write("-");
                Thread.Sleep(sleepTime);
                Console.Write("\b");
                Console.Write("-");
            }


    }

}