class Mountain : SteamLoco
{
    private string _problem;
    public Mountain(string loco, int year, string problem)
    : base(loco, year, GetDescription(year, problem))
    {
        _problem = problem;
    }
    public string GetProblem()
    {
        _problem = "pilot truck issues";
        return _problem;
    }
    public static string GetDescription(int year, string problem)
    {
        return $"Frisco 1522 visited the Quad Cities in October 1990 while travelling from St. Louis\n"
        + $"to St. Paul for some excursions on the Soo Line. The engine was plagued with {problem} during the trip.\n"
        + $"It stopped for the problem to be fixed in Moline before continuing at sundown through Rock Island before crossing \n"
        + $"the Mississippi River into Davenport, Iowa.";
    }
    public override string GetDescription(int year)
    {
        return GetDescription(year, _problem);
    }
}