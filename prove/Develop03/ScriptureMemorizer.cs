// ScriptureMemorizer.cs
using System;
using System.Collections.Generic;
using System.Linq;

public class ScriptureMemorizer
{
    private List<Word> words;
    private int wordsToHide;

    public bool AllWordsHidden => words.All(word => word.AllWordsHidden());

    public ScriptureMemorizer(ScriptureLibrary scriptureLibrary)
    {
        var randomScripture = scriptureLibrary.GetRandomScripture();
        words = randomScripture.GetText().Split(' ').Select(word => new Word(word)).ToList();
        wordsToHide = 2; // Adjust this value to change the number of words hidden at a time.
    }

    public string GetHiddenText()
    {
        return $"{words.First().GetReference()} - {string.Join(" ", words.Select(word => word.GetWordText()))}";
    }

    public void HideRandomWords()
    {
        var random = new Random();
        var wordsToHideIndices = Enumerable.Range(0, words.Count)
                                           .Where(index => !words[index].AllWordsHidden())
                                           .OrderBy(index => random.Next())
                                           .Take(wordsToHide);

        foreach (var index in wordsToHideIndices)
        {
            words[index].Hide();
        }
    }
}
