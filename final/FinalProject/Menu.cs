class Menu
{
    public int DisplayMenu() // method for the main menu
    {
        int choice = 0;
        while (choice < 1 || choice > 8)
        {
            Console.Clear();
            Console.WriteLine("Menu options");
            Console.WriteLine("1. Frisco 4-8-2 #1522");
            Console.WriteLine("2. Milwaukee Road 4-8-4 #261");
            Console.WriteLine("3. Iowa Interstate QJ 2-10-2 #6988");
            Console.WriteLine("4. Iowa Interstate QJ 2-10-2 #7081");
            Console.WriteLine("5. Nickel Plate Road 2-8-4 #765");
            Console.WriteLine("6. Union Pacific 4-6-6-4 #3985");
            Console.WriteLine("7. Union Pacific 2-10-2 #5511");
            Console.WriteLine("8. Canadian Pacific 4-6-4 #2816");
            Console.WriteLine("Enter an option: ");

            try
            {
                choice = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Input must be one of the choices");
            }
        }
        return choice;
    }
    public int DisplayNorthernMenu() // method for the menu for the Northern class
    {
        int option = 0;
        while (option < 1 || option > 4)
        {
            Console.Clear();
            Console.WriteLine("1. 2000");
            Console.WriteLine("2. 2004");
            Console.WriteLine("3. 2005");
            Console.WriteLine("4. 2006");

            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Not a year 261 visited the Quad Cities. Try again. ");
            }
        }
        return option;
    }
    public int QJMenu() // method for the QJ1 class
    {
        int select = 0;
        while (select < 1 || select > 7)
        {
            Console.Clear();
            Console.WriteLine("1. 2006");
            Console.WriteLine("2. 2008");
            Console.WriteLine("3. 2011");
            Console.WriteLine("4. 2012");
            Console.WriteLine("5. 2019");
            Console.WriteLine("6. 2022");
            Console.WriteLine("7. 2024");
            try
            {
                select = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Not a year when 6988 visited the Quad Cities. Try again.");
            }
        }
        return select;
    }
    public int QJOption() // method for the option of the two different visits in 2011
    {
        int select3 = 0;
        while (select3 < 1 || select3 > 2)
        {
            Console.Clear();
            Console.WriteLine("July or September? Enter 1 for July or enter 2 for September.");
            try
            {
                select3 = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Not one of the months 6988 visited the Quad Cities. ");
            }
        }
        return select3;
    }
    public int QJ2Menu() // method for the menu of the QJ2 class
    {
        int select2 = 0;
        while (select2 < 1 || select2 > 3)
        {
            Console.Clear();
            Console.WriteLine("1. 2006");
            Console.WriteLine("2. 2008");
            Console.WriteLine("3. 2011");
            try
            {
                int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Not a year when 7081 visited the Quad Cities. Try again. ");
            }
        }
        return select2;
    }
}