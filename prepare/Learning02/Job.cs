
using System.Xml.XPath;

class Job
{
    public string _Job;
    public string _Title;
    public string _Time;

    public string getCompany()
    {
        Console.Write("Enter the company name: ");
        string user = Console.ReadLine();
        Console.WriteLine($"{user}");
        _Job = user;
        return user;
        
        

    }

    public void displayJobDetails()
    {
        Console.Write("Enter your job title: ");
        string result = Console.ReadLine();
        Console.Write("Enter when you worked here: ");
        string work = Console.ReadLine();
        string end = getCompany();
        _Title = result;
        _Time = work;
        Console.WriteLine($"{result} ({end}) {work}");
        
        

    }
}


