class Word
{
    private string _word; // attribute for word
    private bool _hidden; // attribute for hidden

    public Word(string word)
    {
        _word =  word; // variable for word

    }
    public bool IsHidden()
    {
        return _hidden; // returning a hidden word

    }
    public void SetIsHidden(bool hidden)
    {
        _hidden = hidden; // hiding a word

    }
    public string GetWordString()
    {
        return _word; // return a word

    }
    public void DisplayWord()
    {
        if (_hidden)
        {
            Console.Write(new string('_', GetWordLength()) + ' ');
            // if the word is hidden
        }
        else
        {
            Console.Write(_word + ' ');
            // if the word is not hidden
        }

    }
    private int GetWordLength()
    {
        return _word.Length; // returning the length of the word.

    }
}