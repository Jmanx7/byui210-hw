using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry()
    {
        Entry entryInput = new Entry();
        // Save date
        DateTime theCurrentTime = DateTime.Now;
        entryInput._date = theCurrentTime.ToShortDateString();
        // Display and save random prompt
        PromptGenerator promptGenerator = new PromptGenerator();
        entryInput._promptText = promptGenerator.GetRandomPrompt();
        // Input entry, save reminder added as an improvement
        entryInput._entryText = Console.ReadLine();
        Console.WriteLine("Entry added. ");
        Console.WriteLine("Don't forget to save it before quitting! ");
        Console.WriteLine("");
        // Add entry to list
        _entries.Add(entryInput);
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile()
    {
        string file = "journalEntries.txt";

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date} ");
                outputFile.WriteLine($"{entry._promptText} ");
                outputFile.WriteLine($"{entry._entryText} ");
                outputFile.WriteLine("");
            }
        }
        Console.WriteLine("Entries Saved! ");
        Console.WriteLine("" );
    }
    public void LoadFromFile()
    {
        string file = "journalEntries.txt";
        string[] lines = System.IO.File.ReadAllLines(file);

        for (int i = 0; i < lines.Count(); i += 4) 
        {
            Entry entryInput = new Entry();
            
            entryInput._date = lines[i];
            entryInput._promptText = lines[i+1];
            entryInput._entryText = lines[i+2];

            _entries.Add(entryInput);
        }

        Console.WriteLine("Entries loaded! Displaying... ");
        Console.WriteLine("" );
        foreach (string line in lines)
        {
            Console.WriteLine(line);
        }
    }
}