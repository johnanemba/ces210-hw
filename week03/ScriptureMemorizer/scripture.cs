using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public Reference Ref { get; }
    private List<Word> Words { get; }

    public Scripture(Reference reference, string text)
    {
        Ref = reference;
        Words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public void Display()
    {
        Console.WriteLine(Ref);
        Console.WriteLine(string.Join(" ", Words));
    }

    public void HideRandomWords(int count)
    {
        Random random = new Random();
        List<Word> visibleWords = Words.Where(w => !w.IsHidden).ToList();

        if (visibleWords.Count == 0) return;

        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            Word word = visibleWords[random.Next(visibleWords.Count)];
            word.Hide();
            visibleWords.Remove(word);
        }
    }

    public void RevealWord()
    {
        List<Word> hiddenWords = Words.Where(w => w.IsHidden).ToList();
        if (hiddenWords.Count > 0)
            hiddenWords[new Random().Next(hiddenWords.Count)].Reveal();
    }

    public bool IsFullyHidden()
    {
        return Words.All(w => w.IsHidden);
    }
}
