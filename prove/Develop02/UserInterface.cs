using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

class UserInterface
{
    public int DisplayMenu() //display Menu
    {
        Console.WriteLine("Journal Program Menu");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal");
        Console.WriteLine("4. Load the Journal");
        Console.WriteLine("5. Quit");
        Console.Write("Enter your Choice(Number): ");
        return int.Parse(Console.ReadLine());
    }

    public string GetUserResponse (string prompt) //  Response 
    {
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        return Console.ReadLine();
    }

    public void DisplayJournal(List<Entry> entries) // display Journal 
    {
        Console.WriteLine("Journal Entries:");
        foreach(Entry entry in entries)
        {
            Console.WriteLine($"{entry.Date}: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
        }
    }
    public string GetFilenameForSave() //save jornal
    {
        Console.Write("Enter a filename to save the Journal: ");
        return Console.ReadLine();
    }

    public string GetFilenameForLoad() // load the journal that was saved
    {
        Console.Write("Enter a filename to load the journal: ");
        return Console.ReadLine();
    }
}