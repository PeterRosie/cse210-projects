using System;
using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;

class Program
{
    public static string ObtainFileName(string FName) 
    // method for obtaining the file name
        {
        Console.Write(FName);
        FName = Console.ReadLine();
        return FName;
        }

    static void Main(string[] args)
    // the main method
    {



        Journal journal = new Journal(); // variable for Journal
        string answer = ""; // initializing the variable for the while loop

        while (answer != "5") // While loop
        {
            Console.WriteLine("1. New Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save the journal");
            Console.WriteLine("4. Load the journal");
            Console.WriteLine("5. Quit"); // The options that are displayed
            Console.WriteLine("Enter an option: "); // Asking for a choice to be entered
            answer = Console.ReadLine(); 
            switch (answer)
            {

                case "1": // if the user chooses a new entry
                    JournalEntry journalEntry = new JournalEntry(); 
                    string query = journalEntry.EntryPromptRandom(); 
                    // variable that holds the questions
                    journalEntry.Showentry();
                    // variable that shows the journal entry
                    journalEntry.GetEntryInput();
                    // variable that gets the user's response
                    journal.newJournalEntry.Add(journalEntry);
                    break;
                case "2":

                    journal.DisplayAllEntries(); //All journal entries displayed
                    break;

                case "3":

                    string fiName = ObtainFileName("File Name to which to read Journal: ");
                    // function call for ObtainFileName
                    journal.ReadFromFile(fiName); // function call for ReadFromFile in the Journal class
                    break;

                case "4":
                    fiName = ObtainFileName("File Name to which to write Journal: "); 
                    // function call for ObtainFileName
                    journal.WriteToFile(fiName); // function call for WriteToFile in the Journal class
                    break;
                case "5":
                    break; // if the user chooses to quit



            }
        }
    }
}