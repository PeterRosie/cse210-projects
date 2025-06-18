class Program
{
    public static void Main(string[] args)
    {
        // Person myPerson = new Person("Ed", "Dickens", 62);
        // Console.WriteLine(myPerson.GetPersonInformation());

        PoliceMan myPoliceMan = new PoliceMan("Betty", "Cramer", 60, "Bat", 65, 73);
        // Console.WriteLine(myPoliceMan.GetPoliceManInformation());

        Doctor myDoctor = new Doctor("Bob", "Payne", 56, "Hammer", 500000);
        // Console.WriteLine(myDoctor.GetDoctorInformation());

        List<Person> myPeople = new List<Person>();
        // myPeople.Add(myPerson);
        myPeople.Add(myDoctor);
        myPeople.Add(myPoliceMan);

        foreach (Person person in myPeople)
        {
            DisplayPersonInfromation(person);
        }
    }


    private static void DisplayPersonInfromation(Person person)
    {
        Console.WriteLine(person.GetPersonInformation());
        Console.WriteLine(person.GetPay());
    }
}
