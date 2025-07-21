class Berkshire : SteamLoco
{
    private string _waterTender;
    private string _achievement;
    private string _personalRecord;
    public Berkshire(string loco, int year, string waterTender, string achivement, string personalRecord)
    : base(loco, year, GetDescription(year, waterTender, achivement, personalRecord))
    {
        _waterTender = waterTender;
        _achievement = achivement;
        _personalRecord = personalRecord;
    }
    public string GetWaterTenderInfo()
    {
        _waterTender = "former L&N tender used for extra water on loan from the Virginia Museum \n"
        + "of Transportation. It has a tender capacity of 25000 gallons of additional water. It's \n"
        + "also letter NORFOLK AND WESTERN";
        return _waterTender;
    }
    public string GetAchievement()
    {
        _achievement = "cross the Mississippi River for the first time";
        return _achievement;
    }
    public string GetPersonalRecord()
    {
        _personalRecord = "top speed of 50 mph";
        return _personalRecord;
    }
    public static string GetDescription(int year, string waterTender, string achievement, string personalRecord)
    {
        return $"Nickel Plate 765 visited the Quad Cities in July 2011. She arrived on July 20 after \n"
        + $"making a three day ferry move from North Judson, Indiana over the Chesapeake and Indiana, Norfolk \n"
        + $"Southern, Toledo Peoria and Western, and the Iowa Interstate Railroads. She was pulling a few coaches \n"
        + $"in addition her auxilary water and crew car. The auxilary water car was a {waterTender} as her own \n"
        + $"water tender was out of service at the time. During the festival daily trips were run to Walcott, Iowa \n"
        + $"and back. This would usually be handled by one of the Iowa Interstate's pair of 2-10-2s number 6988 or 7081. \n"
        + $"On July 21, one of these two weren't ready in time, so 765 filled in for the morning Walcott excursion. This \n"
        + $"excursion marked a personal achievement for the engine as she would {achievement}. She was mostly on display \n"
        + $"for the rest of the day. On July 22, she ran a mainline trip to Bureau Junction and back. Two of Amtrak's Heritage \n"
        + $" units accompanined 765 in case they were needed. On this trip 765 would run at a {personalRecord} which was the \n"
        + $"fastest she had gone in the 21st Century only to be surpassed when she ran over 70 mph on another excursion. On July \n"
        + $"23, she was on display but she ran one more excursion on July 24 which was one of the usual Walcott excursions. At \n"
        + $"she began her journey back to her homebase in New Haven, Indiana. She would arrive back home on July 26. ";
        
    }
    public override string GetDescription(int year)
    {
        return GetDescription(year, _waterTender, _achievement, _personalRecord);

    }
}