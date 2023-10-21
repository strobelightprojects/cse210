using System;
using System.Collections.Generic;
using System.Text;

public class Scripture
{
    private List<Word> words = new List<Word>();
    private int hiddenWordCount = 0;

    public Scripture(string text)
    {
        string[] wordArray = text.Split(' ');
        foreach (string word in wordArray)
        {
            words.Add(new Word(word));
        }
    }

    public void HideRandomWord()
    {
        if (hiddenWordCount < words.Count)
        {
            Random random = new Random();
            int index;
            do
            {
                index = random.Next(words.Count);
            } while (words[index].IsHidden);

            words[index].Hide();
            hiddenWordCount++;
        }
    }

    public void HideRandomWords(int minWordsToHide = 1, int maxWordsToHide = 3)
    {
        if (hiddenWordCount < words.Count)
        {
            Random random = new Random();

            int wordsToHide = random.Next(minWordsToHide, maxWordsToHide + 1);

            for (int i = 0; i < wordsToHide; i++)
            {
                int index;
                do
                {
                    index = random.Next(words.Count);
                } while (words[index].IsHidden);

                words[index].Hide();
                hiddenWordCount++;
            }
        }
    }

    public bool AllWordsHidden()
    {
        return hiddenWordCount == words.Count;
    }

    public string GetScriptureText()
    {
        StringBuilder scriptureText = new StringBuilder();
        foreach (Word word in words)
        {
            scriptureText.Append(word.ToString() + " ");
        }
        return scriptureText.ToString().Trim();
    }

    public string GetScriptureTextForCSV()
    {
        StringBuilder scriptureText = new StringBuilder();
        foreach (Word word in words)
        {
            scriptureText.Append(word.Text + " ");
        }
        return scriptureText.ToString().Trim();
    }
}
