class FileHandler
{
    List<Goal> _goals;
    string _filename;
    int _totalScore;

    public FileHandler()
    {

    }
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }
    public void LoadGoals(string fiName)
    {
        string[] lines = System.IO.File.ReadAllLines(fiName);
        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            string[] parts2 = parts[1].Split(",");
            string names = parts2[0];
            string descripts = parts2[1];
            int num = int.Parse(parts2[2]);
            bool stat = bool.Parse(parts2[3]);
            string goalTypes = parts2[4];
            if (goalTypes == "Simple Goal")
            {
                
            }
            else if (goalTypes == "Eternal Goal")
            {

            }
            else if (goalTypes == "CheckListGoal")
            {

            }
        }

    }
    public void SaveGoals(int totalScore, string fileName)
    {
        using (StreamWriter saveFile = new StreamWriter(fileName))
        {
            string tScore = $"{totalScore}";
            foreach (Goal g in _goals)
            {
                
                saveFile.WriteLine($"{tScore}: {g.ToString()}");

            }
        }
    }
    public void DisplayGoals()
    {

    }
    public void DisplayScore()
    {

    }
    public void RecordEvent()
    {

    }
    private void ObtainFileName(string prompt)
    {
        Console.Write(prompt);
        prompt = Console.ReadLine();
    }
}