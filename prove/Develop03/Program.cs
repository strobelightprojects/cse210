using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Clear();

        Console.WriteLine("1. Enter a new scripture");
        Console.WriteLine("2. View and hide words in existing scriptures");
        Console.WriteLine("Enter your choice (1 or 2): ");
        string choice = Console.ReadLine();

        List<string> updatedLines = new List<string>(); // Collection to store edited content

        if (choice == "1")
        {
            Console.WriteLine("Enter a scripture reference (e.g., 'Proverbs 3:5-6'): ");
            string referenceInput = Console.ReadLine();

            Console.WriteLine("Enter the scripture text: ");
            string scriptureText = Console.ReadLine();

            Console.Clear();

            // Save the scripture to a CSV file
            using (StreamWriter writer = new StreamWriter("scripture.csv", true))
            {
                writer.WriteLine(referenceInput);
                writer.WriteLine(scriptureText);
            }
        }
        else if (choice == "2")
        {
            Console.Clear();
            Console.WriteLine("Existing Scriptures:");

            // Read and display existing scriptures from the CSV file
            string[] lines = File.ReadAllLines("scripture.csv");

            for (int i = 0; i < lines.Length; i += 2)
            {
                string reference = lines[i];
                string text = lines[i + 1];

                Console.WriteLine(reference);
                Console.WriteLine(text);
            }

            Console.WriteLine("Enter the number of the scripture to hide words for (1, 2, etc.): ");
            string selection = Console.ReadLine();

            if (int.TryParse(selection, out int selectedScripture) && selectedScripture >= 1 && selectedScripture <= lines.Length / 2)
            {
                string reference = lines[(selectedScripture - 1) * 2];
                string text = lines[(selectedScripture - 1) * 2 + 1];

                Console.WriteLine($"Selected Scripture: {reference}");
                Console.WriteLine(text);

                Console.WriteLine("Do you want to hide words in this scripture? (Y/N): ");
                string hideChoice = Console.ReadLine();

                if (hideChoice.ToUpper() == "Y")
                {
                    Scripture scripture = new Scripture(text);

                    while (!scripture.AllWordsHidden())
                    {
                        Console.Clear();
                        Console.WriteLine(reference);
                        Console.WriteLine(scripture.GetScriptureText());

                        Console.WriteLine("Press Enter to hide 1-3 words, or type 'quit' to exit:");
                        string hideWordChoice = Console.ReadLine();

                        if (hideWordChoice.ToLower() == "quit")
                            break;

                        scripture.HideRandomWords(1, 3);
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid scripture selection.");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice. Please select 1 or 2.");
        }
        
        File.WriteAllLines("updated_scripture.csv", updatedLines);
    }
}
