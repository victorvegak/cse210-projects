public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    public Reference (string referenceText)
    {
        //parse the reference text and initialize the reference object 
        ParseReferenceText(referenceText);
    }

    // public Reference (string referenceText, int verseEnd)
    // {
    //     ParseReferenceText(referenceText);
    //     _verseEnd = verseEnd;
    // }

    // public string GetScriptureText()
    // {
    //     return "This is the full text of the scripture.";
    // }
    public override string ToString()
    {
        return $"{_book} {_chapter}:{_verseStart}-{_verseEnd}";
    }
    private void ParseReferenceText(string referenceText)
    {
        // split the refeerence text into parts 
        string [] parts = referenceText.Split(' ');

        if (parts.Length >= 2)
        {
            _book = parts[0];
            string[] chapterVerseParts = parts[1].Split(":");

            if (chapterVerseParts.Length >= 2)
            {
                if (int.TryParse(chapterVerseParts [0], out _chapter))
                {
                    string[] verseParts = chapterVerseParts [1].Split('.');

                    if (verseParts.Length >=2 && int.TryParse(verseParts[0], out _verseStart) && int.TryParse(verseParts[1], out _verseEnd))
                    {
                        return;
                    }
                }
            }
        }
    }
}