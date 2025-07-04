class CheckListGoal : Goal
{
    private int _numberOfCompletions;
    private int _maxGoals;
    private int _bonusPoints;

    public CheckListGoal(string name, string description, int points, bool status, int completions, int max, int bonus)
    : base(name, description, points, status)
    {
        _numberOfCompletions = completions;
        _maxGoals = max;
        _bonusPoints = bonus;

    }
    public override void RunGoal()
    {
        Console.Write("What is the name of your goal?");
        string answer = Console.ReadLine();
        Console.Write("What is a short description of it?");
        string desciptAns = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal?");
        int point = int.Parse(Console.ReadLine());
        Console.Write("How many times does this goal need to be completed for a bonus?");
        int times = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        int max = int.Parse(Console.ReadLine());
    }
    public override int RecordEvent()
    {
        Console.Write("Which goal did you accomplish?");
        int accomp = int.Parse(Console.ReadLine());
        return accomp;
    }
    public override string ToString()
    {
        return base.ToString();
    }
    public override string ListGoal()
    {

    }
    private void ObtainMaxGoal()
    {

    }
    private void ObtainBonusPoints()
    {

    }
}