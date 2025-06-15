class ReflectionActivity : Activity
{
    List<string> _prompts;
    List<string> _questions;
    public ReflectionActivity(string name, string description, int seconds)
    : base(name, description, seconds)
    {
        _prompts = new List<string>{
            "Think of a time when you stood up for someone else\n",
            "Think of a time when you did something really difficult.\n",
            "Think of a time when you helped someone in need.\n",
            "Think of a time when you did something truly selfless."
        };
        _questions = new List<string>
        {
            "Why was this experience meaningful to you?\n",
            "How you ever done anything like this before?\n",
            "How did you get started?\n",
            "How did you feel when it was complete?\n",
            "What made this time different than other times when you were not as successful?\n",
            "What is your favorite thing about this experience?\n",
            "What could you learn from this experience that applies to other situations?\n",
            "What did you learn about yourself through this experience?\n",
            "How can you keep this experience in mind in the future?"
        };

    }
    public void RunActivity()
    {
        DisplayGreeting();
        Console.WriteLine("We're going to be reflecting on good times. ");
        SetPromptsAndQuestions();
        DisplayEnding();


    }
    private void SetPromptsAndQuestions()
    {
        DateTime futureT = DateTime.Now.AddSeconds(ObtainDuration());
        Console.Write(GetRandomStringFrom(_prompts));
        while (DateTime.Now < futureT)
        {
            Console.Write(GetRandomStringFrom(_questions));
            DisplaySpinner("", 5);
        };

    }
    private string GetRandomStringFrom(List<string> prompt)
    {
        Random Reflect = new Random();
        int randomNumber = Reflect.Next(prompt.Count);
        return prompt[randomNumber]; 
    }
}