class JournalEntry
{
    public static string Entrydate;
    // date
    public string Entryprompt;
    // question
    private static List<string> JournalList = new List<string>
    {"Who was the most interesting person I interacted with today?",
"What was the best part of my day?",
"How did I see the hand of the Lord in my life today?",
"What was the strongest emotion I felt today?",
"If I had one thing I could do over today, what would it be?"};
// list of random questions
    public static string input; 
    // reference for entry input
    private static Random random = new Random();
    // random library to use the questions randomly
    public JournalEntry(string date, string prompt, string entry)
    // method for the Journal Entry
    {
        Entrydate = date; // setting Entrydate = date for the ToString method
        Entryprompt = prompt; // setting Entryprompt = prompt for the ToString method
        input = entry; // setting input = entry for the ToString method
    }
    public JournalEntry()
    // method for the journal entry
    {
        Entrydate = ""; // initializing the Entrydate
        Entryprompt = ""; // initializing the Entry questions
        input = ""; // initializing the input
    }
    public static string Getdate()
    // method for getting the date
    {
        return DateTime.Now.ToString("MM/dd/yyyy");
        // returning the current date in the journal entry
    }
   
    public void GetEntryInput() // method for the entry input
    {
        Console.WriteLine("Enter a journal entry: "); // asking the user for a journal entry
        input = Console.ReadLine(); // storing the answer in this variable
    }
    public string EntryPromptRandom()
    // method for the questions that are asked
    {
        int randomNumber = random.Next(JournalList.Count);
        // storing the number of questions
        return JournalList[randomNumber]; // a specific question that will be asked
    }
     public void Showentry()
     // method for showing the entry
    {
        Entrydate = Getdate(); // setting up the variable for getting the date
        Console.WriteLine(Entrydate); //printing the entrydate
        Console.WriteLine("\n"); 
        Console.WriteLine(EntryPromptRandom()); //showing the question
        Console.WriteLine("\n");
        Console.WriteLine(input); // printing the user's answer to the question

    }
    public override string ToString()
    //  method for ToString
    {
        string outputString = ""; // initializing
        outputString = $"{Entrydate}#{Entryprompt}#{input}"; // the date, question, and answer shown
        return outputString; // returning the outputString
    }

}