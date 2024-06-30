
using System;

class Program
{
    static Random random = new Random();
    static void Main(string[] args)
    {
        var scripture = new Scripture("John 3:16", "God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life");

        var words = SplitScrip(scripture.Text);
        bool enter = true;

        while (enter&& words.Any(w => !w.Hidden))
        {
            ClearDisplay(scripture, words);

            Console.WriteLine("Press Enter to continue or type 'quit' to finish.");
            string input = Console.ReadLine();

            if (input == "quit")
            {
                enter = false;
            }
            else
            {
                HideWords(words);
            }
        }


        static List<Word> SplitScrip(string text)
        {
            var words = text.Split(" ")
                .Select(w => new Word(w))
                .ToList();
             return words;
         }

        static void ClearDisplay(Scripture scripture, List<Word> words)
        {
            Console.Clear();
            Console.WriteLine($"{scripture.Reference}:");
            foreach (var word in words)
            {
                Console.Write(word.Hidden ? "____ " : $"{word.Text} ");
            }
            Console.WriteLine();
        }

        static void HideWords(List<Word> words)
        {
            var unhiddenWords = words.Where(w => !w.Hidden).ToList();
            int numToHide = random.Next(1, Math.Min(unhiddenWords.Count, 4));
            for (int i = 0; i < numToHide; i++)
            {
                int randomIndex = random.Next(0, unhiddenWords.Count);
                unhiddenWords[randomIndex].Hidden = true;
                unhiddenWords.RemoveAt(randomIndex);
            }
        }
    }
}
