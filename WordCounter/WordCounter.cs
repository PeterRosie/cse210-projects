class WordCounter
{
    private List<string> _words;

    public WordCounter(string text)
    {
        _words = new List<string>();
    }

    public WordCounter(string text, int count)
    {
        _words = new List<string>();
    }

    private void SplitTextIntoWords(string text)
    {
        string[] words = text.Split(' ');

        foreach (string word in words)
        {
            _words.Add(word);
        }
    }

    public void DisplayWords()
    {
        foreach (string word in _words)
        {
            Console.WriteLine(word);
        }
    }
    public int CountSingleWord(string searchWord)
    {
        int count = 0;

        foreach (string word in _words)
        {
            if (word == searchWord)
                count++;
        }
        return count;
    }
}