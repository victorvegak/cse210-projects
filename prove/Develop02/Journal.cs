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
        Random random = new Random(); // provide random prompts for users to answer 
        int index = random.Next(prompts.Count);
        return prompts [index];
    }
    public void AddEntry(string prompt, string response)
    {
        Entry entry = new Entry(prompt, response, DateTime.Now.ToString()); //  format 
        entries.Add(entry);
    }
    public List <Entry> GetEntries()
    {
        return entries;
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename)) // writing new data (saving entries)
        {
            foreach (Entry entry in entries)
            { // special characters in CSV Fiels 
                string prompt = entry.Prompt.Replace("\"", "\"\"");
                string response = entry. Response.Replace("\"", "\"\"");
                string date = entry.Date;

                writer.WriteLine($"\"{prompt}\",\"{response}\",\"{date}\"");
            }
        }
        Console.WriteLine ("Journal saved to file succesfully!");
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();  // this clear entries 
        using (StreamReader reader = new StreamReader (filename))//  read from the filename 
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {//split by commas 
                string[] parts = line.Split(','); //  separator added here 
                if (parts.Length == 3) // Condition helps to ensure that the line is in the correct formar 
                {
                    string prompt = parts[0].Trim('"');
                    string response = parts[1].Trim('"');
                    string date = parts[2].Trim('"');

                    entries.Add(new Entry(prompt, response, date));
                
                }
            }
        }
        Console.WriteLine("Journal loaded from file succesfuly!");
    }

}
