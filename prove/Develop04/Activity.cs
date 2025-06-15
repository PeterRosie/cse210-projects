class Activity
{
    string _name;
    string _description;
    int _duration;
    DateTime _endTime;
    List<string> spinner = new(){"|","/","-","\\"};
    public Activity(string name, string description, int seconds)
    {
        _name = "";
        _description = "";
        _duration = 0;

    }
    public void DisplayGreeting()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
    }
    public void DisplayDescription()
    {
        Console.WriteLine($"{_description}");
    }
    public void DisplayEnding()
    {
        Console.WriteLine($"Thank you for attending the {_name} activity.");
    }
    public void RunCountDown(string message, int seconds)
    {
        Console.WriteLine(message);
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + "\b");
        }

    }
    public void DisplaySpinner(string message, int seconds)
    {
        Console.WriteLine(message);
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(10);
        int i = 0;
        while (DateTime.Now < futureTime)
        {
            Console.Write(spinner[i%4]);
            i++;
        }


    }
    public int ObtainDuration()
    {
        Console.Write("How long do you want to this activity for? ");
        return _duration = Console.Read();

    }

}