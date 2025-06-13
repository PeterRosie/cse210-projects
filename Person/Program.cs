class Program
{
    public static void Main(string[] args)
    {
        Person myPerson = new Person("Ed", "Dickens", 62);
        Console.WriteLine(myPerson.GetPersonInformation());

        PoliceMan myPoliceMan = new PoliceMan("Betty", "Cramer", 60, "Bat");
        Console.WriteLine(myPoliceMan.GetPoliceManInformation());
    }
}
