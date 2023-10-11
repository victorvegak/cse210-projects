using System;
using System.Collections.Generic;
using System.IO;


class Journal
{
    private List<Entry> entries = new List<Entry>();
    private List<string> prompts = new List<string>
    {
        "Who was the most interesting person you interacted with today?",
        "What was the best part of your day?",
        "How did you see the hand of the lord in your life today?",
        "What was the strongest emotion you felt today?",
        "If you could redo one thing today, what would it be?"
    };

    public string GenerateRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(prompts.Count);
        return prompts [index];
    }
    public void AddEntry(string prompt, string response)
    {
        Entry entry = new Entry(prompt, response, DateTime.Now.ToString());
        entries.Add(entry);
    }
    public List <Entry> GetEntries()
    {
        return entries;
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
        Console.WriteLine ("Journal saved to file succesfully!");
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        using (StreamReader reader = new StreamReader (filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split('I');
                if (parts.Length == 3)
                {
                    entries.Add(new Entry(parts[0], parts[1], parts[2]));
                
                }
            }
        }
        Console.WriteLine("Journal loaded from file succesfuly!");
    }

}
