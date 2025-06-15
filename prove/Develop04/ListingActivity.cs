class ListingActivity : Activity
{
    List<string> _prompts;
    public ListingActivity(string name, string description, int seconds)
    : base(name, description, seconds)
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?\n",
            "What are personal strengths of yours?\n",
            "Who are people that you have helped this week?\n",
            "When have you felt the Holy Ghost this month?\n",
            "Who are some of your personal heroes?"
        };

    }
    public void RunActivity()
    {
        DisplayGreeting();
        Console.WriteLine("This activity will help you reflect on the good things\n",
        "in your life by having you list as many things as you can in a certain area.");
        SetPrompts();
        DisplayEnding();

    }
    private void SetPrompts()
    {
        DateTime futureT = DateTime.Now.AddSeconds(ObtainDuration());
        while (DateTime.Now < futureT)
        {
            Console.Write(GetRandomStringFrom(_prompts));
            DisplaySpinner("", 5);
        }
        ;
    }
        private string GetRandomStringFrom(List<string> prompt)
    {
        Random Reflect = new Random();
        int randomNumber = Reflect.Next(prompt.Count);
        return prompt[randomNumber]; 
    }
}