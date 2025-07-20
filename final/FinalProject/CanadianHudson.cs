class CanadianHudson : SteamLoco
{
    private string _trainInfo;
    private string _trainMove;
    public CanadianHudson(string loco, int year, string trainInfo, string trainMove)
    : base(loco, year, GetDescription(year, trainInfo, trainMove))
    {
        _trainInfo = trainInfo;
        _trainMove = trainMove;
    }
    public string GetTrainInfo()
    {
        _trainInfo = "Final Spike Tour";
        return _trainInfo;
    }
    public string GetTrainMove()
    {
        _trainMove = "light engine move";
        return _trainMove;
    }
    public static string GetDescription(int year, string trainInfo, string trainMove)
    {
        return $"Canadian Pacific 2816 visited the Quad Cities on two occasions in 2024 \n"
        + $"while pulling a special train called {trainInfo}. This train commemorated the merger \n"
        + $"between the Canadian Pacific and Kansas City Southern railroads. The train departed \n"
        + $"Calgary, Alberta in Canada on April 26 and made a stops for the public to view the \n"
        + $"train on its way to and from Mexico City. On May 9, 2816 had travelled from the Chicago \n"
        + $"area across Illinois and alongside the Mississippi River in Iowa. The day was a downpour \n"
        + $"by the time the train was rolling through Iowa. Towards the end of the day, the train passed \n"
        + $"through the Davenport and laid over at the former CP Nahant freight yard. On May 10, the following \n"
        + $"day, 2816 backed the train to the downtown area for its public display stop in Davenport. After being \n"
        + $"being on displayed 2816 pulled the train back to Nahant yard. On May 11, 2816 departed Davenport heading \n"
        + $"for her next stop in Kansas City as she continued on to Mexico City. On the return journey, 2816 reached \n"
        + $"Davenport on June 27. After spending the night in Nahant yard, 2816 would leave the train and make a {trainMove} \n"
        + $"to the Rock Island shops in Silvis, Illinois which is owned by the Railroad Heritage of Midwest America for a safety \n"
        + $"event on June 28. After the event, 2816 reversed back light engine to Nahant Yard via the Iowa Interstate as far as \n"
        + $"Davenport before switching back to CPKC rails and rejoining the train. She departed Davenport on July 1 heading for \n"
        + $"Minneapolis and would spend the next several days heading back to Calgary.";
    }
    public override string GetDescription(int year)
    {
        return GetDescription(year, _trainInfo, _trainMove);
    }
    
}