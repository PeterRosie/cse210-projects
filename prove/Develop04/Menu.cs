class Menu
{
    int DisplayMenu()
    {
        Console.WriteLine("Welcome to the Breathing Activity.");
        Console.Write("Select one of the following activities");
        int choice = Console.Read();
        return choice;
    }
}