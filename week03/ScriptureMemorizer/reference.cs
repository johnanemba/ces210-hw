public class Reference
{
    private string _book;
    private int _chapter;
    private string _verses;

    public Reference(string reference)
    {
        string[] parts = reference.Split(' ');
        _book = parts[0];
        string[] chapterVerse = parts[1].Split(':');
        _chapter = int.Parse(chapterVerse[0]);
        _verses = chapterVerse[1];
    }

    public override string ToString()
    {
        return $"{_book} {_chapter}:{_verses}";
    }
}
