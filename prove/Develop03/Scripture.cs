using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _text = new List<Word>();

    //
    public Scripture()
    {
        Reference _defaultReference = new Reference();
        _reference = _defaultReference;
        Word _jesus = new Word("Jesus");
        Word _wept = new Word("Wept");
        _text = new List<Word>{_jesus, _wept};
    }

    //
    public Scripture(Reference reference, List<Word> words)
    {
        _reference = reference;
        _text = words;
    }
    
    //
    public void SetScriptureReference(Reference reference)
    {
        _reference = reference;
    }

    //
    public void SetScriptureText(List<Word> text)
    {
        _text = text;
    }

    //
    public void DisplayScripture()
    {
        _reference.DisplayReference();
        foreach (Word t in _text)
        {
            t.DisplayWord();
        }
        Console.WriteLine();
    }

    // 
    public void RedactScripture()
    {
        int _redactedCount = 0;
        Random randomIndex = new Random();
        int index = randomIndex.Next(_text.Count());
        while (_redactedCount != _text.Count())
        {
                if (!_text[index].RedactStatus())
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        _text[index].RedactWord();
                        index = randomIndex.Next(_text.Count());
                        _redactedCount += 1; 
                        Console.WriteLine();
                        DisplayScripture();                         
                    }
                }
                else
                {
                    index = randomIndex.Next(_text.Count());
                }

        }
        
    }

}
