class Menu
{
    public int DisplayMenu()
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
}