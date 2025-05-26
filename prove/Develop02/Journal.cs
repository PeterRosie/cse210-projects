class Journal
{
    public List<JournalEntry>newJournalEntry = new List<JournalEntry>();
    // list of Journal Entries
    public void DisplayAllEntries() // method for displaying the entries
    {
        foreach (JournalEntry Entry in newJournalEntry) // for loop for displaying the entries
        {
            Entry.Showentry(); // Displaying the entries
        }
    }

    public void WriteToFile(string fileName) // method for saving
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        // opening the output file
        {
            foreach(JournalEntry Entry in newJournalEntry) //for loop for journal entries
            {
                outputFile.WriteLine(Entry.ToString()); // Entries added to the file that's saved
            }

        }
    }

    public void ReadFromFile(string fileName1)
    // method for reading from the file
    {
        string[] lines = System.IO.File.ReadAllLines(fileName1);
        // Reading all lines in the file when loaded
        foreach(string line in lines) // for loop for the lines in the file
        {
            string[] parts = line.Split("#");
            // separating the entries by a line
            string date = parts[0]; //variable for the date
            string question = parts[1]; //variable for the question
            string entries = parts[2]; //variable for the entries

            JournalEntry entry = new JournalEntry(date, question, entries);
            // variable used to show the entry by date, question, entries
            newJournalEntry.Add(entry);

        }
    }
}