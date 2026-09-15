using System;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string nameFile)
    {
        using (StreamWriter outputFile = new StreamWriter(nameFile))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date};{entry._promptText};{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split(";");
            Entry recoverEntry = new Entry
            {
                _date = parts[0],
                _promptText = parts[1],
                _entryText = parts[2]
            };
            _entries.Add(recoverEntry);
        }
    }
}