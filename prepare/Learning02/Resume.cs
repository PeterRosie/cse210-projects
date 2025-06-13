
class Resume
{
    public string _Name;

    public List<Job> jobs = new List<Job>();

    public void displayResume()
    {
        Console.WriteLine("Enter your name: ");
        _Name = Console.ReadLine();
        Console.WriteLine($"Name: {_Name}");
        foreach (Job job in jobs)
        {
            Console.Write($"{job._Job}");
            Console.Write($" {job._Time}");
            Console.WriteLine($" {job._Title}");

        }
        
        
    }

}