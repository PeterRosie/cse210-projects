class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int seconds)
    : base(name, description, seconds)
    {
        
    }
    public void RunActivity()
    {
        DisplayGreeting();
        Console.WriteLine("This activity will help you relax\n",
        "by walking you through breathing in and out slowly.\n",
        "Clear your mind and focus on your breathing.");
        
        
    }
}