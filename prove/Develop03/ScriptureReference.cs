class ScriptureReference
{
    private string _bookName; // attribute for the book name
    private int _chapter; // attribute for the chapter
    private int[] _verse; // attribute for the verse

    public ScriptureReference(string name, int chapter, int verse)
    {
        _bookName = name; // variable for the book name
        _chapter = chapter; // variable for the chapter
        _verse = new int[] { verse }; // variable for the verse

    }
    public ScriptureReference(string name, int chapter, int startVerse, int endVerse)
    {
        _bookName = name; // variable for the book name
        _chapter = chapter; // variable for the chapter
        _verse = new int[] { startVerse, endVerse }; // variable for the verse

    }
    public void ShowScriptureReference()
    {
        if (_verse.Length > 1)
        {
            Console.WriteLine($"{_bookName} {_chapter}:{_verse[0]}-{_verse[1]}");
            // if there is more than one verse
        }
        else
        {
            Console.WriteLine($"{_bookName} {_chapter}:{_verse[0]}");
            // if there is only one verse
        }

    }
    public string GetScriptureReference()
    {

        if (_verse.Length > 1)
        {
            return $"{_bookName} {_chapter}:{_verse[0]}-{_verse[1]}";
            // if there is more than one verse
        }
        else
        {
            return $"{_bookName} {_chapter}:{_verse[0]}";
            // if there is only one verse
        }

    }

}