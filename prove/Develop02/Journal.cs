namespace ConsoleApp1;

public class Journal
{
    List<Entry> _journal = new List<Entry>();

    public void DisplayJournal()
    {
        foreach (Entry entry in _journal)
        {
            entry.DisplayEntry();
        }
    }



}
