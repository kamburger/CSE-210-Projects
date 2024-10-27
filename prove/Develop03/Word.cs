using System;

public class Word
{
    private string _word;
    private bool _isRedacted;

    // Constructor: A word always starts as not redacted, thus _isRedacted defaults to false.
    // User inputs a string word to create word.
    public Word(string word)
    {
        _word = word;
        _isRedacted = false;
    }

    // 
    public void DisplayWord()
    {
        Console.Write($"{_word } ");
    }

    // Setter for _isRedacted: Only changes status to true, we will never need to change the _isRedacted from true to false
    public void ChangeRedactedStatus()
    {
        _isRedacted = true;
    }

    // Getter for _isRedacted
    public bool RedactStatus()
    {
        return _isRedacted;
    }

    // Changes each letter to '_', changes Redacted Status to true. 
    public void RedactWord()
    {
        string redactedWord = "";
        if (!_isRedacted)
        {
            foreach (char c in _word)
            {
                if (char.IsLetter(c))
                {
                    redactedWord += "_";
                }
                else
                {
                    redactedWord += "c";
                }
            }
            _word = redactedWord;
            ChangeRedactedStatus();
        }
    }
    
}
