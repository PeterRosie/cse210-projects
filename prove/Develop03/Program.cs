using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args) // The main function
    {
        List<Scripture> scriptures = new List<Scripture>();
        Scripture atone = new Scripture("Ether", 12, 27, "And if men come unto me I will show unto them their weakness.\n" +
        "I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves\n" +
        ", and have faith in me, then will I make weak things become strong unto them.");
        // First scripture: Ether 12:27
        Scripture fav = new Scripture("Ether", 12, 6, "And now, I, Moroni, would speak somewhat \n" +
        "concerning these things; I would show unto the world that faith is things which are hoped for and not seen;\n" +
        "wherefore, dispute not because ye see not, for ye receive no witness until after the trail of your faith.");
        // Second scripture: Ether 12:6
        Scripture seek = new Scripture("Ether", 12, 41, "And now, I would commend you to seek this Jesus \n" +
        "of whom the prophets and apostles have written, that the grace of God the Father, and also \n" +
        "the Lord Jesus Christ, and the Holy Ghost, which beareth record of them, may be and abide in you forever. Amen");
        // Third scripture: Ether 12:41
        scriptures.Add(atone);
        scriptures.Add(fav);
        scriptures.Add(seek);
        // Adding the three scriptures


        int count = 1; // initializing the count in the for loop
        Console.Clear();
        foreach (Scripture scripture in scriptures)
        {
            Console.WriteLine($"{count} -> {scripture.GetScriptureReference()}");
            // The options for the scripture reference that's displayed
            count++;
        }

        Console.WriteLine("Welcome to the scripture memorization program? ");
        Console.WriteLine("Which scripture would you like to memorize? ");
        // welcome statements and asking the user for which scripture they want to memorize
        int selectScripture = int.Parse(Console.ReadLine()) - 1; // user's input
        Debug.Assert(selectScripture >= 0); // assert that the user's input is greater than 0.
        Debug.Assert(selectScripture < scriptures.Count);
        // assert that the user's input should be less than the total count which should be three


        string input = "a"; // initializing the choice
        bool done = false; // initializing the done variable
        while (input != "q" && !done)
        {
            Console.Clear();
            Console.WriteLine("Enter q to quit, press Enter to remove words: ");
            // ask the user if they want to quit or remove some words

            scriptures[selectScripture].ShowScripture(); 
            done = scriptures[selectScripture].HideSomeWords();
            if (!done)
            {
                input = Console.ReadLine();
                if (input == "")
                {
                    scriptures[selectScripture].HideSomeWords();
                }
            }
        }

    }
}