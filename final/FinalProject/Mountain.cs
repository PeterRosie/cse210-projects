class Mountain
{
    private string _problem;
    public Mountain(string loco, int year, string description, string problem)
    : base(loco, year, description)
    {
        _problem = problem;
    }
    public override string GetDescription()
    {
        Console.WriteLine($"Frisco 1522 visited the Quad Cities in October 1990 while travelling from St. Louis\n"
        + "to St. Paul for some excursions on the Soo Line. The engine was plagued with " + {_problem} "during the trip."\n
        + "It stopped for the problem to be fixed in Moline before continuing at sundown through Rock Island before crossing "\n
        + "the Mississippi River into Davenport, Iowa.");
    }
}