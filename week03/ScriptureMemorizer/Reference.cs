using System;


class Reference
{
    private string _book; 

    private int _chapter;
    private int _verse;

    private int _endVerse;

    public string GetDisplayText()
    {
        string _reference;

        if (_endVerse != 0)
        {
            _reference = $"{_book} {_chapter}:{_verse}-{_endVerse} ";
        }
        else
        {
            _reference = $"{_book} {_chapter}:{_verse} ";
        }

        Console.Write(_reference);
        return _reference;
    }

    public void SetScripture(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

     public void SetScripture(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
}

