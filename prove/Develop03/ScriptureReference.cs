public class ScriptureReference
{
    public string Reference { get; }

    public string Book { get; private set; }
    public int Chapter { get; private set; }
    public int VerseStart { get; private set; }
    public int VerseEnd { get; private set; }

    public ScriptureReference(string reference)
    {
        Reference = reference;

        string[] parts = reference.Split(' ');

        if (parts.Length < 2)
            throw new ArgumentException("Invalid scripture reference.");

        string[] bookParts = parts[0].Split(':');
        if (bookParts.Length != 2)
            throw new ArgumentException("Invalid scripture reference.");

        Book = bookParts[0];
        string[] chapterVerse = bookParts[1].Split('-');

        if (chapterVerse.Length == 1)
        {
            Chapter = int.Parse(chapterVerse[0]);
            VerseStart = VerseEnd = int.Parse(parts[1]);
        }
        else if (chapterVerse.Length == 2)
        {
            Chapter = int.Parse(chapterVerse[0]);
            VerseStart = int.Parse(chapterVerse[1].Split('-')[0]);
            VerseEnd = int.Parse(chapterVerse[1].Split('-')[1]);
        }
        else
        {
            throw new ArgumentException("Invalid scripture reference.");
        }
    }

    public override string ToString()
    {
        if (VerseStart == VerseEnd)
            return $"{Book} {Chapter}:{VerseStart}";
        else
            return $"{Book} {Chapter}:{VerseStart}-{VerseEnd}";
    }
}
