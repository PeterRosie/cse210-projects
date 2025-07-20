class Northern : SteamLoco
{
    int _choice;
    public Northern(string loco, int year, int choice2)
    : base(loco, year, GetDescription(year, choice2))
    {
        _choice = choice2;
    }
    public void DisplayNMenu()
    {
        Menu menu = new Menu();
        _choice = menu.DisplayNorthernMenu();

        switch (_choice)
        {
            case 1:
                Console.WriteLine(GetDescription(2000));
                break;
            case 2:
                Console.WriteLine(GetDescription(2004));
                break;
            case 3:
                Console.WriteLine(GetDescription(2005));
                break;
            case 4:
                Console.WriteLine(GetDescription(2006));
                break;


        }



    }

    public static string GetDescription(int year, int choice)
    {
        string descript = "";
        switch (year)
        {
            case 2000:
                descript = $"Milwaukee Road 261 passed through the Quad Cities on June 27 {year}.\n"
                + $"The engine was on a non-revenue move from Kansas City to Minneapolis after running \n"
                + $"some trips out of Kansas City. On this day, the engine ran between Muscantine, Iowa \n"
                + $"and Marquette, Iowa.";
                break;
            case 2004:
                descript = $"Milwaukee Road 261 passed visited the Quad Cities while running an excursion train\n"
                + " that commerated the 150th anniversary of the Grand Excursion. While in the Quad Cities 261 pulled two excursions.\n"
                + "The first ran from Rock Island to Savanna, Illinois and return via the Canadian Pacific on June 26. The other \n"
                + "trip ran on the Iowa Interstate from Rock Island to Bureau Junction and back. 261 left the Quad Cities on June 28 \n"
                + "to finish out the Grand Excursion as she headed back to the Quad Cities";
                break;
            case 2005:
                descript = $"Milwaukee Road 261 visited the Quad Cities while travelling from Minneapolis to Kansas City for \n"
                + "the grand opening of a new rail exhibit in Kansas City called the Kansas City Rail Experience. She spent the night \n"
                + "in Davenport before leaving the following day, September 21st for Kansas City. She returned to Davenport on October 2nd \n"
                + "on her way back to Minneapolis. She spent the night in Davenport before continuing on her way to Minneapolis on October 3rd.";
                break;
            case 2006:
                descript = $"Milwaukee Road 261 visited the Quad Cities again for RiverWay 2006, an event which commemorated the 150th \n"
                + "anniversary of the first railroad bridge over the Mississippi River. She arrived in Rock Island on September 12. \n"
                + "She was mostly on display save for one excursion she ran which was a triple header with Iowa Interstate 6988 and 7081, a pair \n"
                + " of steam engines just imported from China for use on the Iowa Interstate. The excursion ran to Bureau Junction and back. \n"
                + " on September 19, she left the Quad Cities on her way back to Minneapolis.";
                break;
        }
        return descript;
    }
    public override string GetDescription(int year)
    {
        return GetDescription(year, _choice);

    }
    
}