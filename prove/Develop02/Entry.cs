using System;

class Entry
{// store prompt, response and date 
    public string Prompt { get; }
    public string Response { get; }
    public string  Date { get; }

    public Entry (string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public override string ToString()// this allow us to use | for our format 
    {
        return $"{Prompt} | {Response} | {Date}";
    }
}