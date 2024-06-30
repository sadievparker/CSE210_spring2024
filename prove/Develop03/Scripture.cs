public class Scripture
{
    public string Book { get; }
    public ScriptureRef Reference { get; }
    public string Text { get; }

    public Scripture(string book, ScriptureRef reference, string text)
    {
        Book = book;
        Reference = reference;
        Text = text;
    }
}
