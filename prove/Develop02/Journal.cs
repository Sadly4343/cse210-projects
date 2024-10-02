public class Journal
{
    public List<Entry> _entries;

    public void AddEntry(Entry entries)
    {
        _entries.Add(entries);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._promptText},{entry._entryText},{entry._remindText}");
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        Console.WriteLine("Reading list from file...");
        List<Entry> entries = new List<Entry>();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Entry entry = new Entry
            {
                _date = parts[0],
                _promptText = parts[1],
                _entryText = parts[2],
                _remindText = parts[3]
            };
            entries.Add(entry);
        }
        _entries = entries;
    }
}