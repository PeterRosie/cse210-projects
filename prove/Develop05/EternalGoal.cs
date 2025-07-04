class EternalGoal : Goal
{
    private int _numberOfCompletions;
    public EternalGoal(string name, string description, int points, string goalType, bool status, int completions)
    : base(name, description, points, status, goalType)
    {
        _numberOfCompletions = completions;

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
    public override string GetGoalType()
    {
        return goalType;
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
    
}