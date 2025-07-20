class QJ1 : SteamLoco
{
    private int _choice2;
    public QJ1(string loco, int year, int choice3)
    : base(loco, year, GetDescription(year, choice3))
    {
        _choice2 = choice3;
    }
    public void DisplayQJMenu()
    {
        Menu qJ1 = new Menu();
        _choice2 = qJ1.QJMenu();
        switch (_choice2)
        {
            case 1:
                Console.WriteLine(GetDescription(2006));
                break;
            case 2:
                Console.WriteLine(GetDescription(2008));
                break;
            case 3:
                Console.WriteLine(GetDescription(2011));
                break;
            case 4:
                Console.WriteLine(GetDescription(2019));
                break;
            case 5:
                Console.WriteLine(GetDescription(2022));
                break;
            case 6:
                Console.WriteLine(GetDescription(2024));
                break;

        }
    }
    public static string Display2011Options()
    {
        Menu twoVisits = new Menu();
        string choice4 = $"{twoVisits.QJOption()}";
        if (choice4 == "July")
        {
            choice4 = $"Iowa Interstate 6988 visited the Quad Cities for Train Festival 2011 which went from July 21-24. On July 20 \n"
            + $"both 6988 and 7081 led a record freight train which weighed 7,200 tons holding the record for freight hauled by steam \n"
            + $"in the 21st Century. Both engines took the train to the Quad Cities. During the festival both engines would occasionally power \n"
            + $"the short excursions to Walcott, Iowa and back. On the first day, July 21, one of the QJs weren't ready so Nickel Plate 2-8-4 number \n"
            + $"765 would handle the first trip. That afternoon 6988 handled the Walcott Trip. On July 22, 6988 would handle both Walcott trips. On July 23, \n"
            + $"6988 would run a mainline trip to Iowa City and back. Other than these trips, 6988 was on display for the Train Festival. On July 25, both \n"
            + $"6988 and 7081 ran a ferry move back to Newton, Iowa. ";
        }
        else if (choice4 == "September")
        {
            choice4 = $"Iowa Interstate 6988 visited the Quad Cities while making ferry move on September 8 to run several excursions between \n"
            + $"Geneseo and Annawan on September 10 and 11. On September 11, 6988 passed through the Quad Cities on her way back to Newton, Iowa. ";
        }
        else
        {
            choice4 = "Not a month 6988 visited the Quad Cities";
        }
        return choice4;
    }
    public static string GetDescription(int year, int choice)
    {
        string descript2 = "";
        switch (year)
        {
            case 2006:
                descript2 = $"Iowa Interstate 6988 first visited the Quad Cities when exported from China with 7081. They first operated \n"
                + $"for RiverWay 2006. 6988 ran a doubleheader excursion with 7081 from Rock Island to Homestead, Iowa and back on September 15. \n"
                + $"On September 16, 6988 was the lead engine of a tripleheader excursion with 7081 and Milwaukee Road 261 to Bureau Junction \n"
                + $"and back. On September 17, 6988 and 7081 ran another doubleheader excursion to Muscatine, Iowa and back. After the event, \n"
                + $"both 6988 and 7081 pulled a record freight train which at the time held the record of heaviest freight hauled by steam \n"
                + "in the 21st Century as they made their way to their new home in Newton, Iowa";
                break;
            case 2008:
                descript2 = $"Iowa Interstate 6988 visited the Quad Cities in October 2008 as of a flood relief. On October 18, 6988 along with \n"
                + $"7081 led another record freight train to Rock Island. On the same day, 6988 led an excursion to the nearby town of Silvis with \n"
                + $"a diesel lead the return journey. The next day, October 19, both 6988 and 7081 returned to Newton on a ferry move.";
                break;
            case 2011:
                Console.WriteLine(Display2011Options());
                break;
            case 2012:
                descript2 = $"Iowa Interstate 6988 visited the Quad Cities on June 19 as part of the National Railway \n"
                + $"Historical Society's convention which was being held in Cedar Rapids, Iowa. An excursion was run from \n"
                + $"Cedar Rapids to Rock Island with diesels with 6988 pulling part of the return trip as far as South Amana, Iowa.\n"
                + $"Shortly afterwards, the engine went back to Newton on another excursion during the convention.";
                break;
            case 2019:
                descript2 = $"Iowa Interstate 6988 went through the Quad Cities on two ferry moves. She passed through \n"
                + $"the Quad Cities on May 16 and spend the night in the area before continuing onto to Chillicothe to \n"
                + $"run some excursions benefitting a fire department. After the excursions out of Chillicothe were completed. \n"
                + $"she passed through the Quad Cities on May 20 as she made her way back to Newton.";
                break;
            case 2022:
                descript2 = $"Iowa Interstate 6988 passed through the Quad Cities on June 11 while making a one-way ferry \n"
                + $"move to Silvis, Illinois for maintenance at the former Rock Island railroad shops.";
                break;
            case 2024:
                descript2 = $"Iowa Interstate 6988 was towed through the Quad Cities by a diesel on August 20. She was heading \n"
                + $"Des Moines for display for a few days before heading back to Newton. She had stayed in Silvis for the past \n"
                + $"two years but went back to Newton to make move for the restorations of Union Pacific 4-6-6-4 number 3985 and \n"
                + $"2-10-2 number 5511 which had been in Silvis since 2022.";
                break;
        }
        return descript2;
    }
    public override string GetDescription(int year)
    {
        return GetDescription(year, _choice2);

    }
}