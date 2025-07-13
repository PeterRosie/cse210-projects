using System;



class Program
{
    // static void TestByRef(int x, ref string n)
    // {
    //     x++;
    //     n += " Plus Betty";
    //     Console.WriteLine($"In TestByRef: {x}, {n}");
    // }

    // static void TestByOut(out int a)
    // {
    //     a = 0;
    //     Console.WriteLine($"In TestByOut: {a}");
    // }
    static void Main(string[] args)
    {
        int? x = null;
        string name = "Betty";

        int y = x ?? 29;
        Console.WriteLine(y);

        name ??= "Bob";
        Console.WriteLine(name);

        string myName = null;
        int? length = myName?.Length;
        Console.WriteLine(length);


        int bobsAge = 23;
        int bettysAge = 31;

        string whoIsOlder = bobsAge > bettysAge ? "Bob is older" : "Betty is older";
        Console.WriteLine(whoIsOlder);
        // int z = 10;
        // string name = "Bob";

        // TestByRef(z, ref name);
        // Console.WriteLine($"In main: {z}, {name} ");

        // int c;
        // TestByOut(out c);
        // Console.WriteLine($"In Main: c is: {c}");


        // Console.WriteLine("Bonjour tout le monde.");

        // Circle myCircle = new Circle();
        // myCircle.SetRadius(10);
        // Console.WriteLine($"{myCircle.GetRadius()}");
        // Circle myCircle2 = new Circle();
        // myCircle2.SetRadius(20);
        // Console.WriteLine($"{myCircle2.GetRadius()}");
        // Console.WriteLine($"{myCircle.GetArea()}");
        // Console.WriteLine($"{myCircle2.GetArea()}");

        // Cylinder myCylinder = new Cylinder();
        // myCylinder.SetHeight(10);
        // myCylinder.SetCircle(myCircle);
        // Console.WriteLine($"{myCylinder.GetVolume()}");

        // int duration = 12;
        // DateTime currentTime = DateTime.Now;
        // DateTime endTime = currentTime.AddSeconds(duration);
        // int sleepTime = 250;
        // int count = duration;

        // string animationString = "(^_^)(-_-)";

        // while (DateTime.Now < endTime)
        // {
        //     Console.Write(animationString[0..5]);
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b\b\b\b\b");
        //     Console.Write(animationString[5..]);
        //     Thread.Sleep(sleepTime);
        //     Console.Write("\b\b\b\b\b");
        // }
        // while (DateTime.Now < endTime)
        //     {
        //         Console.Write("+");
        //         Thread.Sleep(sleepTime);
        //         Console.Write("\b");
        //         Console.Write("-");
        //         Thread.Sleep(sleepTime);
        //         Console.Write("\b");
        //         Console.Write("-");
        //     }




    }

}