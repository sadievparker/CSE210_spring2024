public class ScriptureRef
{
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    public ScriptureRef(int chapter, int startVerse, int endVerse = 0)
    {
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public override string ToString()
    {
        if (_endVerse == 0)
        {
            return $"{_chapter}:{_startVerse}";
        }
        else
        {
            return $"{_chapter}:{_startVerse}-{_endVerse}";
        }
    }
}
