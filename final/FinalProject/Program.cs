using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("List of Steam Engines that visited the Quad Cities:");
        Menu mq = new Menu(); 
        int response2 = 0;
        response2 = mq.DisplayMenu(); // displaying the menu
        while (response2 != 9)
        {

            if (response2 == 1) // if the user chooses to look at Frisco 1522 
            {
                Mountain mountain = new Mountain("Frisco 1522", 1990, "Pilot wheel issues");
                Console.WriteLine(mountain.GetDescription(1990)); // The description is displayed
                Console.WriteLine("Press enter to continue. "); // asking the user to continue
                Console.ReadLine();
            }
            else if (response2 == 2) // if the user choose to look at Milwaukee Road 261
            {
                response2 = mq.DisplayNorthernMenu(); // the menu for years
                // that Milwaukee Road 261 visited the Quad Cities is displayed

                if (response2 == 1) // if the user chooses 2000
                {
                    Northern northern = new Northern("Milwaukee Road 261", 2000, 1);
                    Console.WriteLine(northern.GetDescription(2000)); // the description is displayed
                    Console.WriteLine("Press enter to continue. "); // asking the user to continue
                    Console.ReadLine();

                }
                else if (response2 == 2) // if the user chooses 2004
                {
                    Northern northern = new Northern("Milwaukee Road 261", 2004, 2);
                    Console.WriteLine(northern.GetDescription(2004)); // the description is displayed
                    Console.WriteLine("Press enter to continue. "); // asking the user to continue
                    Console.ReadLine();
                }
                else if (response2 == 3) // if the user chooses 2005
                {
                    Northern northern = new Northern("Milwaukee Road 261", 2005, 3);
                    Console.WriteLine(northern.GetDescription(2005)); // the description is displayed
                    Console.WriteLine("Press enter to continue. "); // asking the user to continue
                    Console.ReadLine();
                }
                else if (response2 == 4) // if the user chooses 2006
                {
                    Northern northern = new Northern("Milwaukee Road 261", 2006, 4);
                    Console.WriteLine(northern.GetDescription(2006)); // the description is displayed
                    Console.WriteLine("Press enter to continue. "); // asking the user to continue
                    Console.ReadLine();
                }
                else // if any other option is chosen
                {
                    Console.WriteLine("Not a valid choice. Please try again.");
                }
            }
            else if (response2 == 3) // if the user chooses to look at Iowa Interstate 6988
            {
                response2 = mq.QJMenu(); // the menu for years that 6988 visited the Quad Cities
                if (response2 == 1) // if the user chooses 2006
                {
                    QJ1 qj = new QJ1("Iowa Interstate 6988", 2006, 1);
                    Console.WriteLine(qj.GetDescription(2006)); // the description is displayed
                    Console.WriteLine("Press enter to continue. "); // asking the user to continue
                    Console.ReadLine();
                }
                else if (response2 == 2) // if the user chooses 2008
                {
                    QJ1 qj = new QJ1("Iowa Interstate 6988", 2008, 2);
                    Console.WriteLine(qj.GetDescription(2008)); // the description is displayed
                    Console.WriteLine("Press enter to continue. "); // asking the user to continue
                    Console.ReadLine();
                }
                else if (response2 == 3) // if the user chooses 2011
                {
                    mq.QJOption(); // the menu for the two visits 6988 made to the Quad Cities

                    if (response2 == 1) // if the user chooses July
                    {
                        QJ1 qj = new QJ1("Iowa Interstate 6988", 2011, 3); 
                        Console.WriteLine(qj.GetDescription(2011)); // the description is displayed
                        Console.WriteLine("Press enter to continue"); // asking the user to continue
                        Console.ReadLine();

                    }
                    else if (response2 == 2) // if the user chooses September
                    {
                        QJ1 qj = new QJ1("Iowa Interstate 6988", 2011, 3);
                        Console.WriteLine(qj.GetDescription(2011)); // the description is displayed
                        Console.WriteLine("Press enter to continue"); // asking the user to continue
                        Console.ReadLine();
                    }



                }
                else if (response2 == 4) // if the user chooses 2012
                {
                    QJ1 qj = new QJ1("Iowa Interstate 6988", 2012, 4);
                    Console.WriteLine(qj.GetDescription(2012)); // the description is displayed
                    Console.WriteLine("Press enter to continue. "); // asking the user to continue
                    Console.ReadLine();
                }
                else if (response2 == 5) // if the user chooses 2019
                {
                    QJ1 qj = new QJ1("Iowa Interstate 6988", 2019, 5);
                    Console.WriteLine(qj.GetDescription(2019)); // the description is displayed
                    Console.WriteLine("Press enter to continue. "); // asking the user to continue
                    Console.ReadLine();
                }
                else if (response2 == 6) // if the user chooses 2022
                {
                    QJ1 qj = new QJ1("Iowa Interstate 6988", 2022, 6);
                    Console.WriteLine(qj.GetDescription(2022)); // the description is displayed
                    Console.WriteLine("Press enter to continue. "); // asking the user to continue
                    Console.ReadLine();
                }
                else if (response2 == 7) // if the user chooses 2024
                {
                    QJ1 qj = new QJ1("Iowa Interstate 6988", 2024, 7);
                    Console.WriteLine(qj.GetDescription(2024)); // the description is displayed
                    Console.WriteLine("Press enter to continue. "); // asking the user to continue
                    Console.ReadLine();
                }
            }
            else if (response2 == 4) // the user chooses to look at Iowa Interstate 7081
            {
                response2 = mq.QJ2Menu(); // the menu for the visits that 7081 made to the Quad Cities
                if (response2 == 1) // if the user chooses 2006
                {
                    QJ2 qj2 = new QJ2("Iowa Interstate 7081", 2006, 1);
                    Console.WriteLine(qj2.GetDescription(2008)); // the description is displayed
                    Console.WriteLine("Press enter to continue. "); // asking the user to continue
                    Console.ReadLine();
                }
                else if (response2 == 2) // if the user chooses 2008
                {
                    QJ2 qj2 = new QJ2("Iowa Interstate 7081", 2008, 2);
                    Console.WriteLine(qj2.GetDescription(2008)); // the description is displayed
                    Console.WriteLine("Press enter to continue. "); // asking the user to continue
                    Console.ReadLine();
                }
                else if (response2 == 3) // if the user chooses 2011
                {
                    QJ2 qj2 = new QJ2("Iowa Interstate 7081", 2011, 3);
                    Console.WriteLine(qj2.GetDescription(2011)); 
                    Console.WriteLine("Press enter to continue. ");
                    Console.ReadLine();
                }
            }
            else if (response2 == 5) // if the user chooses to look at Nickel Plate 765
            {
                Berkshire berk = new Berkshire("Nickel Plate 765", 2011, "former L&N tender used for extra water on loan from the Virginia Museum \n"
                + "of Transportation. It has a tender capacity of 25000 gallons of additional water. It's \n"
                + "also letter NORFOLK AND WESTERN", "cross the Mississippi River for the first time", "top speed of 50 mph");
                Console.WriteLine(berk.GetDescription(2011)); // the description is displayed
                Console.WriteLine("Press enter to continue. "); // asking the user to continue
                Console.ReadLine();
            }
            else if (response2 == 6) // if the user chooses to look at Union Pacific 3985
            {
                Challenger challenger = new Challenger("Union Pacific 3985", 2022, "A diesel, 3985, a flatcar, 5511, three support cars, DDA40X Cenntennial diesel 6936\n"
                + " a baggage car, a diner car, a business car, a caboose, E9B 966B, a diesel and 8 singlebeam freight cars \n"
                + "and 14 covered hoppers");
                Console.WriteLine(challenger.GetDescription(2022)); // the description is displayed
                Console.WriteLine("Press enter to continue. "); // asking the user to continue
                Console.ReadLine();
            }
            else if (response2 == 7) // if the user chooses to look at Union Pacific 5511
            {
                SantaFe sf = new SantaFe("Union Pacific 5511", 2022, "A diesel, 3985, a flatcar, 5511, three support cars, DDA40X Cenntennial diesel 6936\n"
                + " a baggage car, a diner car, a business car, a caboose, E9B 966B, a diesel and 8 singlebeam freight cars \n"
                + "and 14 covered hoppers");
                Console.WriteLine(sf.GetDescription(2022)); // the description is displayed
                Console.WriteLine("Press enter to continue. "); // asking the user to continue
                Console.ReadLine();
            }
            else if (response2 == 8) // if the user chooses to look at Canadian Pacific 2816
            {
                CanadianHudson hudson = new CanadianHudson("Canadian Pacific 2816", 2024, "Final Spike Tour", "light engine move");
                Console.WriteLine(hudson.GetDescription(2024)); // the description is displayed
                Console.WriteLine("Press enter to continue. "); // asking the user to continue
                Console.ReadLine();
            }
            else if (response2 == 9) 
            {
                break;
            }


            response2 = mq.DisplayMenu();
        }
    }
}