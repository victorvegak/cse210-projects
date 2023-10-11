using System;

class Entry
{
    public string Prompt { get; }
    public string Response { get; }
    public string  Date { get; }

    public Entry (string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public override string ToString()
    {
        return $"{Prompt} | {Response} | {Date}";
    }
}