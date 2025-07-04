class Menu
{
    int DisplayMenu()
    {
        int choice = 0;

        while (choice < 1 || choice > 4)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Input must be an integer value between 1 and 5");
            }

        }
        return choice;
    }
    int DisplayCreateGoalMenu()
    {
        int type = 0;
        while (type < 1 || type > 3)
        {
            Console.Clear();
            Console.WriteLine("Create Menu Options: ");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
        }
        return type;

    }
}