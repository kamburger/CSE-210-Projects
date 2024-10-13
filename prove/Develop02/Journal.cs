using System;
using System.IO; 

public class Journal
{
    // Attribute of a journal is a list of entris
    public List<Entry> _entries = new List<Entry>();

    // For each entry in the list of entries in the journal, DisplayJournal displays each entry
    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }

    // This function uses the example code given to us. Writes the date, prompt, and entry separated by '|',
    // so the file can be read back into the program. Saves the file to the bin (not sure how to change that)
    // Gets filename from user
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

        // Uses example code given. Reads each line and splits it into parts sepatrated by '|'
        // assigns the parts to a new entry and adds to a new journal
        // Program journal is set to equal new journal
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
