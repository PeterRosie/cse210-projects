class Scripture
{
    List<Word> _words; // attribute for words
    ScriptureReference _reference; // attribute for scripture reference
    public Scripture(string name, int chapter, int verse, string text)
    {
        _reference = new ScriptureReference(name, chapter, verse); // scripture reference
        _words = ConvertToWords(text); // text
    }
    public Scripture(string name, int chapter, int startVerse, int endVerse, string text)
    {
        _reference = new ScriptureReference(name, chapter, startVerse, endVerse); 
        // scripture reference with the beginning and end of the reference
        _words = ConvertToWords(text); // text

    }
    public Scripture(ScriptureReference reference, string text)
    {
        _reference = reference; // scripture reference
        _words = ConvertToWords(text); // text
    }
    public bool HideSomeWords()
    {
        int numOfRemainingWords = NumberOfHiddenWords();
        if (numOfRemainingWords <= 0)
        {
            return true;
        }
        else if (numOfRemainingWords <= 3)
        {
            foreach (Word word in _words)
            {
                word.SetIsHidden(true);
            }
        }
        else
        {
            int _wordsHidden = 0;
            Random rn = new Random();
            while (_wordsHidden < 3)
            {
                int randomNumber = rn.Next(0, _words.Count);
                if (_words[randomNumber].IsHidden())
                {
                    _words[randomNumber].SetIsHidden(true);
                    _wordsHidden++;
                }

            }
        }
        return false;
        

    }
    public void ShowScripture()
    {
        foreach (Word word in _words) // for loop to show all the words in the scripture verse.
        {
            word.DisplayWord();
        }

    }
    public string GetScriptureReference()
    {
        return _reference.GetScriptureReference(); // returning a scripture reference from this method

    }
    private int NumberOfHiddenWords()
    {
        int countWord = 0;
        foreach (Word word in _words) // for loop that counts the words in the scripture reference.
        {
            if (word.IsHidden())
            {
                countWord += 1;
            }
        }
        return countWord; // returns the total number of words

    }
    private List<Word> ConvertToWords(string text)
    {
        List<Word> Words = new List<Word>(); // list of words
        string[] parts = text.Split(); 
        foreach (string word in parts) // for loop with the words
        {
            Words.Add(new Word(word)); // new words that are add
        }
        return Words;


    }

}