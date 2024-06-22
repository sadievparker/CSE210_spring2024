
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string filename = "entry.txt"; // file where journal will be saved 
        Console.WriteLine("Welcome to your Journal!");
        bool menu = true;
        while (menu)
        {
            Console.WriteLine("Please choose one of the following: "); // users menu choice 
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");
            Console.Write("What you you like to do?: ");
            string input = Console.ReadLine();

             if (input == "1") // to write in journal
            {
                Console.WriteLine("What is the date? mm/dd/yyyy: ");
                string date = Console.ReadLine();
                Entry newEntry = new Entry(date, "");
                Console.WriteLine($"Prompt: {newEntry.Prompt}" ); 
                Console.Write("Response: ");
                string response = Console.ReadLine();
                journal.AddEntry(date, newEntry.Prompt, response);
            }
            
            else if (input == "2") // to display enter
            {
                journal.DisplayEntries();
            }
            else if (input == "3") // to save entry
            {
                 journal.SaveToFile(filename);
            }
            else if (input == "4") // to load a past entry
            {      
                Console.WriteLine("Please enter the file name: ");
                string loadFilename = Console.ReadLine();
                journal.LoadFromFile(loadFilename);
            }
            else if (input == "5") // to quit
            {
                menu = false;
            }
            else
            {
                Console.WriteLine("Sorry that was not an option. Try again: ");
            }

            Console.WriteLine();
        }
    }
}
