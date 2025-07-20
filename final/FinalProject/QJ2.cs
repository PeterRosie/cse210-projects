class QJ2 : SteamLoco
{
    private int _choice3;
    public QJ2(string loco, int year, int choices)
    : base(loco, year, GetDescription(year, choices))
    {
        _choice3 = choices;
    }
    public void DisplayQJ2Options()
    {
        Menu qj2 = new Menu();
        _choice3 = qj2.QJ2Menu();
        switch (_choice3)
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
        }

    }
    public static string GetDescription(int year, int choice)
    {
        string descript = "";
        switch (year)
        {
            case 2006:
                descript = $"Iowa Interstate 7081 first visited the Quad Cities when exported from China with 6988. They first operated \n"
                + $"for RiverWay 2006. 7081 ran a doubleheader excursion with 6988 from Rock Island to Homestead, Iowa and back on September 15. \n"
                + $"On September 16, 7081 was involved with a tripleheader with 6988 and Milwaukee Road 261 to Bureau Junction \n"
                + $"and back. On September 17, 6988 and 7081 ran another doubleheader excursion to Muscatine, Iowa and back. After the event, \n"
                + $"both 6988 and 7081 pulled a record freight train which at the time held the record of heaviest freight hauled by steam \n"
                + "in the 21st Century as they made their way to their new home in Newton, Iowa";
                break;
            case 2008:
                descript = $"Iowa Interstate 7081 visited the Quad Cities in October 2008 as of a flood relief. On October 18, 7081 along with \n"
                + $"6988 led another record freight train to Rock Island. On the same day, 7081 turned around near Silvis before leading a \n"
                + $"westbound excursion to Walcott with a diesel leading the return journey to Rock Island. In the evening 7081 ran a dinner \n"
                + $"excursion in the Quad Cities. The next day, October 19, both 6988 and 7081 returned to Newton on a ferry move. ";
                break;
            case 2011:
                descript = $"Iowa Interstate 7081 visited the Quad Cities for Train Festival 2011 which went from July 21-24. On July 20 \n"
            + $"both 6988 and 7081 led a record freight train which weighed 7,200 tons holding the record for freight hauled by steam \n"
            + $"in the 21st Century. Both engines took the train to the Quad Cities. During the festival both engines would occasionally power \n"
            + $"the short excursions to Walcott, Iowa and back. During the first two days, 7081 was mostly on display while 6988 handled the \n"
            + $"afternoon Walcott trip on July 21 and both Walcott trips on July 22. On July 23, 7081 handled both of the daily trips to Walcott. \n"
            + $"On July 24, 6988 led the last Walcott excursion during the Train Festival. On July 25, both 6988 and 7081 ran a ferry move back to \n"
            + $"Newton, Iowa. ";
                break;
        }
        return descript;
    }
    public override string GetDescription(int year)
    {
        return GetDescription(year, _choice3);
    }
}