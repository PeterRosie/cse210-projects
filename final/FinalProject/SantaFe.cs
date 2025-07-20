class SantaFe : SteamLoco
{
    private string _trainInfo;
    public SantaFe(string loco, int year, string trainInfo)
    : base(loco, year, GetDescription(year, trainInfo))
    {
        _trainInfo = trainInfo;

    }
    public string GetTrainInfo()
    {
        _trainInfo = "A diesel, 3985, a flatcar, 5511, three support cars, DDA40X Cenntennial diesel 6936\n"
        + " a baggage car, a diner car, a business car, a caboose, E9B 966B, a diesel and 8 singlebeam freight cars \n"
        + "and 14 covered hoppers";
        return _trainInfo;
    }
    public static string GetDescription(int year, string trainInfo)
    {
        return $"Union Pacific 5511 visited the Quad Cities on November 19, 2022 while in a special hospital train \n"
        + "to Silvis, Illinois. The train started in Cheyenne, Wyoming on November 11 and took 9 days despite a few \n"
        + $"issues that happened along the way such as 5511 needing constant maintenance and issues in\n"
        + $"on the Union Pacific system. On November 19, the day the train rolled through the Quad Cities, the train's consist\n"
        + $" was {trainInfo}. Some of the locomotives and rolling stock were donated by Union Pacific to the Railroading Heritage \n"
        + $"of Midwest America which was a nonprofit group dedicated to railroad preservation. \n"
        + $"There were a few more cars and a former Chicago and Northwestern diesel but these were left in Council Bluffs \n"
        + $"as the trains on Union Pacific weren't moving and the C&NW diesel needed to get to Boone. This diesel would stay \n"
        + $"in Council Bluffs while the Hospital train continued east to Silvis. The train crossed over the Mississippi River in \n"
        + $"the late afternoon before reaching Silvis at the former Rock Island shops where 5511 would undergo a rebuild to return\n"
        + $"her to service. ";
    }
    public override string GetDescription(int year)
    {
        return GetDescription(year, _trainInfo);
    }
}