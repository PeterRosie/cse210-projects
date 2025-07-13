abstract class SteamLoco
{
    private string _locoID;
    private int _year;
    private string _description;

    public SteamLoco(string loco, int year, string description)
    {
        _locoID = loco;
        _year = year;
        _description = description;
    }
    public string GetLocoID()
    {
        return $"{_locoID}";
    }
    public int GetYear()
    {
        return _year;

    }
    public bool RanTrips()
    {
        Console.Write("Did it run any excursions while in the Quad Citiies?");
        string response = Console.ReadLine();
        return response == "Yes" || response == "yes";
    }
    public bool PublicEvent()
    {
        Console.Write("Did it participate in a public event during its visit to the Quad Cities?");
        string pEvent = Console.ReadLine();
        return pEvent == "Yes" || pEvent == "yes";
        
    }
    public abstract string GetDesciption();
}