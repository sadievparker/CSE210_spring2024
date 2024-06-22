
using System.Data;

using System;
using System.Collections.Generic;

public class Entry
{

    public string Date;
    public string Prompt;
    public string Response;

   public Entry(string date, string prompt, string response)
    {
        Date = date;
        Prompt = prompt;
        Response = response;
    }

    public Entry(string date, string response)
    {
        Date = date;
        Prompt = GetRandomPrompt();
        Response = response;
    }
     public static List<string> Prompts { get; } = new List<string> 
    {
        "Who was the most interesting person I interacted with today?", // random questions to be displayed for write
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, Prompts.Count);
        return Prompts[index];
    }

    public override string ToString()
    {
        return $"{Date} Prompt: {Prompt}\nResponse: {Response}";
    }
}
