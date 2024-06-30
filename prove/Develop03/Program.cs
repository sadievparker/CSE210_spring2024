using System;
using System.Collections.Generic;

class Program
{
    private static readonly Random _random = new Random();

    static void Main(string[] args)
    {
        var scriptureRef = new ScriptureRef(3, 16);
        var scripture = new Scripture("John", scriptureRef, "God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life");

        var words = SplitScrip(scripture.Text);
        bool continueProgram = true;

        while (continueProgram)
        {
            ClearDisplay(scripture, words);

            bool unhiddenWords = false;
            foreach (var word in words)
            {
                if (!word.Hidden)
                {
                    unhiddenWords = true;
                    break;
                }
            }

            if (!unhiddenWords)
            {
                break;
            }

            Console.WriteLine("Press Enter to continue or type 'quit' to finish.");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                continueProgram = false;
            }
            else
            {
                HideWords(words);
            }
        }
    }

    private static List<Word> SplitScrip(string text)
    {
        var words = text.Split(" ")
            .Select(w => new Word(w))
            .ToList();
        return words;
    }

    private static void ClearDisplay(Scripture scripture, List<Word> words)
    {
        Console.Clear();
        Console.WriteLine($"{scripture.Book} {scripture.Reference}:");

        foreach (var word in words)
        {
            if (word.Hidden)
            {
                Console.Write("____ ");
            }
            else
            {
                Console.Write($"{word.Text} ");
            }
        }

        Console.WriteLine();
    }

    private static void HideWords(List<Word> words)
    {
        var unhiddenWords = new List<Word>();
        foreach (var word in words)
        {
            if (!word.Hidden)
            {
                unhiddenWords.Add(word);
            }
        }

        int numToHide = _random.Next(1, Math.Min(unhiddenWords.Count, 4));
        for (int i = 0; i < numToHide; i++)
        {
            int randomIndex = _random.Next(0, unhiddenWords.Count);
            unhiddenWords[randomIndex].Hidden = true;
            unhiddenWords.RemoveAt(randomIndex);
        }
    }
}
