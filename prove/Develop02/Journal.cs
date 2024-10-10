using System;
using System.IO; 

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveJournal()
    {
        Console.WriteLine("What would you like the file to be named (no spaces/special characters)");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}|{entry._prompt}|{entry._answer}");
            }
        }
    }

        public void UploadJournal()
    {
        List<Entry> loadedJournal = new List<Entry>();
        Console.WriteLine("What is the filename you are uploading from?");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
            {
                Entry newEntry = new Entry();

                string[] parts = line.Split("|");
                string date = parts[0];
                string prompt = parts[1];
                string answer = parts[2];

                newEntry._date = date;
                newEntry._prompt = prompt;
                newEntry._answer = answer;

                loadedJournal.Add(newEntry);

            }
            _entries = loadedJournal;
    }

}
