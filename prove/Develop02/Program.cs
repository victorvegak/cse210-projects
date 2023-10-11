using System;

Console.WriteLine("Hello Develop02 World!");

Journal journal = new Journal();
UserInterface ui = new UserInterface();

while (true)
{
    int choice = ui.DisplayMenu(); //  Display the menu, user choice involved

    switch (choice)
    {
        case 1:
            string prompt = journal.GenerateRandomPrompt(); // Generate a random prompt 
            string response = ui.GetUserResponse(prompt); // getting user's response
            journal.AddEntry(prompt, response); //add the entry to your journal
            break;
        case 2:
            ui.DisplayJournal(journal.GetEntries()); //displaying Journal entries
            break;
        case 3:
            string filename = ui.GetFilenameForSave(); //get the filename to save the journal
            journal.SaveToFile(filename); // save the journal to a file
            break;
        case 4:
            string loadFilename = ui.GetFilenameForLoad(); // getting the filename to load the journal 
            journal.LoadFromFile(loadFilename); // Loading the Journal            
            break;
        case 5:
            Environment.Exit(0); // Exit Program 
            break;
        default:
            Console.WriteLine("Invalid choice. Try again.");
            break;
    }
}
