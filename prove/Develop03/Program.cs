using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Clear();

        
        Console.WriteLine("1. View and hide words in existing scriptures");
        Console.WriteLine("Enter your choice (1): ");
        string choice = Console.ReadLine();

        List<string> updatedLines = new List<string>(); 

    
      if (choice == "1")
        {
            Console.Clear();
            Console.WriteLine("Existing Scriptures:");

            string[] lines = File.ReadAllLines("scripture.csv");

            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {lines[i]}");
            }

            Console.WriteLine("Enter the number of the scripture to hide words for (1, 2, etc.): ");
            string selection = Console.ReadLine();

            if (int.TryParse(selection, out int selectedScripture) && selectedScripture >= 1 && selectedScripture <= lines.Length)
            {
                string selectedLine = lines[selectedScripture - 1];
                Console.WriteLine($"Selected Scripture: {selectedLine}");

                // Manipulate the selected scripture - hide words
                Scripture scripture = new Scripture(selectedLine);

                while (!scripture.AllWordsHidden())
                {
                    Console.Clear();
                   // Console.WriteLine($"Selected Scripture: {selectedLine}");
                    Console.WriteLine(scripture.GetScriptureText());

                    Console.WriteLine("Press Enter to hide 1-3 words, or type 'quit' to exit:");
                    string hideWordChoice = Console.ReadLine();

                    if (hideWordChoice.ToLower() == "quit")
                        break;

                    scripture.HideRandomWords(1,3);
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
