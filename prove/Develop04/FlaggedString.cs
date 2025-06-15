class FlaggedString
{
    string _prompt;
    bool _hasBeenUsed;
    public FlaggedString(string prompt, bool hidden)
    {
        _prompt = prompt;
        _hasBeenUsed = hidden;
    }
    public string GetPrompt()
    {
        return _prompt;

    }

    public string SetHasBeenUsed()
    {
        

    }
    public bool GetHasBeenUsed()
    {

    }
}