using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;
    public Reference()
    {
        _book = "John";
        _chapter = 11;
        _verseStart = 35;
        _verseEnd = 0;
    }
    public Reference(string book, int chapter, int start)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = start;
        _verseEnd = 0;
    }
    public Reference(string book, int chapter, int start, int end)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = start;
        _verseEnd = end;
    }
    public void SetBook(string book)
    {
        _book = book;
    }
    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }
    public void SetStartVerse(int start)
    {
        _verseStart = start;
    }
    public void SetEndVerse(int end)
    {
        _verseEnd = end;
    }
    public void DisplayReference()
    {
        if _verseEnd == 0
        {
            Console.WriteLine($"{_book} {_chapter}: {_verseStart}");
        }
        else
        {
            Console.WriteLine($"{_book} {_chapter}: {_verseStart}-{_verseEnd}");
        }
    } 
}


