using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture jesusWept = new Scripture();

        Reference proverbRef = new Reference("Proverbs", 3, 5, 6);
        List<string> proverbString = new List<string>(){"Trust", "in", "the", "Lord", "with", "all", "thine", "heart;", "and", "lean", "not", "unto", "thine", "own",  "understanding.", "In", "all", "thy", "ways", "acknowledge", "him,", "and", "he", "shall", "direct", "thy", "paths."};
        List<Word> proverbWords = new List<Word>();
        foreach (string s in proverbString)
        {
            Word newWord = new Word(s);
            proverbWords.Add(newWord);
        }
        Scripture proverbs = new Scripture(proverbRef, proverbWords);

        Reference etherRef = new Reference("Ether", 12, 27);
        List<string> etherString = new List<string>(){"And", "if", "men", "come", "unto", "me", "I", "will", "show", "unto", "them", "their", "weakness.", "I", "give", "unto", "men", "weakness", "that", "they", "may", "be", "humble;", "and", "my", "grace", "is", "sufficient", "for", "all", "men", "that", "humble", "themselves", "before", "me;", "for", "if", "they", "humble", "themselves", "before", "me,", "and", "have", "faith", "in", "me,", "then", "will", "I", "make", "weak", "things", "become", "strong", "unto", "them."};
        List<Word> etherWords = new List<Word>();
        foreach (string s in etherString)
        {
            Word newWord = new Word(s);
            etherWords.Add(newWord);
        }
        Scripture ether = new Scripture(proverbRef, proverbWords);   


        Reference nephiRef = new Reference("Nephi", 12, 27);
        List<string> nephiString = new List<string>(){"Adam", "fell", "that", "men", "might", "be;", "and", "men", "are", "that", "they", "might", "have", "joy.",};
        List<Word> nephiWords = new List<Word>();
        foreach (string s in nephiString)
        {
            Word newWord = new Word(s);
            nephiWords.Add(newWord);
        }
        Scripture nephi = new Scripture(proverbRef, proverbWords); 

        List<Scripture> scriptures = new List<Scripture>(){ether, proverbs, jesusWept, nephi};  

        
        Random randomIndex = new Random();
        int index = randomIndex.Next(scriptures.Count());
        Scripture scriptureMem = scriptures[index]; 
        scriptureMem.DisplayScripture();
        Console.WriteLine("Press Enter to Hide a Word");
        scriptureMem.RedactScripture();           
    }
}