using System;
using System.Collections.Generic;
using System.IO;




class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        Console.Write("Enter your name: ");
        journal.JournalName = Console.ReadLine();

        journal.Entries = new List<Entry>();

        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "What was the worst part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "If I had one thing I could do over today, what would it be?",
            "What did I accomplish today?",
            "what did I not finish today?",

        };

        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Entry entry = new Entry();
                    entry.EntryDate = DateTime.Now;
                    entry.Prompt = prompts[new Random().Next(prompts.Count)];
                    Console.WriteLine("Prompt: " + entry.Prompt);
                    Console.Write("Enter your response: ");
                    entry.Response = Console.ReadLine();
                    journal.Entries.Add(entry);
                    break;

                case "2":
                    Console.WriteLine("Journal Entries:");
                    foreach (Entry e in journal.Entries)
                    {
                        Console.WriteLine($"Date: {e.EntryDate}, Prompt: {e.Prompt}");
                        Console.WriteLine($"Response: {e.Response}\n");
                    }
                    break;

                case "3":
                    Console.Write("Enter a filename to save the journal: ");
                    string filename = Console.ReadLine();
                    SaveJournalToFile(journal, filename);
                    Console.WriteLine("Journal saved to file.");
                    break;

                case "4":
                    Console.Write("Enter a filename to load the journal: ");
                    filename = Console.ReadLine();
                    journal = LoadJournalFromFile(filename);
                    Console.WriteLine("Journal loaded from file.");
                    break;

                case "5":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void SaveJournalToFile(Journal journal, string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in journal.Entries)
            {
                outputFile.WriteLine($"Date: {entry.EntryDate}");
                outputFile.WriteLine($"Prompt: {entry.Prompt}");
                outputFile.WriteLine($"Response: {entry.Response}");
                outputFile.WriteLine();
            }
        }
    }

    static Journal LoadJournalFromFile(string filename)
    {
        Journal journal = new Journal();
        journal.Entries = new List<Entry>();

        if (File.Exists(filename))
        {
            string[] lines = File.ReadAllLines(filename);

            Entry entry = null;

            foreach (string line in lines)
            {
                if (line.StartsWith("Date: "))
                {
                    entry = new Entry();
                    entry.EntryDate = DateTime.Parse(line.Substring(6));
                }
                else if (line.StartsWith("Prompt: "))
                {
                    entry.Prompt = line.Substring(8);
                }
                else if (line.StartsWith("Response: "))
                {
                    entry.Response = line.Substring(10);
                    journal.Entries.Add(entry);
                }
            }
        }

        return journal;
    }
}

